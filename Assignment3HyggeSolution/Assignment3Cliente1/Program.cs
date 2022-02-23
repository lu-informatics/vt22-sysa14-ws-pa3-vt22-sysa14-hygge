using System;


namespace Assignment3Cliente1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HyggeService client = new HyggeService();
            }
            Console.WriteLine("---------Meny-------" + '\n' + "-----Please enter a One of Following ------"
                + '\n' + "Person, Industry, Login, Intrest, Education or Relationship");



        }
    }
}
