using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Signum.NET
{
    public class TransactionCommon 
    {
            [JsonPropertyName("referencedTransactionFullHash")]
            public string? ReferencedTransactionFullHash { get; set; }

            [JsonPropertyName("secretPhrase")]
            public string? SecretPhrase { get; set; }

            [JsonPropertyName("publicKey")]
            public string? PublicKey { get; set; }

            [JsonPropertyName("feeNQT")]
            public string? FeeNQT { get; set; }

            [JsonPropertyName("deadline")]
            public string? Deadline { get; set; }

            [JsonPropertyName("broadcast")]
            public string? Broadcast { get; set; }

            [JsonPropertyName("message")]
            public string? Message { get; set; }

            [JsonPropertyName("messageIsText")]
            public string? MessageIsText { get; set; }

            [JsonPropertyName("messageToEncrypt")]
            public string? MessageToEncrypt { get; set; }

            [JsonPropertyName("messageToEncryptIsText")]
            public string? MessageToEncryptIsText { get; set; }

            [JsonPropertyName("encryptedMessageData")]
            public string? EncryptedMessageData { get; set; }

            [JsonPropertyName("encryptedMessageNonce")]
            public string? EncryptedMessageNonce { get; set; }
            
            [JsonPropertyName("messageToEncryptToSelf")]
            public string? MessageToEncryptToSelf { get; set; }
          
            [JsonPropertyName("messageToEncryptToSelfIsText")]
            public string? MessageToEncryptToSelfIsText { get; set; }

            [JsonPropertyName("encryptToSelfMessageData")]
            public string? EncryptToSelfMessageData { get; set; }

            [JsonPropertyName("encryptToSelfMessageNonce")]
            public string? EncryptToSelfMessageNonce { get; set; }
            
            [JsonPropertyName("recipientPublicKey")]
            public string? RecipientPublicKey { get; set; }



    }
}
