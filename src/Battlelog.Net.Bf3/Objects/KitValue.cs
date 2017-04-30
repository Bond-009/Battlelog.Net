using Newtonsoft.Json;

namespace Battlelog.Bf3
{
    public class KitValue<T>
    {
        [JsonProperty("8")]
        [JsonRequired]
        public T Recon { get; set; }
        [JsonProperty("1")]
        [JsonRequired]
        public T Assault { get; set; }
        [JsonProperty("2")]
        [JsonRequired]
        public T Engineer { get; set; }
        [JsonProperty("32")]
        [JsonRequired]
        public T Support { get; set; }
    }
}
