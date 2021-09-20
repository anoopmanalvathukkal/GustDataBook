using GustData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUI
{
    class Program
    {

        public static List<PersonModel> peopels = new List<PersonModel>();

        static void Main(string[] args)
        {

            //get all gust information
            GetGustAllInformation();

            //display all data
            DisplayUserInformations();

            //wait until press something
            //keep this for checking
            //deeps
            Console.ReadKey(true);

        }

        private static string GetGustData(string userMessage)
        {
            string output = "";

            Console.Write($"{userMessage} ");
            output = Console.ReadLine();

            return output;
        }

        private static void GetGustAllInformation()
        {
            string moreUserComing = "";

            do
            {
                // initialize person data
                PersonModel person = new PersonModel();

                person.FristName = GetGustData("Enter user firstName");
                person.LastName = GetGustData("Enter user lastName");
                person.Message = GetGustData("Enter user message to host");

                Console.WriteLine("-----------------------------------");
                Console.Write("Are more gust coming yes/no ");
                moreUserComing = Console.ReadLine();

                //add data to list
                peopels.Add(person);
                Console.Clear();

            } while (moreUserComing.ToLower() == "yes");
        }

        private static void DisplayUserInformations()
        {
            Console.Clear();

            if (peopels.Count > 0)
            {
                foreach (var item in peopels)
                {
                    Console.WriteLine(item.FristName);
                    Console.WriteLine(item.LastName);
                    Console.WriteLine(item.Message);
                    Console.WriteLine("-----------------------");
                }

            }
            else
            {
                Console.WriteLine("No data has been added!");
            }


        }
    }
}
