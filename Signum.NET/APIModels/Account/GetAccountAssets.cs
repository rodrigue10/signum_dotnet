using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    public interface IGetAccountAssets : IBaseRequest
    {

        public List<IAssetBalanceGAA> AssetBalancesGAA { get;  }

        public List<IUnconfirmedAssetBalanceGAA> UnconfirmedAssetBalancesGAA { get;  }


    }

    public interface IAssetBalanceGAA
    {
        public string Asset { get; }
        public string BalanceQNT { get; }

    }

    public interface IUnconfirmedAssetBalanceGAA
    {
        public string Asset { get; }
        public string UnconfirmedBalanceQNT { get; }

    }

    public class AssetBalanceGAA : IAssetBalanceGAA
    {
        [JsonPropertyName("asset")]
        public string? Asset { get; set; }

        [JsonPropertyName("balanceQNT")]
        public string? BalanceQNT { get; set; }
    }

    public class UnconfirmedAssetBalanceGAA : IUnconfirmedAssetBalanceGAA
    {
        [JsonPropertyName("asset")]
        public string? Asset { get; set; }

        [JsonPropertyName("unconfirmedBalanceQNT")]
        public string? UnconfirmedBalanceQNT { get; set; }
    }


    public class GetAccountAssets : BaseRequest, IGetAccountAssets
    {



        #region API Properties   


            [JsonPropertyName("assetBalances")]
            public List<AssetBalanceGAA>? AssetBalancesGAA { get; set; }

            [JsonPropertyName("unconfirmedAssetBalances")]
            public List<UnconfirmedAssetBalanceGAA>? UnconfirmedAssetBalancesGAA { get; set; }


        


        #endregion



        #region IGetAccountAssets

        List<IAssetBalanceGAA> IGetAccountAssets.AssetBalancesGAA =>
                  AssetBalancesGAA.ToList<IAssetBalanceGAA>();

        List<IUnconfirmedAssetBalanceGAA> IGetAccountAssets.UnconfirmedAssetBalancesGAA => 
                  UnconfirmedAssetBalancesGAA.ToList<IUnconfirmedAssetBalanceGAA>();
        #endregion


    }




}
