using Battlelog;
using Battlelog.BfH;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Battlelog.Tests
{
    public class BfHTests : IDisposable
    {
        private BfHClient _client = new BfHClient();
        private bool _disposed = false;

        [Theory]
        [InlineData("TheOnlyBond_009")]
        [InlineData("Banarnass")]
        [InlineData("ZEON-MS-06", Platform.PS4, "PLA-KD15")]
        public async Task TestPersonaID(string playerName, Platform platform = Platform.PC, string platformName = null)
        {
            long? personaID = await _client.GetPersonaID(playerName, platform, platformName);

            if (personaID == null) throw new Exception();
        }

        [Theory]
        [InlineData(1486274664)]
        [InlineData(1684769057)]
        public async Task TestDetailedStats(long playerID, Platform platform = Platform.PC)
        {
            DetailedStats stats = await _client.GetDetailedStatsAsync(playerID, platform);
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(_disposed) return;

            if (disposing)
            {
                _client.Dispose();
                _client = null;
            }

            _disposed = true;
        }
    }
}
