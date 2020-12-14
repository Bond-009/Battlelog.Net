using System;
using System.IO;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Battlelog.Json;
namespace Battlelog.Bf3
{
    public class Bf3Client : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;
        private bool _disposed = false;

        public Bf3Client()
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
        /// /// <param name="platform">the platform</param>
        /// <param name="platformName">the players platform specific name</param>
        /// <returns>Returns the Persona ID from the player and null if the player wasn't found.</returns>
        public async Task<long?> GetPersonaID(string playername, Platform platform = Platform.PC, string platformName = null, CancellationToken cancellationToken = default)
        {
            string html = await _httpClient.GetStringAsync("/bf3/user/" + playername, cancellationToken).ConfigureAwait(false);

            // Extract the persona id
            Match pid = Regex.Match(
                html,
                $@"/bf3/soldier/{platformName ?? playername}/stats/(?<id>\d+)/{platform}/",
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

            if (pid.Success
                && long.TryParse(pid.Groups["id"].Value.AsSpan().Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out long value))
            {
                return value;
            }

            return null;
        }

        /// <summary>
        /// Returns stats about a player.
        /// </summary>
        /// <returns>Returns stats about a player.</returns>
        public async Task<Stats> GetStatsAsync(long playerID, Platform platform = Platform.PC, CancellationToken cancellationToken = default)
        {
            using var stream = await GetStreamAsync(
                Endpoints.Stats,
                cancellationToken,
                playerID.ToString(),
                "bf3-us-recon",
                ((int)platform).ToString()).ConfigureAwait(false);
            var res = await JsonSerializer.DeserializeAsync<Response<Stats>>(stream, _jsonOptions, cancellationToken).ConfigureAwait(false);
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
