using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Battlelog.Json;
using Xunit;

namespace Battlelog.BfH.Tests
{
    public class SerializationTests
    {
        private readonly JsonSerializerOptions _jsonOptions = JsonDefaults.GetOptions();

        [Theory]
        [InlineData("TheOnlyBond.json")]
        public async Task Test(string resource)
        {
            using (Stream stream = File.OpenRead("Test Data/" + resource))
            {
                var res = await JsonSerializer.DeserializeAsync<Response<DetailedStats>>(stream, _jsonOptions).ConfigureAwait(false);
                Assert.NotNull(res);
                Assert.NotNull(res.Data);
                Assert.Equal("OK", res.Message);
                Assert.Equal("success", res.Type);
            }
        }
    }
}
