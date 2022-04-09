using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetBlockchainStatus : IBaseRequest
    {

        public string? Application { get; }
        public string? Version { get; }
        public int Time { get; }
        public string? LastBlock { get; }
        public string? CumulativeDifficulty { get; }
        public long AverageCommitmentNQT { get; }
        public int NumberOfBlocks { get; }
        public string? LastBlockchainFeeder { get; }
        public int LastBlockchainFeederHeight { get; }
        public bool IsScanning { get; }


    }

    #endregion

    #region Class

    public class GetBlockchainStatus : BaseRequest, IGetBlockchainStatus
    {

        #region API Properties

        [JsonPropertyName("application")]
        public string? Application { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("time")]
        public int Time { get; set; }

        [JsonPropertyName("lastBlock")]
        public string? LastBlock { get; set; }

        [JsonPropertyName("cumulativeDifficulty")]
        public string? CumulativeDifficulty { get; set; }

        [JsonPropertyName("averageCommitmentNQT")]
        public long AverageCommitmentNQT { get; set; }

        [JsonPropertyName("numberOfBlocks")]
        public int NumberOfBlocks { get; set; }

        [JsonPropertyName("lastBlockchainFeeder")]
        public string? LastBlockchainFeeder { get; set; }

        [JsonPropertyName("lastBlockchainFeederHeight")]
        public int LastBlockchainFeederHeight { get; set; }

        [JsonPropertyName("isScanning")]
        public bool IsScanning { get; set; }

        #endregion


        #region IGetBlockchainStatus


        #endregion

    }

    #endregion

}
