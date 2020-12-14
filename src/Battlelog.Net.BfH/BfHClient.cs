using System;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Battlelog.Json;

namespace Battlelog.BfH
{
    public class BfHClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;
        private bool _disposed = false;

        public BfHClient()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://battlelog.battlefield.com")
            };

            _jsonOptions = JsonDefaults.GetOptions();
        }

        /// <summary>
        /// Returns the Persona ID from the player.
        /// </summary>
        /// <param name="playername">the players name</param>
        /// <param name="platform">the platform</param>
        /// <param name="platformName">the players platform specific name</param>
        /// <returns>Returns the Persona ID from the player and null if the player wasn't found.</returns>
        public async Task<long?> GetPersonaID(string playername, Platform platform = Platform.PC, string platformName = null)
        {
            // Extract the persona id
            Match pid = Regex.Match(await _httpClient.GetStringAsync("/bfh/user/" + playername),
                $@"/bfh/agent/{platformName ?? playername}/stats/(?<id>\d+)/{platform}/",
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

            if (pid.Success
                && long.TryParse(pid.Groups["id"].Value.AsSpan().Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out long value))
            {
                return value;
            }

            return null;
        }

        /// <summary>
        /// Returns detailed stats about a player.
        /// </summary>
        /// <returns>Returns detailed stats about a player.</returns>
        public async Task<DetailedStats> GetDetailedStatsAsync(long playerId, Platform platform = Platform.PC, CancellationToken cancellationToken = default)
        {
            using var stream = await GetStreamAsync(
                Endpoints.DetailedStats,
                cancellationToken,
                playerId.ToString(),
                ((int)platform).ToString()).ConfigureAwait(false);
            var res = await JsonSerializer.DeserializeAsync<Response<DetailedStats>>(stream, _jsonOptions, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

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
            }

            _disposed = true;
        }

        private Task<Stream> GetStreamAsync(string endpoint, CancellationToken cancellationToken, params string[] parameters)
            => _httpClient.GetStreamAsync(endpoint + "/" + string.Join('/', parameters), cancellationToken);
    }
}
