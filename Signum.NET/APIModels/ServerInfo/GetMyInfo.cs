using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetMyInfo : IBaseRequest
    {
        public string? Host { get; }
        public string? Address { get; }
        public string? UUID { get; }


    }


    #endregion

    #region Class


    public class GetMyInfo : BaseRequest, IGetMyInfo
    {      

        #region API Properties

        [JsonPropertyName("host")]
        public string? Host { get; set; }

        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonPropertyName("UUID")]
        public string? UUID { get; set; }


        #endregion



        #region IGetMyInfo

        string? IGetMyInfo.Host => Host;

        string? IGetMyInfo.Address => Address;

        string? IGetMyInfo.UUID => UUID;

        #endregion

    }

    #endregion

}
