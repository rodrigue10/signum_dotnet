using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetAlias : IBaseRequest
    {
        public string Account { get; }
        public string AccountRS { get; }
        public string AliasName { get; }
        public string AliasURI { get; }
        public int Timestamp { get; }
        public string Alias { get; }
        public string PriceNQT { get; }
        public string Buyer { get; }

    }

    #endregion

    #region Class

    public class GetAlias : BaseRequest, IGetAlias
    {
     
        #region API Properties

        [JsonPropertyName("account")]
        public string? Account { get; set; }

        [JsonPropertyName("accountRS")]
        public string? AccountRS { get; set; }

        [JsonPropertyName("aliasName")]
        public string? AliasName { get; set; }

        [JsonPropertyName("aliasURI")]
        public string? AliasURI { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }

        [JsonPropertyName("alias")]
        public string? Alias { get; set; }

        [JsonPropertyName("priceNQT")]
        public string? PriceNQT { get; set; }

        [JsonPropertyName("buyer")]
        public string? Buyer { get; set; }


        #endregion

   

    }

    #endregion

}
