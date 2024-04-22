namespace Ixm.Nexus.Users.Infrastructure.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<PaginacionEntity<UserEntity>> List(int pagina, int limite);
        Task<dynamic> GetUser(string username, string password);
        Task<UserEntity> Login(string email, string password);
    }
}
