using Newtonsoft.Json;

namespace Battlelog.Bf4
{
    public class ServiceStar
    {
        [JsonProperty("serviceStars")]
        [JsonRequired]
        public int ServiceStars { get; set; }
        [JsonProperty("serviceStarsProgress")]
        [JsonRequired]
        public double ServiceStarsProgress { get; set; }
        [JsonProperty("actualValue")]
        [JsonRequired]
        public int ActualValue { get; set; }
        [JsonProperty("codeNeeded")]
        [JsonRequired]
        public string CodeNeeded { get; set; }
        [JsonProperty("valueNeeded")]
        [JsonRequired]
        public int ValueNeeded { get; set; }
    }
}
