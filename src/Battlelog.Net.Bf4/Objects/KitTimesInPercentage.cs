using Newtonsoft.Json;

namespace Battlelog.Bf4
{
    public class KitTimesInPercentage
    {
        [JsonProperty("8")]
        [JsonRequired]
        public double Recon { get; set; }
        [JsonProperty("1")]
        [JsonRequired]
        public double Assault { get; set; }
        [JsonProperty("2")]
        [JsonRequired]
        public double Engineer { get; set; }
        [JsonProperty("2048")]
        [JsonRequired]
        public double Commander { get; set; }
        [JsonProperty("32")]
        [JsonRequired]
        public double Support { get; set; }
    }
}
