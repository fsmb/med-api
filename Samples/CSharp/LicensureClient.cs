using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSharp
{
    public class LicensureClient : HttpClient
    {
        string baseURL, clientID, clientSecret, authURL, scope, token;

        public LicensureClient(string clientId, string clientS, string authUrl, string scope, string baseUrl)
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
        /// Retrieve the license status of a given practitioner. Requires the med.read scope.
        /// </summary>
        /// <param name="fid">fid of practitioner</param>
        public async Task<HttpResponseMessage> AsyncGetLicenseStatus(string fid)
        {
            string url = baseURL + String.Format("/v1/licensure/{0}/summary", fid);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await client.SendAsync(requestMessage);
        }

        private static HttpClient client; 
    }
}
