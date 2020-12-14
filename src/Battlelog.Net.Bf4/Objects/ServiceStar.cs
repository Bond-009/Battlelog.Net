using System.Text.Json.Serialization;

namespace Battlelog.Bf4
{
    public class ServiceStar
    {
        [JsonPropertyName("serviceStars")]
        public int ServiceStars { get; set; }

        [JsonPropertyName("serviceStarsProgress")]
        public double ServiceStarsProgress { get; set; }

        [JsonPropertyName("actualValue")]
        public int ActualValue { get; set; }

        [JsonPropertyName("codeNeeded")]
        public string CodeNeeded { get; set; }

        [JsonPropertyName("valueNeeded")]
        public int ValueNeeded { get; set; }
    }
}
