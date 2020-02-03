using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading;
using System.Net.Http.Headers;

namespace MedApiSample
{
    class LicensureService
    {
        public LicensureService(HttpClient client, string accessToken)
        {
            _client = client;
            _accessToken = accessToken;
        }

        public async Task<LicenseSummary> GetLicenseStatusAsync(string fid, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _client.BaseAddress + $"/v2/licensure/{fid}/summary");
            AddAuthenticationToken(request);

            using (var response = await _client.SendAsync(request, cancellationToken))
            {
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<LicenseSummary>(content);
            };
        }

        private void AddAuthenticationToken(HttpRequestMessage request)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
        }

        private readonly HttpClient _client;
        private readonly string _accessToken;
    }
}
