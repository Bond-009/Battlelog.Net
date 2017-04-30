using Newtonsoft.Json;
using System;

namespace Battlelog.BfH
{
    public class KitTimes : KitValue<TimeSpan>
    {
        [JsonProperty("4096")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Enforcer { get; set; }
        [JsonProperty("8192")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Mechanic { get; set; }
        [JsonProperty("32768")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Professional { get; set; }
        [JsonProperty("16384")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Operator { get; set; }
        [JsonProperty("2048")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Hacker { get; set; }
    }
}
