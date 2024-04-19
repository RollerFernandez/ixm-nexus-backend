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
    }
}
