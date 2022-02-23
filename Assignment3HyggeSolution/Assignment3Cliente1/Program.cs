

using System;
using System.Data;
using System.Data.SqlClient;


namespace Assignment3Cliente1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                HyggeService client = new HyggeService();



                Console.WriteLine("---------Meny-------" + '\n' + "-----Please Enter a One Of Following ------"
                    + '\n' + "Person, Industry, Login, Intrest, Education or Relationship");

                string response = Console.ReadLine();
                DataSet ds = new DataSet();

                while (response != "Exit")

                    switch (response.ToLower())
                    {
                        case "log":
                            ds = DataAccessLayer.Utils.ViewAll(Table.Logins);
                            break;

                        case "pers":
                            ds = DataAccessLayer.Utils.ViewAll(Table.Person);
                            break;

                        case "rela":
                            ds = DataAccessLayer.Utils.ViewAll(Table.Relationship);
                            break;

                        case "int":
                            ds = DataAccessLayer.Utils.ViewAll(Table.Interest);
                            break;

                        case "ind":
                            ds = DataAccessLayer.Utils.ViewAll(Table.Industry);
                            break;

                        case "edu":
                            ds = DataAccessLayer.Utils.ViewAll(Table.Education);
                            break;

                    }
            }
           
            }
        }
    }
            
