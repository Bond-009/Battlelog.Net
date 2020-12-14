using System.Text.Json.Serialization;

namespace Battlelog.Bf4
{
    public class KitValue<T>
    {
        [JsonPropertyName("8")]
        public T Recon { get; set; }

        [JsonPropertyName("1")]
        public T Assault { get; set; }

        [JsonPropertyName("2")]
        public T Engineer { get; set; }

        [JsonPropertyName("2048")]
        public T Commander { get; set; }

        [JsonPropertyName("32")]
        public T Support { get; set; }
    }
}
