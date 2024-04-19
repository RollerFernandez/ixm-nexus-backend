
namespace Ixm.Nexus.Commons.Exceptions
{
    [Serializable()]
    public class FunctionalException : MatriculaException
    {
        public FunctionalException(string message) : base(EstadoRespuesta.ERROR_FUNCIONAL, message)
        {
        }

        public FunctionalException(string message, dynamic data) : base(EstadoRespuesta.ERROR_FUNCIONAL, message)
        {
            Data = data;
        }
    }
}
