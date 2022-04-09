using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetPeers : IBaseRequest
    {
        public List<string>? Peers { get; }

    }

    #endregion

    #region Class

    public class GetPeers : BaseRequest, IGetPeers
    {       

        #region API Properties

        [JsonPropertyName("peers")]
        public List<string>? Peers { get; set; }


        #endregion


        #region IGetPeers



        #endregion

    }

    #endregion

}
