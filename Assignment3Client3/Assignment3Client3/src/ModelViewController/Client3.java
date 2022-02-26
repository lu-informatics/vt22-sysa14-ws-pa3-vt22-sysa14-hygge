package ModelViewController;

import java.rmi.RemoteException;

import org.tempuri.HyggeServiceSoapProxy;
import org.tempuri.Table;

public class Client3 {

	public static void main(String[] args) {
		
		HyggeFrame hyggeFrame = new HyggeFrame();
		Controller controller = new Controller(hyggeFrame);
		
		
		
		/*	HyggeServiceSoapProxy proxy = new HyggeServiceSoapProxy();
		
		String test;
		try {
			test = proxy.helloWorld();
			System.out.println(test);		
			
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}*/
		
		
		
		

	}

}
