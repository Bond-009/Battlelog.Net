using System.Text.Json;

namespace Battlelog.Json
{
    public static class JsonDefaults
    {
        public static JsonSerializerOptions GetOptions()
        {
            var options = new JsonSerializerOptions
            {
                //NumberHandling = JsonNumberHandling.AllowReadingFromString
            };

            options.Converters.Add(new UnixDateTimeOffsetConverter());
            options.Converters.Add(new UnixTimeSpanConverter());

            return options;
        }
    }
}
