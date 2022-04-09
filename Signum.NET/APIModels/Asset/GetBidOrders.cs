using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetBidOrders : IBaseRequest
    {

        public List<IBidOrder> BidOrders { get; }

    }

    public interface IBidOrder
    {
        public string Order { get; }
        public string Asset { get; }
        public string Account { get; }
        public string AccountRS { get; }
        public string QuantityQNT { get; }
        public string PriceNQT { get; }
        public int Height { get; }
        public string Type { get; }
    }

    #endregion

    #region Class



    public class BidOrder : IBidOrder
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


    public class GetBidOrders : BaseRequest, IGetBidOrders
    {


        #region API Properties       


        [JsonPropertyName("bidOrders")]
        public List<BidOrder>? BidOrders { get; set; }


        #endregion



        #region IGetAskOrdeers
        List<IBidOrder> IGetBidOrders.BidOrders => BidOrders.ToList<IBidOrder>();

        #endregion

    }

    #endregion

}
