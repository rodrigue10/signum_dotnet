using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface ISubType
    {
        public int Value { get; }
        public string? Description { get; }
        public long MinimumFeeConstantNQT { get;  }
        public int MinimumFeeAppendagesNQT { get;  }
    }

    public interface ITransactionType
    {
        public int Value { get; }
        public string? Description { get; }
        public List<ISubType> Subtypes { get; }

    }

    public interface IPeerState
    {
        public int Value { get; }
        public string? Description { get; }
    }

    public interface IGetConstants : IBaseRequest
    {
        public string? GenesisBlockId { get; }
        public string? GenesisAccountId { get; }
        public int MaxBlockPayloadLength { get; }
        public int MaxArbitraryMessageLength { get; }
        public int OrdinaryTransactionLength { get; }
        public string? AddressPrefix { get;  }
        public string? ValueSuffix { get;  }
        public int BlockTime { get;  }
        public int DecimalPlaces { get;  }
        public string? NetworkName { get;  }
        public int FeeQuantNQT { get;  }
        public List<ITransactionType> TransactionTypes { get; }
        public List<IPeerState> PeerStates { get; }
  

    }

    #endregion

    #region Class
    public class Subtype : ISubType
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("minimumFeeConstantNQT")]
        public long MinimumFeeConstantNQT { get; set; }

        [JsonPropertyName("minimumFeeAppendagesNQT")]
        public int MinimumFeeAppendagesNQT { get; set; }
    }

    public class TransactionType : ITransactionType
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("subtypes")]
        public List<Subtype>? Subtypes { get; set; }

        List<ISubType> ITransactionType.Subtypes => Subtypes.ToList<ISubType>();
    }

    public class PeerState : IPeerState
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }



    public class GetConstants : BaseRequest, IGetConstants
    {
    

        #region API Properties
        [JsonPropertyName("genesisBlockId")]
        public string? GenesisBlockId { get; set; }

        [JsonPropertyName("genesisAccountId")]
        public string? GenesisAccountId { get; set; }

        [JsonPropertyName("maxBlockPayloadLength")]
        public int MaxBlockPayloadLength { get; set; }

        [JsonPropertyName("maxArbitraryMessageLength")]
        public int MaxArbitraryMessageLength { get; set; }

        [JsonPropertyName("ordinaryTransactionLength")]
        public int OrdinaryTransactionLength { get; set; }

        [JsonPropertyName("addressPrefix")]
        public string? AddressPrefix { get; set; }

        [JsonPropertyName("valueSuffix")]
        public string? ValueSuffix { get; set; }

        [JsonPropertyName("blockTime")]
        public int BlockTime { get; set; }

        [JsonPropertyName("decimalPlaces")]
        public int DecimalPlaces { get; set; }

        [JsonPropertyName("networkName")]
        public string? NetworkName { get; set; }

        [JsonPropertyName("feeQuantNQT")]
        public int FeeQuantNQT { get; set; }

        [JsonPropertyName("transactionTypes")]
        public List<TransactionType>? TransactionTypes { get; set; }

        [JsonPropertyName("peerStates")]
        public List<PeerState>? PeerStates { get; set; }

        #endregion


        #region IGetConstants
        List<ITransactionType> IGetConstants.TransactionTypes => TransactionTypes.ToList<ITransactionType>();

        List<IPeerState> IGetConstants.PeerStates => PeerStates.ToList<IPeerState>();


        #endregion

    }

    #endregion

}
