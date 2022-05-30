using System.Text.Json.Serialization;

namespace Signum.NET
{
    public class BaseRequest : IBaseRequest
    {

        //Assumption is a Valid Request has a 0 error code from JSON request
        public bool IsValidRequest
        {
            get { return ErrorCode == 0; }
        }


        #region Request Time
        [JsonPropertyName("requestProcessingTime")]
        public int RequestProcessingTime { get; set; }
        #endregion

        #region Error Conditions
        [JsonPropertyName("errorCode")]
        public int ErrorCode { get; set; }

        
        [JsonPropertyName("error")]
        public string? Error { get; set; }

        [JsonPropertyName("errorDescription")]
        public string? ErrorDescription { get; set; }

        #endregion
    }
}