using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{

    #region Interface
    public interface ISetRewardRecipient
    {

    }

    #endregion

    #region Class

    public class SetRewardRecipient : ISetRewardRecipient
    {
        #region API Properties

        [JsonPropertyName("rewardRecipient")]
        public string? RewardRecipient { get; set; }


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

        #region IGetRewardRecipient


        #endregion

    }

    #endregion

}
