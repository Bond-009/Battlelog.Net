using Battlelog;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Battlelog.Bf4
{
    public class Bf4Client : IDisposable
    {
        HttpClient httpClient = new HttpClient();

        public Bf4Client() => httpClient.BaseAddress = new Uri("https://battlelog.battlefield.com");

        /// <summary>
        /// Returns the Persona ID from the player.
        /// </summary>
        /// <param name="playername">the players name</param>
        /// <returns>Returns the Persona ID from the player and null if the player wasn't found.</returns>
        public async Task<long?> GetPersonaID(string playername)
        {
            // Extract the persona id
            Match pid = Regex.Match(await httpClient.GetStringAsync("/bfh/user/" + playername),
                $@"bfh/agent/{playername}/stats/(?<id>\d+)",
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

            if (!pid.Success) return null;

            return long.Parse(pid.Groups["id"].Value.Trim());
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
