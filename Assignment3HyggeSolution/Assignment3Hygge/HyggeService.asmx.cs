using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace Assignment3Hygge
{
    /// <summary>
    /// Summary description for HyggeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HyggeService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string Meny()
        {
            return "---------Meny-------" + '\n' + "-----Please enter a One of Following ------"
                + '\n' + "Person, Industry, Login, Intrest, Education or Relationship";

        }

        [WebMethod]
        public void GetYourTables(string response)
        {
            response = "";
            while (response != "Exit")
            {
                response = Console.ReadLine();
                switch (response.ToLower())
                {
                    case "log":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Logins);
                        break;

                    case "pers":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Person);
                        break;

                    case "rela":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Relationship);
                        break;


                    case "int":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Interest);
                        break;

                    case "ind":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Industry);
                        break;

                    case "edu":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Education);
                        break;
                }
            }

        }
    }
}



    

  
