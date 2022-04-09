﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Signum.NET
{
    public class SetAccountInfo : TransactionCommon
    {

        [JsonPropertyName("requestType")]
        public string? RequestType { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }



    }
}
