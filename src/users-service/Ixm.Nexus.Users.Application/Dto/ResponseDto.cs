using Ixm.Nexus.Commons;
using static Ixm.Nexus.Commons.Constants.Common;

namespace Ixm.Nexus.Users.Application.Dto
{
    public class ResponseDTO
    {
        public ResponseDTO()
        {
            this.status = StatusResponse.OK;
            this.sucess = true;
            this.transactionId = DateTime.Now.ToString(Constants.Core.DateTimeFormats.DD_MM_YYYY_HH_MM_SS_FFF);
        }

        public string transactionId { get; set; }
        public int status { get; set; }
        public bool sucess { get; set; }
        public dynamic data { get; set; }
    }
}
