using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Signum.NET
{

    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class AttachmentSetAccountInfoUnsignedResponse
    {
        [JsonPropertyName("version.AccountInfo")]
        public int VersionAccountInfo { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    public class TransactionSetAccountInfoUnsignedResponse
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

        [JsonPropertyName("attachment")]
        public AttachmentSetAccountInfoUnsignedResponse? AttachmentSetAccountInfoUnsignedResponse { get; set; }

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

    class SetAccountInfoUnsignedResponse
    {
              


            [JsonPropertyName("broadcasted")]
            public bool Broadcasted { get; set; }

            [JsonPropertyName("unsignedTransactionBytes")]
            public string? UnsignedTransactionBytes { get; set; }

            [JsonPropertyName("transactionJSON")]
            public TransactionSetAccountInfoUnsignedResponse? TransactionSetAccountInfoUnsignedResponse { get; set; }

            [JsonPropertyName("requestProcessingTime")]
            public int RequestProcessingTime { get; set; }
        
    }
}
