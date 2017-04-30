using Newtonsoft.Json;

namespace Battlelog.Bf4
{
    public class ServiceStars
    {
        [JsonProperty("8")]
        [JsonRequired]
        public int Recon { get; set; }
        [JsonProperty("1")]
        [JsonRequired]
        public int Assault { get; set; }
        [JsonProperty("2")]
        [JsonRequired]
        public int Engineer { get; set; }
        [JsonProperty("2048")]
        [JsonRequired]
        public int Commander { get; set; }
        [JsonProperty("32")]
        [JsonRequired]
        public int Support { get; set; }
    }
}
