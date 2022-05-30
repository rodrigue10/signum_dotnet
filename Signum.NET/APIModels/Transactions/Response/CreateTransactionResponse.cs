using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Signum.NET
{
    public class CreateTransactionResponse : BaseRequest, ICreateTransactionResponse
    {

        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

     
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
            public string? TransactionJSON { get; set; }


        

    }

    public interface ICreateTransactionResponse : IBaseRequest
    {
         
        public string? Transaction { get;  } 
        public string? FullHash { get;  }   
        public string? TransactionBytes { get;  }  
        public string? SignatureHash { get;  }  
        public int NumberPeersSentTo { get;  }     
        public bool Broadcasted { get;  }  
        public string? UnsignedTransactionBytes { get;  }  
        public string? TransactionJSON { get;  }

    }
}
