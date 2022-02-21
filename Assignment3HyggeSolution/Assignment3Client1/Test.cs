using System;

public class Test {
	
	public static void Main(string[] args)
	{
		HyggeService proxy = new HyggeService();
		Console.WriteLine(proxy.HelloWorld());
	}

}