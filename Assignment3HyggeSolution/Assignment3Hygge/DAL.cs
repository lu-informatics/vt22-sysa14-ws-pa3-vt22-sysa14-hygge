using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Assignment3Hygge
{
    public class DAL
    {
        string command;
        public static DataTable ShowData(string query)
        {
            string connectionString = "Data Source = SYST4DEV01; Initial Catalog = Hygge; User ID=hygge ; Password =hej123 ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection)) ; // ; ska ej vara där
                {
                    using (SqlDataReader sdr = command.ExecuteReader()) 
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(sdr);

                        return dataTable;
                        
                        
                    }
                }
            }
        }
    }
}





        /*string response = "";
        while (response != "Exit")



        response = Console.ReadLine();
        switch (response.ToLower())
        {
        case "pers":
              getPersons();
              break;
        case "cred":
              getCredentials();
            break;
        case "rela":
              getRelationships();
              break;
        case "int":
              getIntrests();
        case "edu":
              break;
              getEducations();
        case "ind":
              break;

    static void getPersons()
    {
        
    }






        public DataSet ReadData(string query)
        {
            string connctionString = "Data Source = SYST4DEV01; Initial Catalog = Hygge; User ID=hygge ; Password =hej123 ";
            using (SqlConnection conn = new SqlConnection(connctionString))

                conn.Open();

            using (SqlConnection conn = new SqlConnection(query, conn)) ;


            switch*/





