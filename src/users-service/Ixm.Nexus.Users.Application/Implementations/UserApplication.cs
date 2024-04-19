
namespace Ixm.Nexus.Users.Application.Implementations
{
    public class UserApplication : IUserApplication
    {
        private readonly Lazy<IUnitOfWork> _unitOfWork;
        private readonly Lazy<IHttpContextAccessor> _httpContext;
        private readonly AppSettings _settings;

        public UserApplication(IOptions<AppSettings> appSettings, ILifetimeScope lifetimeScope)
        {
            _settings = appSettings.Value;
            _httpContext = new Lazy<IHttpContextAccessor>(() => lifetimeScope.Resolve<IHttpContextAccessor>());
            _unitOfWork = new Lazy<IUnitOfWork>(() => lifetimeScope.Resolve<IUnitOfWork>());
        }

        private ClaimsPrincipal UserIdentity
        { get { return _httpContext.Value.HttpContext.User; } }
        private IUnitOfWork UnitOfWork => _unitOfWork.Value;
        private IUserRepository UserRepository => UnitOfWork.Repository<IUserRepository>();
        
        public async Task<ResponseDTO> ListUsers(int Pagina, int Limite)
        {
            var response = new ResponseDTO();

            response.data = await UserRepository.List(Pagina, Limite);
            return response;
        }

        public async Task<ResponseDTO> RegisterUser(UserEntity u)
        {
            var response = new ResponseDTO();

            await UnitOfWork.Set<UserEntity>().AddAsync(u);
            UnitOfWork.SaveChanges();

            response.data = u;
            return response;
        }
    }
}
