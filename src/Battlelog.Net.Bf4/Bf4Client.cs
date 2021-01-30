using System;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Battlelog.Json;

namespace Battlelog.Bf4
{
    public class Bf4Client : IDisposable
    {
        private HttpClient _httpClient = new HttpClient();
        private readonly JsonSerializerOptions _jsonOptions;
        private bool _disposed = false;

        public Bf4Client()
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
        /// <param name="playername">The players name.</param>
        /// <param name="platform">The platform.</param>
        /// <param name="platformName">The players platform specific name.</param>
        /// <returns>Returns the Persona ID from the player and null if the player wasn't found.</returns>
        public async Task<long?> GetPersonaID(string playername, Platform platform = Platform.PC, string platformName = null, CancellationToken cancellationToken = default)
        {
            string html = await _httpClient.GetStringAsync("/bf4/user/" + playername, cancellationToken).ConfigureAwait(false);

            // Extract the persona id
            Match pid = Regex.Match(
                html,
                $@"/bf4/soldier/{platformName ?? playername}/stats/(?<id>\d+)/{platform}/",
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

            if (pid.Success
                && long.TryParse(pid.Groups["id"].Value.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out long value))
            {
                return value;
            }

            return null;
        }

        /// <summary>
        /// Returns detailed stats about a player.
        /// </summary>
        /// <returns>Returns detailed stats about a player.</returns>
        public async Task<DetailedStats> GetStatsAsync(long PlayerID, Platform platform = Platform.PC, CancellationToken cancellationToken = default)
        {
            using var stream = await GetStreamAsync(
                Endpoints.DetailedStats,
                cancellationToken,
                PlayerID.ToString(),
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
                _httpClient = null;
            }

            _disposed = true;
        }

        private Task<Stream> GetStreamAsync(string endpoint, CancellationToken cancellationToken, params string[] parameters)
            => _httpClient.GetStreamAsync(endpoint + "/" + string.Join('/', parameters), cancellationToken);
    }
}
