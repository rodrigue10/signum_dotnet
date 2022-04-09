using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetAllAssets : IBaseRequest
    {

        public List<IAssetGAA> AssetsGAA{ get; }


    }

    public interface IAssetGAA
    {
        public string Account { get;  }
        public string AccountRS { get;  }
        public string Name { get;  }
        public string Description { get;  }
        public int Decimals { get;  }
        public string QuantityQNT { get;  }
        public string Asset { get; }
        public int NumberOfTrades { get;  }
        public int NumberOfTransfers { get;  }  
        public int NumberOfAccounts { get; }
    }

    #endregion

    #region Class

    
    public class AssetGAA : IAssetGAA
    {
        [JsonPropertyName("account")]
        public string? Account { get; set; }

        [JsonPropertyName("accountRS")]
        public string? AccountRS { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("decimals")]
        public int Decimals { get; set; }

        [JsonPropertyName("quantityQNT")]
        public string? QuantityQNT { get; set; }

        [JsonPropertyName("asset")]
        public string? Asset { get; set; }

        [JsonPropertyName("numberOfTrades")]
        public int NumberOfTrades { get; set; }

        [JsonPropertyName("numberOfTransfers")]
        public int NumberOfTransfers { get; set; }

        [JsonPropertyName("numberOfAccounts")]
        public int NumberOfAccounts { get; set; }
    }


    public class GetAllAssets : BaseRequest, IGetAllAssets
    {


        #region API Properties       



        [JsonPropertyName("assets")]
        public List<AssetGAA>? AssetsGAA { get; set; }


        #endregion

        #region IGetAllAssets
        List<IAssetGAA> IGetAllAssets.AssetsGAA => AssetsGAA.ToList<IAssetGAA>();
         

        #endregion

    }

    #endregion

}
