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

            var query = (from a in context.UserEntity
                               join b in context.UserRoleEntity on a.Id equals b.UserId
                               join c in context.RoleEntity on b.RoleId equals c.Id
                               join d in context.RolePermissionEntity on c.Id equals d.RoleId
                               join e in context.PermissionEntity on d.PermissionId equals e.Id
                               where a.Username == username && a.Password == password && a.Status == "A"
                               select new { user = a, roles = c, permissions = e }).AsQueryable();

            var result = await query.ToListAsync();

            UserEntity? user = null;
            List<RoleEntity> roles = new List<RoleEntity>();
            List<string> permissions = new List<string>();

            if (result.Count > 0)
            {
                user = result.Select(x => x.user).FirstOrDefault();
                roles = result.Select(x => x.roles).Distinct().ToList();
                permissions = result.Select(x => x.permissions.Description).Distinct().ToList();
            }

            return new { user, roles, permissions };

        }
        public async Task<UserEntity> GetByCode(string codigo)
        {
            return await context.UserEntity.AsQueryable().Where(x => x.Name == codigo).FirstOrDefaultAsync();
        }

        public async Task<int> ValidateMail(string email) {
            return await context.UserEntity
                .AsQueryable()
                .Where(w => w.Email == email && !w.IsLocked && w.Status == Commons.Constants.Core.UserStatus.ACTIVE)
                .CountAsync();
        }

        public async Task<UserEntity> Login(string email, string password) {
            return await context.UserEntity
                .AsQueryable()
                .Where(w => w.Email == email && w.Password == password && !w.IsLocked && w.Status == Commons.Constants.Core.UserStatus.ACTIVE)
                .FirstOrDefaultAsync();
        }
    }
}
