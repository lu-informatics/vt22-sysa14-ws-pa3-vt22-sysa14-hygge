using System;
using System.Data;
using Assignment3Hygge;
using System.Web.Service;


namespace Client2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Assignment3Hygge.HyggeService hyggeClient = new Assignment3Hygge.HyggeService();



            Console.WriteLine("---------Meny-------" + '\n' + "-----Please Enter a One Of Following ------"
                 + '\n' + "Person, Industry, Login, Intrest, Education or Relationship");



            string response = Console.ReadLine();
            /*DataSet ds = new DataSet(); *///Ta bort!

            public static void GetYourTables()
            {
                string response = "";
                while (response != "Exit")
                {
                    response = Console.ReadLine();
                    switch (response.ToLower())
                    {
                        case "log":
                            ViewAll(Table.Logins);
                            break;

                        case "pers":
                            ViewAll(Table.Person);
                            break;

                        case "rela":
                            ViewAll(Table.Relationship);
                            break;

                        case "int":
                            ViewAll(Table.Interest);
                            break;

                        case "ind":
                            ViewAll(Table.Industry);
                            break;

                        case "edu":
                            ViewAll(Table.Education);
                            break;

                    }
                }
            }
        }
    }
}

