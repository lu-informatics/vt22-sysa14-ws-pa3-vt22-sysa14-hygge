package ModelViewController;

import java.rmi.RemoteException;
import java.util.List;

import org.tempuri.HyggeServiceSoapProxy;
import org.tempuri.Table;

public class Client3 {

	public static void main(String[] args) {

		HyggeFrame hyggeFrame = new HyggeFrame();
		Controller controller = new Controller(hyggeFrame);

		HyggeServiceSoapProxy proxy = new HyggeServiceSoapProxy();

		String tableName = "Interest"; // Vilket table vill vi hämta?
		try {
			Object[][] objArray = proxy.getTableAsList(tableName); // two-dimensional array. Det är en array av arrays.
																	// // första hakklammer är: [rad] och [column]

			for (Object[] tempObj : objArray) {

				for (int i = 0; i < tempObj.length; i++) {
					System.out.println(tempObj[i]); // Skriver ut kolumn 1, 2, 3 osv osv

				}

			}

		} catch (RemoteException e) {
			e.printStackTrace();
		}
	}

}
