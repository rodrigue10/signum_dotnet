using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetUnconfirmedTransactions : IBaseRequest
    {
        public List<IUnconfirmedTransaction> UnconfirmedTransactions { get; }

    }

    public interface IAttachment
    {
        public int VersionAssetTransfer { get;  }
        public string? Asset { get;  }
        public int VersionMessage { get;  }
        public string? Message { get;  }
        public bool MessageIsText { get;  }
        public string? QuantityQNT { get;  }

    }

    public interface IUnconfirmedTransaction
    {
        public int Type { get;  }
        public int Subtype { get;  }
        public int Timestamp { get;  }     
        public int Deadline { get;}
        public string? SenderPublicKey { get; }
        public string? Recipient { get;  }
        public string? RecipientRS { get;  }
        public string? AmountNQT { get;  }
        public string? FeeNQT { get; }
        public string? Signature { get; }
        public string? SignatureHash { get; }
        public string? FullHash { get; }
        public string? Transaction { get; }
        public IAttachment Attachment { get;  }
        public string? Sender { get; } 
        public string? SenderRS { get; }
        public int Height { get;  }
        public int Version { get; }
        public string? EcBlockId { get;  }
        public int EcBlockHeight { get; }

    }





    #endregion

    #region Class
    public class Attachment : IAttachment
    {
        [JsonPropertyName("version.AssetTransfer")]
        public int VersionAssetTransfer { get; set; }

        [JsonPropertyName("asset")]
        public string? Asset { get; set; }

        [JsonPropertyName("version.Message")]
        public int VersionMessage { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("messageIsText")]
        public bool MessageIsText { get; set; }

        [JsonPropertyName("quantityQNT")]
        public string? QuantityQNT { get; set; }
    }

    public class UnconfirmedTransaction : IUnconfirmedTransaction
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
        public string? Transaction { get; set; }

        [JsonPropertyName("attachment")]
        public Attachment? Attachment { get; set; }

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

        IAttachment IUnconfirmedTransaction.Attachment => Attachment;
    }



    public class GetUnconfirmedTransactions : BaseRequest, IGetUnconfirmedTransactions
    {
            

          #region API Properties         

  
            [JsonPropertyName("unconfirmedTransactions")]
            public List<UnconfirmedTransaction>? UnconfirmedTransactions { get; set; }


            #endregion



        #region IGetUnConfirmedTransactions

        List<IUnconfirmedTransaction> IGetUnconfirmedTransactions.UnconfirmedTransactions =>
        UnconfirmedTransactions.ToList<IUnconfirmedTransaction>();
        #endregion

    }

    #endregion

}
