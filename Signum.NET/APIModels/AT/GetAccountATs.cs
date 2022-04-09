using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Signum.NET
{

    public class AT : IAT
    {
        [JsonPropertyName("creator")]
        public string? Creator { get; set; }

        [JsonPropertyName("creatorRS")]
        public string? CreatorRS { get; set; }

        [JsonPropertyName("at")]
        public string? At { get; set; }

        [JsonPropertyName("atRS")]
        public string? AtRS { get; set; }

        [JsonPropertyName("atVersion")]
        public int AtVersion { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("machineCode")]
        public string? MachineCode { get; set; }

        [JsonPropertyName("machineData")]
        public string? MachineData { get; set; }

        [JsonPropertyName("balanceNQT")]
        public string? BalanceNQT { get; set; }

        [JsonPropertyName("prevBalanceNQT")]
        public string? PrevBalanceNQT { get; set; }

        [JsonPropertyName("nextBlock")]
        public int NextBlock { get; set; }

        [JsonPropertyName("frozen")]
        public bool Frozen { get; set; }

        [JsonPropertyName("running")]
        public bool Running { get; set; }

        [JsonPropertyName("stopped")]
        public bool Stopped { get; set; }

        [JsonPropertyName("finished")]
        public bool Finished { get; set; }

        [JsonPropertyName("dead")]
        public bool Dead { get; set; }

        [JsonPropertyName("minActivation")]
        public string? MinActivation { get; set; }

        [JsonPropertyName("creationBlock")]
        public int CreationBlock { get; set; }
    }

    public interface IAT
    {
        public string? Creator { get; }
        public string? CreatorRS { get; }
        public string? At { get; }
        public string? AtRS { get; }
        public int AtVersion { get; }
        public string? Name { get; }
        public string? Description { get; }
        public string? MachineCode { get; }
        public string? MachineData { get; }
        public string? BalanceNQT { get; }
        public string? PrevBalanceNQT { get; }
        public int NextBlock { get; }
        public bool Frozen { get; }
        public bool Running { get; }
        public bool Stopped { get; }
        public bool Finished { get; }
        public bool Dead { get; }
        public string? MinActivation { get; }
        public int CreationBlock { get; }

    }



    public class GetAccountATs : BaseRequest,  IGetAccountATs
    {
        [JsonPropertyName("ats")]
        public List<AT>? ATs { get; set; }


        List<IAT> IGetAccountATs.ATs => new(ATs);
    }

    public interface IGetAccountATs : IBaseRequest
    {
        public List<IAT> ATs { get; }
    }
}
