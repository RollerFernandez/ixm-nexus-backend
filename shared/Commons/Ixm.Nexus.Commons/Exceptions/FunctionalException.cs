
namespace Ixm.Nexus.Commons.Exceptions
{
    [Serializable()]
    public class FunctionalException : MatriculaException
    {
        public FunctionalException(string message) : base(StatusResponse.FUNCTIONAL_ERROR , message)
        {
        }

        public FunctionalException(string message, dynamic data) : base(StatusResponse.FUNCTIONAL_ERROR, message)
        {
            Data = data;
        }
    }
}
