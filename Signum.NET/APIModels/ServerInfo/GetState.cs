using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetState : IBaseRequest
    {

        public string? Application { get; }
        public string? Version { get; }
        public int Time { get; }
        public string? LastBlock { get; }
        public string? CumulativeDifficulty { get; }
        public long TotalMinedNQT { get; }
        public int TotalEffectiveBalance { get; }
        public long TotalEffectiveBalanceNQT { get; }
        public long TotalCommittedNQT { get; }
        public int NumberOfBlocks { get; }
        public int NumberOfTransactions { get; }
        public int NumberOfATs { get; }
        public int NumberOfAssets { get; }
        public int NumberOfOrders { get; }
        public int NumberOfAskOrders { get; }
        public int NumberOfBidOrders { get; }
        public int NumberOfTrades { get; }
        public int NumberOfTransfers { get; }
        public int NumberOfAliases { get; }
        public int NumberOfPeers { get; }
        public int NumberOfUnlockedAccounts { get; }
        public string? LastBlockchainFeeder { get; }
        public int LastBlockchainFeederHeight { get; }
        public bool IsScanning { get; }
        public int AvailableProcessors { get; }
        public long MaxMemory { get; }
        public int TotalMemory { get; }
        public int FreeMemory { get; }
        public bool IndirectIncomingServiceEnabled { get; }


    }

    #endregion

    #region Class

    public class GetState : BaseRequest, IGetState
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

        [JsonPropertyName("totalMinedNQT")]
        public long TotalMinedNQT { get; set; }

        [JsonPropertyName("totalEffectiveBalance")]
        public int TotalEffectiveBalance { get; set; }

        [JsonPropertyName("totalEffectiveBalanceNQT")]
        public long TotalEffectiveBalanceNQT { get; set; }

        [JsonPropertyName("totalCommittedNQT")]
        public long TotalCommittedNQT { get; set; }

        [JsonPropertyName("numberOfAccounts")]
        public int NumberOfAccounts { get; set; }

        [JsonPropertyName("numberOfBlocks")]
        public int NumberOfBlocks { get; set; }

        [JsonPropertyName("numberOfTransactions")]
        public int NumberOfTransactions { get; set; }

        [JsonPropertyName("numberOfATs")]
        public int NumberOfATs { get; set; }

        [JsonPropertyName("numberOfAssets")]
        public int NumberOfAssets { get; set; }

        [JsonPropertyName("numberOfOrders")]
        public int NumberOfOrders { get; set; }

        [JsonPropertyName("numberOfAskOrders")]
        public int NumberOfAskOrders { get; set; }

        [JsonPropertyName("numberOfBidOrders")]
        public int NumberOfBidOrders { get; set; }

        [JsonPropertyName("numberOfTrades")]
        public int NumberOfTrades { get; set; }

        [JsonPropertyName("numberOfTransfers")]
        public int NumberOfTransfers { get; set; }

        [JsonPropertyName("numberOfAliases")]
        public int NumberOfAliases { get; set; }

        [JsonPropertyName("numberOfPeers")]
        public int NumberOfPeers { get; set; }

        [JsonPropertyName("numberOfUnlockedAccounts")]
        public int NumberOfUnlockedAccounts { get; set; }

        [JsonPropertyName("lastBlockchainFeeder")]
        public string? LastBlockchainFeeder { get; set; }

        [JsonPropertyName("lastBlockchainFeederHeight")]
        public int LastBlockchainFeederHeight { get; set; }

        [JsonPropertyName("isScanning")]
        public bool IsScanning { get; set; }

        [JsonPropertyName("availableProcessors")]
        public int AvailableProcessors { get; set; }

        [JsonPropertyName("maxMemory")]
        public long MaxMemory { get; set; }

        [JsonPropertyName("totalMemory")]
        public int TotalMemory { get; set; }

        [JsonPropertyName("freeMemory")]
        public int FreeMemory { get; set; }

        [JsonPropertyName("indirectIncomingServiceEnabled")]
        public bool IndirectIncomingServiceEnabled { get; set; }

        #endregion


        #region IGetState



        #endregion

    }

    #endregion

}
