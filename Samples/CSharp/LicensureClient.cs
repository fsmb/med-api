using System;
using System.Net.Http;

namespace CSharp
{
    public class LicensureClient : HttpClient
    {
        //Access token
        string token;
        string baseURL;

        public LicensureClient(string accessToken, string baseUrl)
        {
            token = accessToken;
            baseURL = baseUrl;
            DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        public void Authorize(string accessToken)
        {
            token = accessToken;
            DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        /// <summary>
        /// Retrieve the license status of a given practitioner. Requires the med.read scope.
        /// </summary>
        /// <param name="fid">fid of practitioner</param>
        public void GetLicenseStatus(string fid)
        {
            string url = baseURL + String.Format("/v1/licensure/{0}/summary", fid);
            var response = GetStringAsync(url);
            Console.WriteLine(response.Result);
            //Output: { "fid":"#########","count":# }
        }
    }
}
