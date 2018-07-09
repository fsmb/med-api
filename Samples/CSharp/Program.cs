using System;

namespace CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            string baseUrl, authUrl, clientID, clientSecret, scope;
            Console.Write("Please enter the auth url: ");
            authUrl = Console.ReadLine();
            Console.Write("Please enter the base url: ");
            baseUrl = Console.ReadLine();
            Console.Write("Please enter the client id: ");
            clientID = Console.ReadLine();
            Console.Write("Please enter the client secret: ");
            clientSecret = Console.ReadLine();
            Console.Write("Please enter the authorization scope: ");
            scope = Console.ReadLine();

            var License = new LicensureClient( clientID, clientSecret,authUrl, scope, baseUrl);
            var Practitioner = new PractitionerClient(clientID, clientSecret, authUrl, scope, baseUrl);
            char choice = ' ';
            string thing;

            
            do
            {
                try
                {
                    Console.Write("\n\nWhich resource do you want?\n1. Practitioners\n2. Licensure\n0. to exit\n\n");
                    thing = Console.ReadLine();
                    choice = thing[0];

                    switch (choice)
                    {
                        case '0':
                            Console.WriteLine("Exiting app...");
                            break;
                        case '1':
                            PractitionerMenu(Practitioner);
                            break;
                        case '2':
                            LicensureMenu(License);
                            break;
                        default:
                            Console.WriteLine("Invalid input. Try again.");
                            continue;
                    }


                }catch(Exception e) //most likely to fail due to invalid auth
                {
                    License.Authenticate();
                    Practitioner.Authenticate();
                }


            } while (choice != '0');
            
            
        }

        public static void LicensureMenu(LicensureClient license)
        {
            char choice;
            string fid, thing;
            do
            {
                Console.Write("\n\nWhich Request do you want to make?\n1. GetLicenseStatus\n0. to exit\n\n");
                thing = Console.ReadLine();
                choice = thing[0];
                switch (choice)
                {
                    case '0':
                        break;
                    case '1':
                        Console.Write("Please enter the practitioner's fid: ");
                        fid = Console.ReadLine();
                        var response =  license.AsyncGetLicenseStatus(fid);
                        response.Wait();
                        Console.WriteLine(response.Result.Content.ReadAsStringAsync().Result.ToString());
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        continue;
                }
            } while (choice != '0');
        }

        public static void PractitionerMenu(PractitionerClient practitioner)
        {
            char choice;
            string name, date, varies, fid, thing;
            do
            {
                Console.Write("Which Request do you want to make?\n1. FindPractitionerBySSN\n2. FindPractitionerByLicense\n3. RetrieveProfile\n4. RetrieveBOandL\n0. to exit\n\n");
                thing = Console.ReadLine();
                choice = thing[0];
                switch (choice)
                {
                    case '0':
                        break;
                    case '1':
                    {
                        Console.Write("Please enter the practitioner's full name: ");
                        name = Console.ReadLine();
                        Console.Write("Please enter the practitioner's date of birth in mm/dd/yyyy format: ");
                        date = Console.ReadLine();
                        Console.Write("Please enter the last four digits of the practitioner's SSN: ");
                        varies = Console.ReadLine();
                        var response = practitioner.FindPractitionerBySSN(name, date, varies);
                        response.Wait();
                        Console.WriteLine(response.Result.Content.ReadAsStringAsync().Result.ToString());
                        break;
                    }
                    case '2':
                    {
                        Console.Write("Please enter the practitioner's full name: ");
                        name = Console.ReadLine();
                        Console.Write("Please enter the practitioner's date of birth in mm/dd/yyyy format: ");
                        date = Console.ReadLine();
                        Console.Write("Please enter the practitioner's license number: ");
                        varies = Console.ReadLine();
                        var response = practitioner.FindPractitionerBySSN(name, date, varies);
                        response.Wait();
                        Console.WriteLine(response.Result.Content.ReadAsStringAsync().Result.ToString());
                        break;
                    }                        
                    case '3':
                    {
                        Console.Write("Please enter the practitioner's fid: ");
                        fid = Console.ReadLine();
                        var response = practitioner.RetrieveProfile(fid);
                        response.Wait();
                        Console.WriteLine(response.Result.Content.ReadAsStringAsync().Result.ToString());
                        break;
                    }
                    case '4':
                    {
                        Console.Write("Please enter the practitioner's fid: ");
                        fid = Console.ReadLine();
                        var response = practitioner.RetrieveBOandL(fid);
                        response.Wait();
                        Console.WriteLine(response.Result.Content.ReadAsStringAsync().Result.ToString());
                        break;
                    }
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        continue;
                }
            } while (choice != '0');

        }


    }
}
