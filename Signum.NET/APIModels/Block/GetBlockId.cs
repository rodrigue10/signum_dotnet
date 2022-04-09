using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetBlockId : IBaseRequest
    {
        public string? Block { get; }

    }

    #endregion

    #region Class

    public class GetBlockId : BaseRequest, IGetBlockId
    {
 

        #region API Properties
        [JsonPropertyName("block")]
        public string? Block { get; set; }

        #endregion


    }

    #endregion

}
