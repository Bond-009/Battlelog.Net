using Newtonsoft.Json;

namespace Battlelog.BfH
{
    public class KitScores
    {
        [JsonProperty("4096")]
        [JsonRequired]
        public int Enforcer { get; set; }
        [JsonProperty("8192")]
        [JsonRequired]
        public int Mechanic { get; set; }
        [JsonProperty("32768")]
        [JsonRequired]
        public int Professional { get; set; }
        [JsonProperty("16384")]
        [JsonRequired]
        public int Operator { get; set; }
        [JsonProperty("2048")]
        [JsonRequired]
        public int Hacker { get; set; }
    }
}
