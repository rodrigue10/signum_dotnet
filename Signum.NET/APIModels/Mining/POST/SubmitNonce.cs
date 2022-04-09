using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{

    #region Interface
    public interface ISubmitNonce
    {


    }

    #endregion

    #region Class

    public class SubmitNonce : ISubmitNonce
    {
        #region API Properties




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


        #region ISubmitNonce


        #endregion

    }

    #endregion
}
