namespace Ixm.Nexus.Users.Infrastructure.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<PaginacionEntity<UserEntity>> List(int pagina, int limite);
        Task<UserEntity> Login(string email, string password);
    }
}
