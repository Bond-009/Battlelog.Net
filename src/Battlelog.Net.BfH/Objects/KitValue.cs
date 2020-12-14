using System.Text.Json.Serialization;

namespace Battlelog.BfH
{
    public class KitValue<T>
    {
        [JsonPropertyName("4096")]
        public T Enforcer { get; set; }

        [JsonPropertyName("8192")]
        public T Mechanic { get; set; }

        [JsonPropertyName("32768")]
        public T Professional { get; set; }

        [JsonPropertyName("16384")]
        public T Operator { get; set; }

        [JsonPropertyName("2048")]
        public T Hacker { get; set; }
    }
}
