using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MedApiSample
{
    class AuthenticationService
    {
        public AuthenticationService(HttpClient client)
        {
            _client = client;
        }

        public async Task<AccessToken> GetAccessTokenAsync(string clientId, string clientSecret, CancellationToken cancellationToken)
        {
            var data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("client_id", clientId));
            data.Add(new KeyValuePair<string, string>("client_secret", clientSecret));
            data.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            data.Add(new KeyValuePair<string, string>("scope", "med.read")); //replace with your scopes

            var reqContent = new FormUrlEncodedContent(data);

            using (var response = await _client.PostAsync(_client.BaseAddress + "/connect/token", reqContent))
            {
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<AccessToken>(content);
            };
        }

        private readonly HttpClient _client;
    }
}
