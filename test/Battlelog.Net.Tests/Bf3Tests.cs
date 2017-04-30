using Battlelog;
using Battlelog.Bf3;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Battlelog.Tests
{
    public class Bf3Tests : IDisposable
    {
        Bf3Client client = new Bf3Client();
        
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
            Stats stats = await client.GetStatsAsync(Platform.PC, playerID);
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
