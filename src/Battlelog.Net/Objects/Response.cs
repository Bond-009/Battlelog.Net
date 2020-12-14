using System.Text.Json.Serialization;

namespace Battlelog
{
    public class Response<T> where T: Data
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }
    }
}
