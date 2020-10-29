using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MedApiSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var accessToken = AuthenticateUser("client", "password"); //replace with your clientId and clientSecret
            var licenseService = new LicensureService(_medClient, accessToken);
            var practitionerService = new PractitionerService(_medClient, accessToken);

            var licenseCount = licenseService.GetLicenseStatusAsync("999999923", CancellationToken.None);
            licenseCount.Wait();

            Console.WriteLine("The results of GetLicenseStatusAsync using fid 999999923: {0}", licenseCount.Result.ToString());
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        static string AuthenticateUser(string clientId, string clientSecret)
        {
            var authClient = new AuthenticationService(_authenticationClient);
            var accessToken = authClient.GetAccessTokenAsync(clientId, clientSecret, CancellationToken.None).Result;
            return accessToken.Token;
        }

        private static readonly HttpClient _medClient = new HttpClient() { BaseAddress = new Uri("https://tempuri.org") }; //replace with API address
        private static readonly HttpClient _authenticationClient = new HttpClient() { BaseAddress = new Uri("https://tempuri.org") }; //replace with API address or authentication address
    }
}
