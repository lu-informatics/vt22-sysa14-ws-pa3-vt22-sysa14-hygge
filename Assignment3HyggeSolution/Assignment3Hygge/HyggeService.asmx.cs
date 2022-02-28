using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Services;
using static Assignment3Hygge.DataAccessLayer;

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
        private DataAccessLayer dal = new DataAccessLayer();
        private List<Table> tables = new List<Table>();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]

        public DataSet ViewAll(Table table)              //C# clienten kan hantera dataset via soap och ta emot, MEN JAVA fattar inte de, 

        public DataSet ViewAll(string table)

        {
            switch (table) //flyttat från client till webbservice
            {
                case "Logins":
                    return DataAccessLayer.Utils.ViewAll(Table.Logins);


                case "Person":
                    return DataAccessLayer.Utils.ViewAll(Table.Person);



                case "Relationship":
                    return DataAccessLayer.Utils.ViewAll(Table.Relationship);



        }
       
            


                case "Intrests":
                    return DataAccessLayer.Utils.ViewAll(Table.Interest);



                case "Industry":
                    return DataAccessLayer.Utils.ViewAll(Table.Industry);


                case "Educations":
                    return DataAccessLayer.Utils.ViewAll(Table.Education);


            }
            throw new Exception("The table was not found in the database!"); //Något exception? 
     

        }
      
        

    }

}










