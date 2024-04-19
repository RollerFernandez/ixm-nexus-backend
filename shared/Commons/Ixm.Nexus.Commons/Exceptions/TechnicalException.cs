
namespace Ixm.Nexus.Commons.Exceptions
{
    [Serializable()]
    public class TechnicalException : MatriculaException
    {
        public TechnicalException(string message) : base(EstadoRespuesta.ERROR_TECNICO, message)
        {
        }

        public TechnicalException(string message, dynamic data) : base(EstadoRespuesta.ERROR_TECNICO, message)
        {
            Data = data;
        }
    }
}
