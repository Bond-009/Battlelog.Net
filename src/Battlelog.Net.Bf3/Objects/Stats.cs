using Newtonsoft.Json;

namespace Battlelog.Bf3
{
    public class Stats : Data
    {
        [JsonProperty("overviewStats")]
        [JsonRequired]
        public OverviewStats OverviewStats { get; set; }
    }
}
