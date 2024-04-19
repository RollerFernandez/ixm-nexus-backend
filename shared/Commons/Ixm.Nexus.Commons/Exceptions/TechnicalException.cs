
namespace Ixm.Nexus.Commons.Exceptions
{
    [Serializable()]
    public class TechnicalException : MatriculaException
    {
        public TechnicalException(string message) : base(StatusResponse.TECNICAL_ERROR, message)
        {
        }

        public TechnicalException(string message, dynamic data) : base(StatusResponse.TECNICAL_ERROR, message)
        {
            Data = data;
        }
    }
}
