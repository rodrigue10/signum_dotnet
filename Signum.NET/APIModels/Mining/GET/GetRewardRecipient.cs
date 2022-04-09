using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{

    #region Interface
    public interface IGetRewardRecipient : IBaseRequest
    {
        public string? RewardRecipient { get; }

    }

    #endregion

    #region Class

    public class GetRewardRecipient : BaseRequest, IGetRewardRecipient
    {
        #region API Properties

        [JsonPropertyName("rewardRecipient")]
        public string? RewardRecipient { get; set; }

        #endregion
           

    }

    #endregion
}
