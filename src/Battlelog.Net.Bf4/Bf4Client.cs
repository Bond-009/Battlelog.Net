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
        private HttpClient _httpClient = new HttpClient();
        private bool _disposed = false;

        public Bf4Client()
            => _httpClient.BaseAddress = new Uri("https://battlelog.battlefield.com");

        /// <summary>
        /// Returns the Persona ID from the player.
        /// </summary>
        /// <param name="playername">the players name</param>
        /// /// <param name="platform">the platform</param>
        /// <param name="platformName">the players platform specific name</param>
        /// <returns>Returns the Persona ID from the player and null if the player wasn't found.</returns>
        public async Task<long?> GetPersonaID(string playername, Platform platform = Platform.PC, string platformName = null)
        {
            // Extract the persona id
            Match pid = Regex.Match(await _httpClient.GetStringAsync("/bf4/user/" + playername),
                $@"/bf4/soldier/{platformName ?? playername}/stats/(?<id>\d+)/{platform}/",
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

            if (!pid.Success) return null;

            return long.Parse(pid.Groups["id"].Value.Trim());
        }

        /// <summary>
        /// Returns detailed stats about a player.
        /// </summary>
        /// <returns>Returns detailed stats about a player.</returns>
        public async Task<DetailedStats> GetDetailedStatsAsync(long PlayerID, Platform platform = Platform.PC)
            => JsonConvert.DeserializeObject<Response<DetailedStats>>(
                    await GetStringAsync(Endpoints.DetailedStats,
                        PlayerID.ToString(),
                        ((int)platform).ToString()
                )).Data;

        /// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources used.
        /// </summary>
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
                _httpClient.Dispose();
                _httpClient = null;
            }

            _disposed = true;
        }

        private Task<string> GetStringAsync(string endpoint, params string[] parameters)
            => _httpClient.GetStringAsync(endpoint + "/" + string.Join("/", parameters));
    }
}
