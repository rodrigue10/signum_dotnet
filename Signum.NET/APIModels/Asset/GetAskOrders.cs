using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetAskOrders : IBaseRequest
    {

        public List<IAskOrder> AskOrders{ get; }

    }

    public interface IAskOrder
    {
        public string? Order { get;  }
        public string? Asset { get; }
        public string? Account { get; }
        public string? AccountRS { get; }
        public string? QuantityQNT { get;  }
        public string? PriceNQT { get;  }   
        public int Height { get;  }
        public string? Type { get; }
    }

    #endregion

    #region Class



    public class AskOrder : IAskOrder
    {
        [JsonPropertyName("order")]
        public string? Order { get; set; }

        [JsonPropertyName("asset")]
        public string? Asset { get; set; }

        [JsonPropertyName("account")]
        public string? Account { get; set; }

        [JsonPropertyName("accountRS")]
        public string? AccountRS { get; set; }

        [JsonPropertyName("quantityQNT")]
        public string? QuantityQNT { get; set; }

        [JsonPropertyName("priceNQT")]
        public string? PriceNQT { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }


    public class GetAskOrders : BaseRequest, IGetAskOrders
    {

       
        #region API Properties       


        [JsonPropertyName("askOrders")]
        public List<AskOrder>? AskOrders { get; set; }


        #endregion

  
        #region IGetAskOrdeers
        List<IAskOrder> IGetAskOrders.AskOrders => AskOrders.ToList<IAskOrder>();         

        #endregion

    }

    #endregion

}
