using System;

namespace Assignment3Hygge {

public class Test {
	
	public static void Main(string[] args)
	{
		HyggeService.HyggeServiceSoapClient.EndpointConfiguration config = HyggeServiceSoapClient.EndpointConfiguration.HyggeServiceSoap;
		HyggeServiceSoapClient proxy = new HyggeServiceSoapClient(config);

		Console.WriteLine("---------Meny-------" + '\n' + "-----Please Enter a One Of Following ------"
                  + '\n' + "Person, Industry, Login, Intrest, Education or Relationship");
            string response = Console.ReadLine();
		Console.WriteLine(proxy.ViewAll());
        Console.WriteLine(proxy.response());



		
	}

}
