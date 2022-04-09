using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetUnconfirmedTransactionIds : IBaseRequest
    {
        public List<string> UnconfirmedTransactionIds { get; }

    }

    #endregion

    #region Class

    public class GetUnconfirmedTransactionIds : BaseRequest, IGetUnconfirmedTransactionIds
    {

        [JsonPropertyName("unconfirmedTransactionIds")]
        public List<string>? UnconfirmedTransactionIds { get; set; }







    }

    #endregion

}
