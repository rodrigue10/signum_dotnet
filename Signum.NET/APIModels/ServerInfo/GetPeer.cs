using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetPeer : IBaseRequest
    {

        public string? PublicIP { get; }

        #region API Properties
        public int State { get; }
        public string? AnnouncedAddress { get; }
        public bool ShareAddress { get; }
        public int DownloadedVolume { get; }
        public int UploadedVolume { get; }
        public string? Application { get; }
        public string? Version { get; }
        public string? Platform { get; }
        public bool Blacklisted { get; }
        public int LastUpdated { get; }
        
        #endregion


    }


    #endregion

    #region Class


    public class GetPeer : BaseRequest,  IGetPeer
    {

        //not in main JSON request...used to manually add IP address when creating http request since the IP is an input
        public string? PublicIP { get; set; }

        #region API Properties

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("announcedAddress")]
        public string? AnnouncedAddress { get; set; }

        [JsonPropertyName("shareAddress")]
        public bool ShareAddress { get; set; }

        [JsonPropertyName("downloadedVolume")]
        public int DownloadedVolume { get; set; }

        [JsonPropertyName("uploadedVolume")]
        public int UploadedVolume { get; set; }

        [JsonPropertyName("application")]
        public string? Application { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("platform")]
        public string? Platform { get; set; }

        [JsonPropertyName("blacklisted")]
        public bool Blacklisted { get; set; }

        [JsonPropertyName("lastUpdated")]
        public int LastUpdated { get; set; }

        #endregion

        #region IGetPeer



        #endregion

    }

    #endregion

}
