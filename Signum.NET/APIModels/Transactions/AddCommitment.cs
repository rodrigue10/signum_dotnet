using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Signum.NET
{
    public class AddCommitment : TransactionCommon
    {
        [JsonPropertyName("requestType")]
        public string? RequestType { get; set; }

        [JsonPropertyName("amountNQT")]
        public string? AmountNQT { get; set; }



    }
}
