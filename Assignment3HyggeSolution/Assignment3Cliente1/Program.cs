

using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Assignment3Cliente1

    
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            
            
                HyggeService hyggeClient = new HyggeService();



               Console.WriteLine("---------Meny-------" + '\n' + "-----Please Enter a One Of Following ------"
                    + '\n' + "Person, Industry, Login, Intrest, Education or Relationship");

            

                string response = Console.ReadLine();
                //DataSet ds = new DataSet(); //Ta bort!
                
                while (response != "Exit")

                    switch (response.ToLower())
                    {
                        case "log":
                            //ds = DataAccessLayer.Utils.ViewAll(Table.Logins);
                            ds = hyggeClient.ViewAll(Table.Logins);
                            break;

                        case "pers":
                            ds = hyggeClient.ViewAll(Table.Person);
                            //ds = DataAccessLayer.Utils.ViewAll(Table.Person);
                            break;

                        case "rela":
                            ds = hyggeClient.ViewAll(Table.Relationship);
                            //ds = DataAccessLayer.Utils.ViewAll(Table.Relationship);
                            break;

                        case "int":
                            ds = hyggeClient.ViewAll(Table.Interest);
                            //ds = DataAccessLayer.Utils.ViewAll(Table.Interest);
                            break;

                        case "ind":
                            ds = hyggeClient.ViewAll(Table.Industry);
                            //ds = DataAccessLayer.Utils.ViewAll(Table.Industry);
                            break;

                        case "edu":
                            ds = hyggeClient.ViewAll(Table.Education);
                            //ds = DataAccessLayer.Utils.ViewAll(Table.Education);
                            break;

                    }
                var response = hyggeClient.ViewAll(table);
            }
           
            }
        }
    
            
