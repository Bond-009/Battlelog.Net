using System.Text.Json.Serialization;

namespace Battlelog.BfH
{
    public class ServiceStar<T>
    {
        [JsonPropertyName("serviceStars")]
        public int ServiceStars { get; set; }
        [JsonPropertyName("serviceStarsProgress")]
        public double ServiceStarsProgress { get; set; }
        [JsonPropertyName("actualValue")]
        public int ActualValue { get; set; }
        [JsonPropertyName("progressCodeNeeded")]
        public string ProgressCodeNeeded { get; set; }
        [JsonPropertyName("codeNeeded")]
        public string CodeNeeded { get; set; }
        [JsonPropertyName("tier")]
        public string Tier { get; set; }
        [JsonPropertyName("valueNeeded")]
        public int ValueNeeded { get; set; }
        [JsonPropertyName("name")]
        public T Name { get; set; }
    }
}
