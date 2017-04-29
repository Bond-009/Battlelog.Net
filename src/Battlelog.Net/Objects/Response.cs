using Newtonsoft.Json;

namespace Battlelog
{
    public class Response<T> where T: Data
    {
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; }
        [JsonProperty("message")]
        [JsonRequired]
        public string Message { get; set; }
        [JsonProperty("data")]
        [JsonRequired]
        public T Data { get; set; }
    }
}
