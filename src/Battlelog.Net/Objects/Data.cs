using Newtonsoft.Json;

namespace Battlelog
{
    public class Data
    {
        [JsonProperty("personaId")]
        [JsonRequired]
        public long PersonaID { get; set; }
        [JsonProperty("platformInt")]
        [JsonRequired]
        public int PlatformInt { get; set; }
        [JsonProperty("statsTemplate")]
        [JsonRequired]
        public string StatsTemplate { get; set; }
    }
}
