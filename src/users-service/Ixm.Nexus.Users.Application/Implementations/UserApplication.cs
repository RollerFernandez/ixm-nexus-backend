
using Ixm.Nexus.Users.Application.Dto.UsersDto;

namespace Ixm.Nexus.Users.Application.Implementations
{
    public class UserApplication : IUserApplication
    {
        private readonly Lazy<IUnitOfWork> _unitOfWork;
        private readonly Lazy<IHttpContextAccessor> _httpContext;
        private readonly AppSettings _settings;
        private readonly IMapper _mapper;

        public UserApplication(IOptions<AppSettings> appSettings, ILifetimeScope lifetimeScope, IMapper mapper)
        {
            _settings = appSettings.Value;
            _httpContext = new Lazy<IHttpContextAccessor>(() => lifetimeScope.Resolve<IHttpContextAccessor>());
            _unitOfWork = new Lazy<IUnitOfWork>(() => lifetimeScope.Resolve<IUnitOfWork>());
            _mapper = mapper;
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

        public async Task<ResponseDTO> GetUser(string username, string password)
        {
            var response = new ResponseDTO();
            response.data = await UserRepository.GetUser(username, password);
            return response;
        }

        public async Task<ResponseDTO> RegisterUser(UserEntity u)
        {
            var response = new ResponseDTO();

            var userEntity = new UserEntity
            {
                //Codigo = code,
                Name = u.Name

            };

            await UnitOfWork.Set<UserEntity>().AddAsync(userEntity);
            UnitOfWork.SaveChanges();

            response.data = userEntity;
            return response;
        }

        public async Task<ResponseDTO> Login(string email, string password) {

            //Agregar validacion de usuario

            UserDto record = _mapper.Map<UserDto>(await UserRepository.Login(email, password));

            return new()
            {
                data = record
            };
        }
    }
}
