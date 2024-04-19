
namespace Ixm.Nexus.Commons.Exceptions
{
    public class MatriculaException : Exception, ISerializable
    {
        public string TransactionId { get; }
        public int Status { get; }
        public dynamic Data { get; set; }

        public MatriculaException(int statusCode, string message) : base(message)
        {
            Status = statusCode;
            TransactionId = DateTime.Now.ToString(Constants.Core.DateTimeFormats.DD_MM_YYYY_HH_MM_SS_FFF);
        }
    }
}
