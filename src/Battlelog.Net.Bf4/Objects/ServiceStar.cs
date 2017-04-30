using Newtonsoft.Json;

namespace Battlelog.Bf4
{
    public class ServiceStar<T>
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
        [JsonProperty("progressCodeNeeded")]
        [JsonRequired]
        public string ProgressCodeNeeded { get; set; }
        [JsonProperty("codeNeeded")]
        [JsonRequired]
        public string CodeNeeded { get; set; }
        [JsonProperty("tier")]
        [JsonRequired]
        public string Tier { get; set; }
        [JsonProperty("valueNeeded")]
        [JsonRequired]
        public int ValueNeeded { get; set; }
        [JsonProperty("name")]
        [JsonRequired]
        public T Name { get; set; }
    }
}
