using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Signum.NET
{
    public class LongConvert : BaseRequest, ILongConvert
    {
        [JsonPropertyName("stringId")]
        public string? StringId { get; set; }

        [JsonPropertyName("longId")]
        public string? LongId { get; set; }


    }

    public interface ILongConvert : IBaseRequest
    {
        public string? StringId { get; }

        public string? LongId { get; }


    }
}
