using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Signum.NET
{

    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class AttachmentAddCommitmentSignedResponse
    {
        [JsonPropertyName("version.CommitmentAdd")]
        public int VersionCommitmentAdd { get; set; }

        [JsonPropertyName("amountNQT")]
        public int AmountNQT { get; set; }
    }

    public class TransactionAddCommitmentSignedResponse
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
        public string? Transaction { get; set; }

        [JsonPropertyName("attachment")]
        public AttachmentAddCommitmentSignedResponse? AttachmentAddCommitmentSignedResponse { get; set; }

        [JsonPropertyName("sender")]
        public string? Sender { get; set; }

        [JsonPropertyName("senderRS")]
        public string? SenderRS { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("version")]
        public int Version { get; set; }

        [JsonPropertyName("ecBlockId")]
        public string? EcBlockId { get; set; }

        [JsonPropertyName("ecBlockHeight")]
        public int EcBlockHeight { get; set; }
    }


    class AddCommitmentSignedResponse
    {

 


            [JsonPropertyName("transaction")]
            public string? Transaction { get; set; }

            [JsonPropertyName("fullHash")]
            public string? FullHash { get; set; }

            [JsonPropertyName("transactionBytes")]
            public string? TransactionBytes { get; set; }

            [JsonPropertyName("signatureHash")]
            public string? SignatureHash { get; set; }

            [JsonPropertyName("numberPeersSentTo")]
            public int NumberPeersSentTo { get; set; }

            [JsonPropertyName("broadcasted")]
            public bool Broadcasted { get; set; }

            [JsonPropertyName("unsignedTransactionBytes")]
            public string? UnsignedTransactionBytes { get; set; }

            [JsonPropertyName("transactionJSON")]
            public TransactionAddCommitmentSignedResponse? TransactionAddCommitmentSignedResponse { get; set; }

            [JsonPropertyName("requestProcessingTime")]
            public int RequestProcessingTime { get; set; }
    
    }
}
