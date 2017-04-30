using Newtonsoft.Json;

namespace Battlelog.Bf4
{
    public class DetailedStats : Data
    {
        [JsonProperty("generalStats")]
        [JsonRequired]
        public GeneralStats GeneralStats { get; set; }
    }
}
