namespace Ixm.Nexus.Users.Infrastructure.Repository.Implementations
{
   
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        private readonly DataContext context;

        public UserRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<PaginacionEntity<UserEntity>> List(int pagina, int limite)
        {
            var query = context.UserEntity.AsQueryable().Where(x => x.Status == "A");

            var total = await query.CountAsync();

            var result = await query.OrderBy(x => x.Id).Skip(limite * (pagina - 1)).Take(limite).ToListAsync();


            return new PaginacionEntity<UserEntity>
            {
                Items = result,
                Pages = Convert.ToInt32(Math.Ceiling(total / (limite * 1d))),
                Total = total
            };
        }

        public async Task<dynamic> GetUser(string username, string password)
        {
            UserEntity? user = await context.UserEntity.AsQueryable().Where(x => x.Username == username && x.Password == password).FirstOrDefaultAsync();
            List<RoleEntity> roles = new List<RoleEntity>();
            List<string> permissions = new List<string>();

            if(user != null)
            {
                roles = (from a in context.RoleEntity.ToList()
                          join b in context.UserRoleEntity.ToList() on a.Id equals b.RoleId
                          where b.UserId == user.Id select a).ToList();
                permissions = (from a in context.PermissionEntity.ToList()
                                 join b in context.RolePermissionEntity.ToList() on a.Id equals b.PermissionId
                                 join c in context.UserRoleEntity.ToList() on b.RoleId equals c.RoleId
                                 where c.UserId == user.Id
                                 select a.Description).Distinct().ToList();
            }

            return new { user , roles, permissions };

        }
        public async Task<UserEntity> GetByCode(string codigo)
        {
            return await context.UserEntity.AsQueryable().Where(x => x.Name == codigo).FirstOrDefaultAsync();
        }
    }
}
