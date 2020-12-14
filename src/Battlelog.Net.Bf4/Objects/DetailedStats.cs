using System.Text.Json.Serialization;

namespace Battlelog.Bf4
{
    public class DetailedStats : Data
    {
        [JsonPropertyName("generalStats")]
        public GeneralStats GeneralStats { get; set; }
    }
}
