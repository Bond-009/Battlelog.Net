using Newtonsoft.Json;

namespace Battlelog.Bf4
{
    public class GameModesScore
    {
        [JsonProperty("32")]
        [JsonRequired]
        public int TeamDeathmatch { get; set; }
        [JsonProperty("1")]
        [JsonRequired]
        public int Conquest { get; set; }
        [JsonProperty("2")]
        [JsonRequired]
        public int Rush { get; set; }
        // (33554432) use 134217728 for CarrierAssault
        // (68719476736) use 1 for Conquest score
        // (64) use 1 for Conquest score
        [JsonProperty("1024")]
        [JsonRequired]
        public int Domination { get; set; }
        [JsonProperty("524288")]
        [JsonRequired]
        public int CaptureTheFlag { get; set; }
        [JsonProperty("134217728")]
        [JsonRequired]
        public int CarrierAssault { get; set; }
        [JsonProperty("2097152")]
        [JsonRequired]
        public int Obliteration { get; set; }
        [JsonProperty("8")]
        [JsonRequired]
        public int SquadDeathmatch { get; set; }
        [JsonProperty("8388608")]
        [JsonRequired]
        public int AirSuperiority { get; set; }
        [JsonProperty("512")]
        [JsonRequired]
        public int GunMaster { get; set; }
        // (137438953472) use 2097152 for Obliteration
        [JsonProperty("34359738368")]
        [JsonRequired]
        public int ChainLink { get; set; }
        [JsonProperty("16777216")]
        [JsonRequired]
        public int Defuse { get; set; }
        // (67108864) use 134217728 for CarrierAssault
    }
}
