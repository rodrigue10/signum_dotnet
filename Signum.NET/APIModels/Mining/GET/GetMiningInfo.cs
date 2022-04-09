using System.Collections.Generic;
using System.Numerics;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetMiningInfo : IBaseRequest
    {
        public string? Height { get; }
        public string? GenerationSignature { get; }
        public string? BaseTarget { get; }
        public string? AverageCommitmentNQT { get; }
        public string? LastBlockReward { get; }
        public string? LastBlockRewardNQT { get;  }
        public string? Timestamp { get;  }



    }

    #endregion

    #region Class

    public class GetMiningInfo : BaseRequest, IGetMiningInfo
    {


        #region API Properties

        [JsonPropertyName("height")]
        public string? Height { get; set; }

        [JsonPropertyName("generationSignature")]
        public string? GenerationSignature { get; set; }

        [JsonPropertyName("baseTarget")]
        public string? BaseTarget { get; set; }

        [JsonPropertyName("averageCommitmentNQT")]
        public string? AverageCommitmentNQT { get; set; }

        [JsonPropertyName("lastBlockReward")]
        public string? LastBlockReward { get; set; }

        [JsonPropertyName("lastBlockRewardNQT")]
        public string? LastBlockRewardNQT { get; set; }

        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }



        #endregion




    }

    #endregion

}
