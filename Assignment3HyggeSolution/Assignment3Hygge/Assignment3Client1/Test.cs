using System;

namespace Assignment3Hygge {

public class Test {
	
	public static void Main(string[] args)
	{
		HyggeService.HyggeServiceSoapClient.EndpointConfiguration config = HyggeServiceSoapClient.EndpointConfiguration.HyggeServiceSoap;
		HyggeServiceSoapClient proxy = new HyggeServiceSoapClient(config);
		Console.WriteLine(proxy.Meny());
		Console.WriteLine(proxy.HelloWorld());



		//HyggeService proxy = new HyggeService();
		//Console.WriteLine(proxy.HelloWorld());
		//Console.WriteLine(proxy.Meny());
	}

}
