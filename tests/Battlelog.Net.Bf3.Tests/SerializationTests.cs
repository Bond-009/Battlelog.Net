using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Battlelog.Json;
using Xunit;

namespace Battlelog.Bf3.Tests
{
    public class SerializationTests
    {
        private readonly JsonSerializerOptions _jsonOptions = JsonDefaults.GetOptions();

        [Theory]
        [InlineData("TheOnlyBond.json")]
        public async ValueTask Test(string resource)
        {
            using (Stream stream = typeof(SerializationTests).Assembly
                .GetManifestResourceStream("Battlelog.Net.Bf3.Tests/TestData/" + resource))
            {
                await JsonSerializer.DeserializeAsync<Response<Stats>>(stream, _jsonOptions).ConfigureAwait(false);
            }
        }
    }
}
