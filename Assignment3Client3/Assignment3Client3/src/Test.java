import java.rmi.RemoteException;

import org.tempuri.*;

public class Test {

	public static void main(String[] args) {
		
		HyggeServiceSoapProxy proxy = new 	HyggeServiceSoapProxy(); 
		try {
			System.out.println(proxy.helloWorld());
			System.out.println(proxy.viewAll(null));
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

}
