using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{

    #region Interface
    public interface IGetAccountsWithRewardRecipient : IBaseRequest
    {
        public List<string>? Accounts { get; }


    }

    #endregion

    #region Class

    public class GetAccountsWithRewardRecipient : BaseRequest, IGetAccountsWithRewardRecipient
    {

        #region API Properties

        [JsonPropertyName("accounts")]
        public List<string>? Accounts { get; set; }

        #endregion

   

        #region IGetAccountsWithRewardRecipient

        List<string>? IGetAccountsWithRewardRecipient.Accounts => Accounts;
        #endregion

    }

    #endregion
}
