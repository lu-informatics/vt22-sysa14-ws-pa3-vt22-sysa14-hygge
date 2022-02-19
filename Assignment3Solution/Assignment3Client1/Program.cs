using System;
using HyggeService;

namespace Assignment3Client1
{
    internal class Program
    {
        static void Main(string[] args)

        {
           HyggeServiceSoapClient.EndpointConfiguration comfig = HyggeServiceSoapClient.EndpointConfiguration.HyggeServiceSoap;
           HyggeServiceSoapClient proxy = new HyggeServiceSoapClient(comfig);

            Console.WriteLine(proxy.HelloWorld());
            Console.WriteLine(proxy.Add(50, 100));

            
        }
    }
}
