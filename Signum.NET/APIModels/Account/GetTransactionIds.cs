using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetTransactionIds : IBaseRequest
    {
        public List<string> TransactionIds { get; }

    }

    #endregion

    #region Class

    public class GetTransactionIds : BaseRequest, IGetTransactionIds
    {

        #region API Properties

        [JsonPropertyName("transactionIds")]
        public List<string>? TransactionIds { get; set; }

        #endregion


    }

    #endregion

}
