using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetAccountPublicKey : IBaseRequest
    {

        public string? PublicKey { get; }

    }

    #endregion

    #region Class

    public class GetAccountPublicKey : BaseRequest, IGetAccountPublicKey
    { 

            [JsonPropertyName("publicKey")]
            public string? PublicKey { get; set; }


    }

    #endregion

}
