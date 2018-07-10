using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading;
using System.Net.Http.Headers;

namespace MedApiSample
{
    class PractitionerService
    {
        public PractitionerService(HttpClient client, string accessToken)
        {
            _client = client;
            _accessToken = accessToken;
        }

        public async Task<MedicalProfessionalIdentity> FindPractitionerSSNAsync(string name, string date, string ssn, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _client.BaseAddress + $"/v1/practitioners/search?name={name}&birthDate={date}&ssnlast4={ssn}");
            AddAuthenticationToken(request);

            using (var response = await _client.SendAsync(request, cancellationToken))
            {
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MedicalProfessionalIdentity>(content);
            };
        }

        public async Task<MedicalProfessionalIdentity> FindPractitionerLicenseAsync(string name, string date, string license, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _client.BaseAddress + $"/v1/practitioners/search?name={name}&birthDate={date}&licenseNumber={license}");
            AddAuthenticationToken(request);

            using (var response = await _client.SendAsync(request, cancellationToken))
            {
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MedicalProfessionalIdentity>(content);
            };
        }

        public async Task<Dictionary<string, string>> RetrieveProfileAsync(string fid, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _client.BaseAddress + $"/v1/practitioners/{fid}/profile");
            AddAuthenticationToken(request);

            using (var response = await _client.SendAsync(request, cancellationToken))
            {
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
            };
        }

        public async Task<PdcPractitioner> RetrieveBOandLAsync(string fid, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _client.BaseAddress + $"/v1/practitioners/{fid}/verification");
            AddAuthenticationToken(request);

            using (var response = await _client.SendAsync(request, cancellationToken))
            {
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<PdcPractitioner>(content);
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
