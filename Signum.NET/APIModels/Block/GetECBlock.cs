using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetECBlock
    {
        public string EcBlockId { get; }
        public int EcBlockHeight { get; }
        public int Timestamp { get; }

    }

    #endregion

    #region Class

    public class GetECBlock : IGetECBlock
    {
        

        #region API Properties
        [JsonPropertyName("ecBlockId")]
        public string? EcBlockId { get; set; }

        [JsonPropertyName("ecBlockHeight")]
        public int EcBlockHeight { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }


        #endregion

        #region Request Time
        [JsonPropertyName("requestProcessingTime")]
        public int RequestProcessingTime { get; set; }
        #endregion

        #region Error Conditions
        [JsonPropertyName("errorCode")]
        public int ErrorCode { get; set; }

        [JsonPropertyName("errorDescription")]
        public string? ErrorDescription { get; set; }



        #endregion

        #region IGetECBlock


        #endregion

    }

    #endregion

}
