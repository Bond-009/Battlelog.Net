using Newtonsoft.Json;
using System;

namespace Battlelog.Bf3
{
    public class KitTimes : KitValue<TimeSpan>
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
        [JsonProperty("32")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Support { get; set; }
    }
}
