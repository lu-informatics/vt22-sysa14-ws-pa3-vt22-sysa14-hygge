﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Assignment3Hygge
{
    public class DAL
    {

        public DataSet ReadData()
        {
            SqlConnection cnn = new SqlConnection("Data Source = SYST4DEV01; Initial Catalog = Hygge; User ID=hygge ; Password =hej123 ");
            cnn.Open();
            Console.WriteLine("Connection to database is successful");
            Console.WriteLine("Please enter:  Person, Relationship, Credentials, Intrest, Industry or Education to get information form the database");

            string query1 = "Select * from Person";


            SqlDataAdapter adapter = new SqlDataAdapter(query1, cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Person");
            return (ds);
            Console.WriteLine(ds);
            cnn.Close();




        }
    }
}
    