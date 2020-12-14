using System.Text.Json.Serialization;
using System;

namespace Battlelog.BfH
{
    public class KitTimes : KitValue<TimeSpan>
    {
        [JsonPropertyName("4096")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan Enforcer { get; set; }
        [JsonPropertyName("8192")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan Mechanic { get; set; }
        [JsonPropertyName("32768")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan Professional { get; set; }
        [JsonPropertyName("16384")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan Operator { get; set; }
        [JsonPropertyName("2048")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan Hacker { get; set; }
    }
}
