using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSharp
{
    public class PractitionerClient : HttpClient
    {

        string baseURL, clientID, clientSecret, authURL, scope, token;

        public PractitionerClient(string clientId, string clientS, string authUrl, string scope, string baseUrl)
        {
            client = new HttpClient();
            clientID = clientId;
            clientSecret = clientS;
            authURL = authUrl;
            this.scope = scope;
            baseURL = baseUrl;
            var response = Authenticate();
        }

        public async Task<HttpStatusCode> Authenticate()
        {
            var request = authURL + "/connect/token";
            var data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("client_id", clientID));
            data.Add(new KeyValuePair<string, string>("client_secret", clientSecret));
            data.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            data.Add(new KeyValuePair<string, string>("scope", scope));

            var content = new FormUrlEncodedContent(data);
            var response = await client.PostAsync(request, content);
            var json = response.Content.ReadAsStringAsync().Result.ToString();
            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            values.TryGetValue("access_token", out token);
            return response.StatusCode;

        } 
        /// <summary>
        /// Retrieve the fid of the medical professional with the given information. Requires the med.read scope.
        /// </summary>
        /// <param name="name">Name of practitioner</param>
        /// <param name="date">Birthdate of practitioner in MM/DD/YYYY format</param>
        /// <param name="ssn">Last 4 digits of practitioner's SSN</param>
        public async Task<HttpResponseMessage> FindPractitionerBySSN(string name, string date, string ssn)
        {

            string url = baseURL + String.Format("/v1/practitioners/search?name={0}&birthDate={1}&ssnlast4={2}", name, date, ssn);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await client.SendAsync(requestMessage);
        }

        /// <summary>
        /// Retrieve the fid of the medical professional with the given information. Requires the med.read scope.
        /// </summary>
        /// <param name="name">Name of practitioner</param>
        /// <param name="date">Birthdate of practitioner in MM/DD/YYYY format</param>
        /// <param name="license">License number of the practitioner</param>
        public async Task<HttpResponseMessage> FindPractitionerLicense(string name, string date, string license)
        {
            string url = baseURL + String.Format("/v1/practitioners/search?name={0}&birthDate={1}&licenseNumber={2}", name, date, license);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await client.SendAsync(requestMessage);
        }


        /// <summary>
        /// Retrieve the profile of the practitioner. Requires the med.read and med.cdc_read scopes.
        /// </summary>
        /// <param name="fid">fid of practitioner</param>
        public async Task<HttpResponseMessage> RetrieveProfile(string fid)
        {
            string url = baseURL + String.Format("/v1/practitioners/{0}/profile", fid);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await client.SendAsync(requestMessage);
        }

        /// <summary>
        /// Retrieve the Board Order and License information of a practitioner. Requires the med.read and med.source_read scopes.
        /// </summary>
        /// <param name="fid">fid of practitioner</param>
        public async Task<HttpResponseMessage> RetrieveBOandL(string fid)
        {
            string url = baseURL + String.Format("/v1/practitioners/{0}/verification", fid);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await client.SendAsync(requestMessage);
        }

        private static HttpClient client;
    }
}
