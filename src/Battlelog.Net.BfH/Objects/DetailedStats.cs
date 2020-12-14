using System.Text.Json.Serialization;

namespace Battlelog.BfH
{
    public class DetailedStats : Data
    {
        [JsonPropertyName("generalStats")]
        public GeneralStats GeneralStats { get; set; }
    }
}
