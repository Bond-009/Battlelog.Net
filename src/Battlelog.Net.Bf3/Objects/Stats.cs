using System.Text.Json.Serialization;

namespace Battlelog.Bf3
{
    public class Stats : Data
    {
        [JsonPropertyName("overviewStats")]
        public OverviewStats OverviewStats { get; set; }
    }
}
