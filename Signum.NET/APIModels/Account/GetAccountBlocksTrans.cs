using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Signum.NET
{

    #region Interfaces
    public interface IGetAccountBlocksTrans : IBaseRequest
    {
        public List<IBlockGABT> Blocks { get; }

    }
    public interface ITransactionGABT
    {

        public int Type { get; }
        public int Subtype { get; }
        public int Timestamp { get; }
        public int Deadline { get; }
        public string SenderPublicKey { get; }
        public string Recipient { get; }
        public string RecipientRS { get; }
        public string AmountNQT { get; }
        public string FeeNQT { get; }
        public string Signature { get; }
        public string SignatureHash { get; }
        public string FullHash { get; }
        public string TransactionID { get; }
        public string Sender { get; }
        public string SenderRS { get; }
        public int Height { get; }
        public int Version { get; }
        public string EcBlockId { get; }
        public int EcBlockHeight { get; }
        public string Block { get; }
        public int Confirmations { get; }
        public int BlockTimestamp { get; }

    }
    public interface IBlockGABT
    {

        public string Block { get; }
        public int Height { get; }
        public string Generator { get; }
        public string GeneratorRS { get; }
        public string GeneratorPublicKey { get; }
        public string Nonce { get; }
        public int ScoopNum { get; }
        public int Timestamp { get; }
        public int NumberOfTransactions { get; }
        public string TotalAmountNQT { get; }
        public string TotalFeeNQT { get; }
        public string BlockReward { get; }
        public int PayloadLength { get; }
        public int Version { get; }
        public string BaseTarget { get; }
        public string AverageCommitmentNQT { get; }
        public string PreviousBlock { get; }
        public string NextBlock { get; }
        public string PayloadHash { get; }
        public string GenerationSignature { get; }
        public string PreviousBlockHash { get; }
        public string BlockSignature { get; }
        public List<ITransactionGABT> Transactions { get; }

    }
    #endregion

    #region Class

    public class TransactionGABT : ITransactionGABT
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

        [JsonPropertyName("recipient")]
        public string? Recipient { get; set; }

        [JsonPropertyName("recipientRS")]
        public string? RecipientRS { get; set; }

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
        public string? TransactionID { get; set; }

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
    }

    public class BlockGABT : IBlockGABT
    {
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
        public List<TransactionGABT>? Transactions { get; set; }

        #region IBlockGAB

        List<ITransactionGABT> IBlockGABT.Transactions =>
            Transactions.ToList<ITransactionGABT>();

        #endregion
    }

    public class GetAccountBlocksTrans : BaseRequest, IGetAccountBlocksTrans
    {



        #region API Properties




        [JsonPropertyName("blocks")]
        public List<BlockGABT>? Blocks { get; set; }

        #endregion


        #region IGetAccountBlocksTrans

        List<IBlockGABT> IGetAccountBlocksTrans.Blocks => 
            Blocks.ToList<IBlockGABT>();


        #endregion


    }

    #endregion


}
