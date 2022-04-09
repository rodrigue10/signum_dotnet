using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    #region Interface
    public interface IGetTime : IBaseRequest
    {
        public int Time { get; }  

    }


    #endregion

    #region Class



    public class GetTime : BaseRequest, IGetTime
    {


        #region API Properties

        [JsonPropertyName("time")]
        public int Time { get; set; }


        #endregion



        #region IGetTime



        #endregion

    }

    #endregion

}
