using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetDGSGoods
    {
        public List<IGood> Goods { get; }
    }

    public interface IGood
    {
        public string Goods { get; }
        public string Name { get; }
        public string Description { get; }
        public int Quantity { get; }
        public string PriceNQT { get; }
        public string Seller { get; }
        public string SellerRS { get; }
        public string Tags { get; }
        public bool Delisted { get; }
        public int Timestamp { get; }

    }

    #endregion

    #region Class

    public class GetDGSGoods : IGetDGSGoods
    { 

        #region API Properties

        [JsonPropertyName("goods")]
        public List<Good>? Goods { get; set; }

        #endregion

        #region Request Time
        [JsonPropertyName("requestProcessingTime")]
        public int RequestProcessingTime { get; set; }
        #endregion

        #region Error Conditions
        [JsonPropertyName("errorCode")]
        public int ErrorCode { get; set; }

        [JsonPropertyName("errorDescription")]
        public string? ErrorDescription { get; set; }





        #endregion

        #region IGetDGSGoods

        List<IGood> IGetDGSGoods.Goods => new(Goods);

        #endregion

    }

    public class Good : IGood
    {
        #region IGood

        #endregion

        [JsonPropertyName("goods")]
        public string? Goods { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("priceNQT")]
        public string? PriceNQT { get; set; }

        [JsonPropertyName("seller")]
        public string? Seller { get; set; }

        [JsonPropertyName("sellerRS")]
        public string? SellerRS { get; set; }

        [JsonPropertyName("tags")]
        public string? Tags { get; set; }

        [JsonPropertyName("delisted")]
        public bool Delisted { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }
    }


    #endregion

}
