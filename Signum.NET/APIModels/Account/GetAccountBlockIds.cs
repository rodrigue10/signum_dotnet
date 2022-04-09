using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    public interface IGetAccountBlockIds : IBaseRequest
    {
        public List<string> BlockIds { get; }

    }
    public class GetAccountBlockIds : BaseRequest, IGetAccountBlockIds
    {

        //Not Implemented


        #region API Properties

        [JsonPropertyName("blockIds")]
        public List<string>? BlockIds { get; set; }

        #endregion



        #region IGetAccountBlockIds

        List<string> IGetAccountBlockIds.BlockIds => BlockIds;


        #endregion





    }
}
