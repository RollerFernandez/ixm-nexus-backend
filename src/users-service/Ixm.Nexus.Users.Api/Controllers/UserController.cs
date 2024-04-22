
namespace Ixm.Nexus.Users.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Lazy<IUserApplication> _userApplication;
        private readonly ILogger _logger;

        public UserController(ILifetimeScope lifetimeScope, ILogger<UserController> logger)
        {
            _userApplication = new Lazy<IUserApplication>(() => lifetimeScope.Resolve<IUserApplication>());
            _logger = logger;
        }

        private IUserApplication UserApplication => _userApplication.Value;

        [HttpGet]
        public async Task<IActionResult> ListofUsers()
        {
            ResponseDTO response;

            try
            {
                response = await UserApplication.ListUsers(1, 10);
            }
            catch (FunctionalException ex)
            {
                response = new ResponseDTO { status = ex.Status, sucess = false, data = ex.Data, transactionId = ex.TransactionId };
                _logger.LogWarning(ex.TransactionId, ex.Message, ex);
            }
            catch (TechnicalException ex)
            {
                response = new ResponseDTO { status = ex.Status, sucess = false, data = ex.Data, transactionId = ex.TransactionId };
                _logger.LogError(ex.TransactionId, ex.Message, ex);
            }
            catch (Exception ex)
            {
                response = new ResponseDTO { status = Constants.Common.StatusResponse.TECNICAL_ERROR, sucess = false };
                _logger.LogError(response.transactionId, ex.Message, ex);
            }


            return new JsonResult(response);
        }

        [HttpGet("login/{email}/{password}")]
        public async Task<IActionResult> Login(string email, string password) {
            ResponseDTO response = await UserApplication.Login(email, password);
            return new JsonResult(response);
        }

    }
}
