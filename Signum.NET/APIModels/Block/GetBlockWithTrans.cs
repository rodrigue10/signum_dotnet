using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetBlockWithTrans : IBaseRequest
    {
        public string Block { get; set; }
        public int Height { get; set; }
        public string Generator { get; set; }
        public string GeneratorRS { get; set; }
        public string GeneratorPublicKey { get; set; }
        public string Nonce { get; set; }
        public int ScoopNum { get; set; }
        public int Timestamp { get; set; }
        public int NumberOfTransactions { get; set; }
        public string TotalAmountNQT { get; set; }
        public string TotalFeeNQT { get; set; }
        public string BlockRewardNQT { get; set; }
        public string BlockReward { get; set; }
        public int PayloadLength { get; set; }
        public int Version { get; set; }
        public string BaseTarget { get; set; }
        public string AverageCommitmentNQT { get; set; }
        public string PreviousBlock { get; set; }
        public string NextBlock { get; set; }
        public string PayloadHash { get; set; }
        public string GenerationSignature { get; set; }
        public string PreviousBlockHash { get; set; }
        public string BlockSignature { get; set; }
        public List<Transaction> Transactions { get; set; }
  



    }

    #endregion

    #region Class


    public class Transaction
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("subtype")]
        public int Subtype { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }

        [JsonPropertyName("deadline")]
        public int Deadline { get; set; }

        [JsonPropertyName("senderPublicKey")]
        public string? SenderPublicKey { get; set; }

        [JsonPropertyName("amountNQT")]
        public string? AmountNQT { get; set; }

        [JsonPropertyName("feeNQT")]
        public string? FeeNQT { get; set; }

        [JsonPropertyName("signature")]
        public string? Signature { get; set; }

        [JsonPropertyName("signatureHash")]
        public string? SignatureHash { get; set; }

        [JsonPropertyName("fullHash")]
        public string? FullHash { get; set; }

        [JsonPropertyName("transaction")]
        public string? TransactionId { get; set; }


        [JsonPropertyName("attachmentBytes")]
        public string? AttachmentBytes { get; set; }

        [JsonPropertyName("sender")]
        public string? Sender { get; set; }

        [JsonPropertyName("senderRS")]
        public string? SenderRS { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("version")]
        public int Version { get; set; }

        [JsonPropertyName("ecBlockId")]
        public string? EcBlockId { get; set; }

        [JsonPropertyName("ecBlockHeight")]
        public int EcBlockHeight { get; set; }

        [JsonPropertyName("block")]
        public string? Block { get; set; }

        [JsonPropertyName("confirmations")]
        public int Confirmations { get; set; }

        [JsonPropertyName("blockTimestamp")]
        public int BlockTimestamp { get; set; }

        [JsonPropertyName("recipient")]
        public string? Recipient { get; set; }

        [JsonPropertyName("recipientRS")]
        public string? RecipientRS { get; set; }
    }

    public class GetBlockWithTrans : BaseRequest, IGetBlockWithTrans
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
        public List<Transaction>? Transactions { get; set; }



        #endregion


        #region IGetBlock


        #endregion

    }

    #endregion

}
