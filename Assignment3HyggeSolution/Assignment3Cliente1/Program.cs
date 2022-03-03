//TA BORT DENNA CLASS LOKALT? MEN ÄNDÅ HA KVAR I FILVÄGEN!!???

using System;
using System.Data;


namespace Assignment3Cliente1
{
    internal class Program
    {

        static void Main(string[] args)

        {

            HyggeService hyggeClient = new HyggeService();



            Console.WriteLine("---------Meny-------" + '\n' + "-----Please Enter a One Of Following ------"
                + '\n' + "Person, Industry, Login, Intrest, Education, Relationship, PersonInterest or EducationIndustry");

            string response = Console.ReadLine();
            DataSet ds = new DataSet();

            var response1 = hyggeClient.ViewAll(response).Tables[0];
            foreach (DataRow dataRow in response1.Rows)
            {
                foreach (DataColumn dataColumn in response1.Columns)
                {
                    Console.WriteLine(dataRow[dataColumn].ToString());

                }
            }



        }

    }
}