namespace Ixm.Nexus.Users.Application.Interfaces
{
    public interface IUserApplication
    {
        Task<ResponseDTO> ListUsers(int Pagina, int Limite);

        Task<ResponseDTO> GetByUser(string codigo);

        Task<ResponseDTO> RegisterUser(string code, string name);
}
}
