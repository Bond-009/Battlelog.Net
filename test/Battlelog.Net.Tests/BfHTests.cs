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
        BfHClient client = new BfHClient();
        
        [Theory]
        [InlineData("TheOnlyBond_009")]
        [InlineData("Banarnass")]
        public async Task TestPersonaID(string playerName)
        {
            long? personaID = await client.GetPersonaID(playerName);

            if (personaID == null) throw new Exception();
        }

        [Theory]
        [InlineData(1486274664)]
        [InlineData(1684769057)]
        public async Task TestDetailedStats(long playerID)
        {
            DetailedStats stats = await client.GetDetailedStatsAsync(Platform.PC, playerID);
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
