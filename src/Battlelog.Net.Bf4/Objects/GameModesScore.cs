using System.Text.Json.Serialization;

namespace Battlelog.Bf4
{
    public class GameModesScore
    {
        [JsonPropertyName("32")]
        public int TeamDeathmatch { get; set; }

        [JsonPropertyName("1")]
        public int Conquest { get; set; }

        [JsonPropertyName("2")]
        public int Rush { get; set; }

        // (33554432) use 134217728 for CarrierAssault
        // (68719476736) use 1 for Conquest score
        // (64) use 1 for Conquest score
        [JsonPropertyName("1024")]
        public int Domination { get; set; }

        [JsonPropertyName("524288")]
        public int CaptureTheFlag { get; set; }

        [JsonPropertyName("134217728")]
        public int CarrierAssault { get; set; }

        [JsonPropertyName("2097152")]
        public int Obliteration { get; set; }

        [JsonPropertyName("8")]
        public int SquadDeathmatch { get; set; }

        [JsonPropertyName("8388608")]
        public int AirSuperiority { get; set; }

        [JsonPropertyName("512")]
        public int GunMaster { get; set; }

        // (137438953472) use 2097152 for Obliteration
        [JsonPropertyName("34359738368")]
        public int ChainLink { get; set; }

        [JsonPropertyName("16777216")]
        public int Defuse { get; set; }
        // (67108864) use 134217728 for CarrierAssault
    }
}
