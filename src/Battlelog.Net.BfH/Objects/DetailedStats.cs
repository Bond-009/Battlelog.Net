using Newtonsoft.Json;

namespace Battlelog.BfH
{
    public class DetailedStats : Data
    {
        [JsonProperty("generalStats")]
        [JsonRequired]
        public GeneralStats GeneralStats { get; set; }
    }
}
