namespace Ixm.Nexus.ExceptionHandling
{
    public class ExceptionMiddleware : IMiddleware
    {
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(ILogger<ExceptionMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try {
                await next(context);
            } catch (Exception ex) {
                HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError;
                string message = string.Empty;

                switch (ex) {
                    case FunctionalException:
                        httpStatusCode = HttpStatusCode.NotFound;
                        message = ex.Message;
                        _logger.LogWarning("FunctionalException", ex);
                        break;

                    case TechnicalException:
                        httpStatusCode = HttpStatusCode.Conflict;
                        message = "Se ha producido un error tecnico.";
                        _logger.LogWarning("TechnicalException", ex);
                        break;                    
                }

                var response = context.Response;

                if (!response.HasStarted) {
                    response.ContentType = "application/json";
                    response.StatusCode = (int)httpStatusCode;

                    MatriculaException errorResult = new((int)httpStatusCode, message);

                    await response.WriteAsync(JsonConvert.SerializeObject(errorResult));
                }
            }
        }
    }
}
