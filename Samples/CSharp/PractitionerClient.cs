using System;
using System.Net.Http;

namespace CSharp
{
    public class PractitionerClient : HttpClient
    {

        //Access token
        string token;
        string baseURL;

        public PractitionerClient(string accessToken, string baseUrl)
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
        /// Retrieve the fid of the medical professional with the given information. Requires the med.read scope.
        /// </summary>
        /// <param name="name">Name of practitioner</param>
        /// <param name="date">Birthdate of practitioner in MM/DD/YYYY format</param>
        /// <param name="ssn">Last 4 digits of practitioner's SSN</param>
        public void FindPractitionerBySSN(string name, string date, string ssn)
        {
            name = name.Trim();
            date = date.Trim();
            ssn = ssn.Trim();
            string url = baseURL + String.Format("/v1/practitioners/search?name={0}&birthDate={1}&ssnlast4={2}", name, date, ssn);
            Console.WriteLine(url);
            var response = GetAsync(url);
            
            
            Console.WriteLine(response.Result);
            // Output: { "fid":"#########"}           
        }

        /// <summary>
        /// Retrieve the fid of the medical professional with the given information. Requires the med.read scope.
        /// </summary>
        /// <param name="name">Name of practitioner</param>
        /// <param name="date">Birthdate of practitioner in MM/DD/YYYY format</param>
        /// <param name="license">License number of the practitioner</param>
        public void FindPractitionerLicense(string name, string date, string license)
        {
            string url = baseURL + String.Format("/v1/practitioners/search?name={0}&birthDate={1}&licenseNumber={2}", name, date, license);
            var response = GetStringAsync(url);
            Console.WriteLine(response.Result);
            // Output: { "fid":"#########"}
        }


        /// <summary>
        /// Retrieve the profile of the practitioner. Requires the med.read and med.cdc_read scopes.
        /// </summary>
        /// <param name="fid">fid of practitioner</param>
        public void RetrieveProfile(string fid)
        {
            string url = baseURL + String.Format("/v1/practitioners/{0}/profile", fid);
            var response = GetStringAsync(url);
            Console.WriteLine(response.Result);
        }

        /// <summary>
        /// Retrieve the Board Order and License information of a practitioner. Requires the med.read and med.source_read scopes.
        /// </summary>
        /// <param name="fid">fid of practitioner</param>
        public void RetrieveBOandL(string fid)
        {
            string url = baseURL + String.Format("/v1/practitioners/{0}/verification", fid);
            var response = GetStringAsync(url);
            Console.WriteLine(response.Result);
        }

    }
}
