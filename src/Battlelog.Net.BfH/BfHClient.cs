using Battlelog;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Battlelog.BfH
{
    public class BfHClient : IDisposable
    {
        HttpClient httpClient = new HttpClient();

        public BfHClient() => httpClient.BaseAddress = new Uri("https://battlelog.battlefield.com");

        /// <summary>
        /// Returns the Persona ID from the player.
        /// </summary>
        /// <param name="player">the players name</param>
        /// <returns>Returns the Persona ID from the player and null if the player wasn't found.</returns>
        public async Task<long?> GetPersonaID(string player)
        {
            // Extract the persona id */
            Match pid = Regex.Match(await httpClient.GetStringAsync("/bfh/user/" + player),
                @"bfh/agent/" + player + @"/stats/(\d+)",
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

            if (!pid.Success) return null;

            return Convert.ToInt64(pid.Groups[1].Value.Trim());
        }

        /// <summary>
        /// Returns detailed stats about a player.
        /// </summary>
        /// <returns>Returns detailed stats about a player.</returns>
        public async Task<DetailedStats> GetDetailedStatsAsync(Platform platform, long PlayerID)
        {
            return await await Task.Factory.StartNew(async () =>
                JsonConvert.DeserializeObject<Response<DetailedStats>>(
                    await GetStringAsync(Endpoints.DetailedStats,
                        PlayerID.ToString(),
                        ((int)platform).ToString()
            )).Data);
        }

        /// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources used.
        /// </summary>
        public void Dispose()
        {
            httpClient.Dispose();
        }

        private async Task<string> GetStringAsync(string endpoint, params string[] parameters)
            => await httpClient.GetStringAsync(endpoint + "/" + string.Join("/", parameters));
    }
}
