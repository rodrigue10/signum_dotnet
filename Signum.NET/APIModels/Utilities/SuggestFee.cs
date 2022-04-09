using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{
    public class SuggestFee : BaseRequest, ISuggestFee
    {


        [JsonPropertyName("cheap")]
        public int Cheap { get; set; }

        [JsonPropertyName("standard")]
        public int Standard { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; } 



    }

    public interface ISuggestFee : IBaseRequest
    {
        public int Cheap { get; }
        public int Standard { get; }
        public int Priority { get; }


    }
}
