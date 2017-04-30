using Newtonsoft.Json;
using System;

namespace Battlelog.Bf4
{
    public class KitTimes
    {
        [JsonProperty("8")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Recon { get; set; }
        [JsonProperty("1")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Assault { get; set; }
        [JsonProperty("2")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Engineer { get; set; }
        [JsonProperty("2048")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Commander { get; set; }
        [JsonProperty("32")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Support { get; set; }
    }
}
