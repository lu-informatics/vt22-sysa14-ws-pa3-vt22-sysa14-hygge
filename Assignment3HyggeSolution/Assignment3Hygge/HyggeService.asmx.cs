using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public DataSet ViewAll(Table table) //Vi har ändrat!
            //Vårt dataSet är populerat med ett dataTable som ligger på index 0.
        {
            //DETTA KAN VI TA BORT!
            //DataSet dataSet = DataAccessLayer.Utils.ViewAll(table);
            //DataTable table1 = dataSet.Tables[0];
            //dataSet.Tables.Add(table1);

            //return dataSet;
            return DataAccessLayer.Utils.ViewAll(table);


        }
        [WebMethod]
        public void GetYourTables()
        {
            try
            {
                return dal.GetYourTables();

            }
            catch (Exception)
        }
            Console.WriteLine("Connection faild to get data form GetYourTables()");

            return null;



        }

    }
}
    




    

  
