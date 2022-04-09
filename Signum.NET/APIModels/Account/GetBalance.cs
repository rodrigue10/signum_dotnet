using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetBalance : IBaseRequest
    {

        public string? BalanceNQT { get; }
        public string? UnconfirmedBalanceNQT { get; }
        public string? ForgedBalanceNQT { get; }
        public string? GuaranteedBalanceNQT { get; }


    }

    #endregion

    #region Class

    public class GetBalance : BaseRequest, IGetBalance
    {
     
        [JsonPropertyName("balanceNQT")]
        public string? BalanceNQT { get; set; }

        [JsonPropertyName("unconfirmedBalanceNQT")]
        public string? UnconfirmedBalanceNQT { get; set; }

        [JsonPropertyName("forgedBalanceNQT")]
        public string? ForgedBalanceNQT { get; set; }

        [JsonPropertyName("guaranteedBalanceNQT")]
        public string? GuaranteedBalanceNQT { get; set; }
  

    }

    #endregion

}
