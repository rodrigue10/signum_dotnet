using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Signum.NET
{
    public class RSConvert : BaseRequest, IRSConvert
    {
        [JsonPropertyName("account")]
        public string? Account { get; set; }

        [JsonPropertyName("accountRS")]
        public string? AccountRS { get; set; }


    }


    //Readonly Fields
    public interface IRSConvert : IBaseRequest
    {
        public string? Account { get; }
        public string? AccountRS { get; }

    }
}
