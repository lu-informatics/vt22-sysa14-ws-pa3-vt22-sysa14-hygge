
using HyggeService;

public class Test {
	
	public static void Main(string[] args)
	{
		HyggeService proxy = new HyggeService();
		Console.Writeline(proxy.HelloWorld());
		
	}

}