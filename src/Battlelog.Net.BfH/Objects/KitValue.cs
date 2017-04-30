using Newtonsoft.Json;

namespace Battlelog.BfH
{
    public class KitValue<T>
    {
        [JsonProperty("4096")]
        [JsonRequired]
        public T Enforcer { get; set; }
        [JsonProperty("8192")]
        [JsonRequired]
        public T Mechanic { get; set; }
        [JsonProperty("32768")]
        [JsonRequired]
        public T Professional { get; set; }
        [JsonProperty("16384")]
        [JsonRequired]
        public T Operator { get; set; }
        [JsonProperty("2048")]
        [JsonRequired]
        public T Hacker { get; set; }
    }
}
