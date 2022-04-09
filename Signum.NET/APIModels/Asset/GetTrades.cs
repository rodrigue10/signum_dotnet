using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetTrades : IBaseRequest
    {

        public List<ITrade> Trades{ get; }

    }

    public interface ITrade
    {

        public int Timestamp { get;  }
        public string QuantityQNT { get; }
        public string PriceNQT { get;  }
        public string Asset { get;  }
        public string AskOrder { get;  }  
        public string BidOrder { get;  }   
        public int AskOrderHeight { get;  }
        public string Seller { get;  }
        public string SellerRS { get;  }
        public string Buyer { get;  }
        public string BuyerRS { get;  }
        public string Block { get; }
        public int Height { get;  } 
        public string TradeType { get; }
        public string Name { get;  }
        public int Decimals { get;  }
    }

    #endregion

    #region Class




    public class Trade : ITrade
    {
        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }

        [JsonPropertyName("quantityQNT")]
        public string? QuantityQNT { get; set; }

        [JsonPropertyName("priceNQT")]
        public string? PriceNQT { get; set; }

        [JsonPropertyName("asset")]
        public string? Asset { get; set; }

        [JsonPropertyName("askOrder")]
        public string? AskOrder { get; set; }

        [JsonPropertyName("bidOrder")]
        public string? BidOrder { get; set; }

        [JsonPropertyName("askOrderHeight")]
        public int AskOrderHeight { get; set; }

        [JsonPropertyName("seller")]
        public string? Seller { get; set; }

        [JsonPropertyName("sellerRS")]
        public string? SellerRS { get; set; }

        [JsonPropertyName("buyer")]
        public string? Buyer { get; set; }

        [JsonPropertyName("buyerRS")]
        public string? BuyerRS { get; set; }

        [JsonPropertyName("block")]
        public string? Block { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("tradeType")]
        public string? TradeType { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("decimals")]
        public int Decimals { get; set; }
    }


    public class GetTrades : BaseRequest,  IGetTrades
    {


        #region API Properties             


            [JsonPropertyName("trades")]
            public List<Trade>? Trades { get; set; }


        #endregion

    

        #region IGetTrades
        List<ITrade> IGetTrades.Trades => Trades.ToList<ITrade>();         

        #endregion

    }

    #endregion

}
