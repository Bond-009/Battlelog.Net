using System.Text.Json;
using System.Text.Json.Serialization;

namespace Battlelog.Json
{
    public static class JsonDefaults
    {
        public static JsonSerializerOptions GetOptions()
        {
            var options = new JsonSerializerOptions
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            };

            options.Converters.Add(new UnixDateTimeOffsetConverter());
            options.Converters.Add(new UnixTimeSpanConverter());
            options.Converters.Add(new DecimalInt32Converter());

            return options;
        }
    }
}
