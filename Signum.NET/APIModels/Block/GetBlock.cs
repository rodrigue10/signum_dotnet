using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetBlock : IBaseRequest
    {

        public string? Block { get; }
        public int Height { get; }
        public string? Generator { get; }
        public string? GeneratorRS { get; }
        public string? GeneratorPublicKey { get; }
        public string? Nonce { get; }
        public int ScoopNum { get; }
        public int Timestamp { get; }
        public int NumberOfTransactions { get; }
        public string? TotalAmountNQT { get; }
        public string? TotalFeeNQT { get; }
        public string? BlockReward { get; }
        public int PayloadLength { get; }
        public int Version { get; }
        public string? BaseTarget { get; }
        public string? AverageCommitmentNQT { get; }
        public string? PreviousBlock { get; }
        public string? NextBlock { get; }
        public string? PayloadHash { get; }
        public string? GenerationSignature { get; }
        public string? PreviousBlockHash { get; }
        public string? BlockSignature { get; }
        public List<string> Transactions { get; }


    }

    #endregion

    #region Class

    public class GetBlock : BaseRequest, IGetBlock
    {


        #region API Properties


        [JsonPropertyName("block")]
        public string? Block { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("generator")]
        public string? Generator { get; set; }

        [JsonPropertyName("generatorRS")]
        public string? GeneratorRS { get; set; }

        [JsonPropertyName("generatorPublicKey")]
        public string? GeneratorPublicKey { get; set; }

        [JsonPropertyName("nonce")]
        public string? Nonce { get; set; }

        [JsonPropertyName("scoopNum")]
        public int ScoopNum { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }

        [JsonPropertyName("numberOfTransactions")]
        public int NumberOfTransactions { get; set; }

        [JsonPropertyName("totalAmountNQT")]
        public string? TotalAmountNQT { get; set; }

        [JsonPropertyName("totalFeeNQT")]
        public string? TotalFeeNQT { get; set; }

        [JsonPropertyName("blockRewardNQT")]
        public string? BlockRewardNQT { get; set; }

        [JsonPropertyName("blockReward")]
        public string? BlockReward { get; set; }

        [JsonPropertyName("payloadLength")]
        public int PayloadLength { get; set; }

        [JsonPropertyName("version")]
        public int Version { get; set; }

        [JsonPropertyName("baseTarget")]
        public string? BaseTarget { get; set; }

        [JsonPropertyName("averageCommitmentNQT")]
        public string? AverageCommitmentNQT { get; set; }

        [JsonPropertyName("previousBlock")]
        public string? PreviousBlock { get; set; }

        [JsonPropertyName("nextBlock")]
        public string? NextBlock { get; set; }

        [JsonPropertyName("payloadHash")]
        public string? PayloadHash { get; set; }

        [JsonPropertyName("generationSignature")]
        public string? GenerationSignature { get; set; }

        [JsonPropertyName("previousBlockHash")]
        public string? PreviousBlockHash { get; set; }

        [JsonPropertyName("blockSignature")]
        public string? BlockSignature { get; set; }

        [JsonPropertyName("transactions")]
        public List<string>? Transactions { get; set; }



        #endregion


        #region IGetBlock


        #endregion

    }

    #endregion

}
