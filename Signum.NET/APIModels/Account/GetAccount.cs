using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    public interface IGetAccount : IBaseRequest
    {

        public string BalanceNQT { get; }
        public string UnconfirmedBalanceNQT { get; }
        public string ForgedBalanceNQT { get; }
        public string GuaranteedBalanceNQT { get; }
        public string CommittedBalanceNQT { get; set; }
        public string CommitmentNQT { get; set; }
        public string Account { get; }
        public string AccountRS { get; }
        public string AccountRSExtended { get; }
        public string PublicKey { get; }
        public string Name { get; }
        public List<IAssetBalanceGA> AssetBalancesGA { get; }
        public List<IUnconfirmedAssetBalanceGA> UnconfirmedAssetBalancesGA { get; }

    }

    public interface IAssetBalanceGA
    {
        public string Asset { get; }
        public string BalanceQNT { get; }

    }

    public interface IUnconfirmedAssetBalanceGA
    {
        public string Asset { get; }
        public string UnconfirmedBalanceQNT { get; }

    }


    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class AssetBalanceGA : IAssetBalanceGA
    {
        [JsonPropertyName("asset")]
        public string? Asset { get; set; }

        [JsonPropertyName("balanceQNT")]
        public string? BalanceQNT { get; set; }
    }

    public class UnconfirmedAssetBalanceGA : IUnconfirmedAssetBalanceGA
    {
        [JsonPropertyName("asset")]
        public string? Asset { get; set; }

        [JsonPropertyName("unconfirmedBalanceQNT")]
        public string? UnconfirmedBalanceQNT { get; set; }
    }

    public class GetAccount : BaseRequest, IGetAccount
    {

        #region API Properties

        [JsonPropertyName("balanceNQT")]
        public string? BalanceNQT { get; set; }

        [JsonPropertyName("unconfirmedBalanceNQT")]
        public string? UnconfirmedBalanceNQT { get; set; }

        [JsonPropertyName("forgedBalanceNQT")]
        public string? ForgedBalanceNQT { get; set; }

        [JsonPropertyName("guaranteedBalanceNQT")]
        public string? GuaranteedBalanceNQT { get; set; }

        [JsonPropertyName("committedBalanceNQT")]
        public string? CommittedBalanceNQT { get; set; }

        [JsonPropertyName("commitmentNQT")]
        public string? CommitmentNQT { get; set; }

        [JsonPropertyName("account")]
        public string? Account { get; set; }

        [JsonPropertyName("accountRS")]
        public string? AccountRS { get; set; }

        [JsonPropertyName("accountRSExtended")]
        public string? AccountRSExtended { get; set; }

        [JsonPropertyName("publicKey")]
        public string? PublicKey { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("assetBalances")]
        public List<AssetBalanceGA>? AssetBalancesGA { get; set; }

        [JsonPropertyName("unconfirmedAssetBalances")]
        public List<UnconfirmedAssetBalanceGA>? UnconfirmedAssetBalancesGA { get; set; }


        #endregion


        #region IGetAccount

        List<IAssetBalanceGA> IGetAccount.AssetBalancesGA => 
               AssetBalancesGA.ToList<IAssetBalanceGA>();

        List<IUnconfirmedAssetBalanceGA> IGetAccount.UnconfirmedAssetBalancesGA =>
            UnconfirmedAssetBalancesGA.ToList<IUnconfirmedAssetBalanceGA>();
        #endregion


    }




}
