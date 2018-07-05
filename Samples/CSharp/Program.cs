using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl, token;
            Console.Write("Please enter the base url: ");
            baseUrl = Console.ReadLine();
            Console.Write("Please enter the access token: ");
            token = Console.ReadLine();

            var License = new LicensureClient(token, baseUrl);
            var Practitioner = new PractitionerClient(token, baseUrl);

            char choice;
            string thing;

            try{
                do{
                    Console.Write("\n\nWhich resource do you want?\n1. Practitioners\n2. Licensure\n0. to exit\n\n");
                    thing = Console.ReadLine();
                    choice = thing[0];

                    switch(choice){
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

                }while(choice!= '0');
            }
            catch(Exception e){
                Console.WriteLine(e.ToString());
            }
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
                        license.GetLicenseStatus(fid);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        continue;
                }
            } while (choice != '0');
        }


        public static void PractitionerMenu(PractitionerClient practitioner){
            char choice;
            string name, date, varies, fid, thing;
            do{
                Console.Write("Which Request do you want to make?\n1. FindPractitionerBySSN\n2. FindPractitionerByLicense\n3. RetrieveProfile\n4. RetrieveBOandL\n0. to exit\n\n");
                thing = Console.ReadLine();
                choice = thing[0];
                switch(choice){
                    case '0':
                        break;
                    case '1':
                        Console.Write("Please enter the practitioner's full name: ");
                        name = Console.ReadLine();
                        Console.Write("Please enter the practitioner's date of birth in mm/dd/yyyy format: ");
                        date = Console.ReadLine();
                        Console.Write("Please enter the last four digits of the practitioner's SSN: ");
                        varies = Console.ReadLine();
                        practitioner.FindPractitionerBySSN(name, date, varies);
                        break;
                    case '2':
                        Console.Write("Please enter the practitioner's full name: ");
                        name = Console.ReadLine();
                        Console.Write("Please enter the practitioner's date of birth in mm/dd/yyyy format: ");
                        date = Console.ReadLine();
                        Console.Write("Please enter the practitioner's license number: ");
                        varies = Console.ReadLine();
                        practitioner.FindPractitionerBySSN(name, date, varies);
                        break;
                    case '3':
                        Console.Write("Please enter the practitioner's fid: ");
                        fid = Console.ReadLine();
                        practitioner.RetrieveProfile(fid);
                        break;
                    case '4':
                        Console.Write("Please enter the practitioner's fid: ");
                        fid = Console.ReadLine();
                        practitioner.RetrieveBOandL(fid);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        continue;
                }
            }while(choice != '0');

        }   

    }
}
