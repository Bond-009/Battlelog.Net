using System.Text.Json.Serialization;

namespace Battlelog
{
    public class Data
    {
        [JsonPropertyName("personaId")]
        public long PersonaID { get; set; }

        [JsonPropertyName("platformInt")]
        public int PlatformInt { get; set; }

        [JsonPropertyName("statsTemplate")]
        public string StatsTemplate { get; set; }
    }
}
