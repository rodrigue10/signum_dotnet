using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetAliases : IBaseRequest
    {

        public List<IGetAlias> Aliases { get; }


    }
    #endregion

    #region Class

    public class GetAliases : BaseRequest, IGetAliases
    {
  
        #region API Properties       


        [JsonPropertyName("aliases")]
        public List<GetAlias>? Aliases { get; set; }


        #endregion


        #region IGetAliases

        List<IGetAlias> IGetAliases.Aliases => Aliases.ToList<IGetAlias>();

        #endregion

    }
    
    #endregion

}
