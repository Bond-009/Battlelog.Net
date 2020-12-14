using System.Text.Json.Serialization;
using System;

namespace Battlelog.Bf4
{
    public class KitTimes : KitValue<TimeSpan>
    {
        [JsonPropertyName("8")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan Recon { get; set; }
        [JsonPropertyName("1")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan Assault { get; set; }
        [JsonPropertyName("2")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan Engineer { get; set; }
        [JsonPropertyName("2048")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan Commander { get; set; }
        [JsonPropertyName("32")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan Support { get; set; }
    }
}
