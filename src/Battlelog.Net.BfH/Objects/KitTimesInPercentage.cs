using Newtonsoft.Json;

namespace Battlelog.BfH
{
    public class KitTimesInPercentage
    {
        [JsonProperty("4096")]
        [JsonRequired]
        public double Enforcer { get; set; }
        [JsonProperty("8192")]
        [JsonRequired]
        public double Mechanic { get; set; }
        [JsonProperty("2048")]
        [JsonRequired]
        public double Hacker { get; set; }
        [JsonProperty("32768")]
        [JsonRequired]
        public double Professional { get; set; }
        [JsonProperty("16384")]
        [JsonRequired]
        public double Operator { get; set; }
    }
}
