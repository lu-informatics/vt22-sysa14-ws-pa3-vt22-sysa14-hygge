package ModelViewController;

import java.rmi.RemoteException;

import javax.swing.table.AbstractTableModel;

import org.tempuri.HyggeServiceSoapProxy;

public class RelationshipTableModel extends AbstractTableModel {
	

	private HyggeServiceSoapProxy soapProxy = new HyggeServiceSoapProxy();  //Create a new instance of our soapProxy, aka DataAccessLayer. 
	private Object[][] objArray = this.getRelationship(); //Create a new instance from our proxy, so we can get access to the list of object[].
	
	

	@Override
	public int getRowCount() {
		// TODO Auto-generated method stub
		return objArray.length;
	}

	@Override
	public int getColumnCount() {
		// TODO Auto-generated method stub
		return objArray[0].length;
	}

	@Override
	public Object getValueAt(int rowIndex, int columnIndex) {
		// TODO Auto-generated method stub
		return null;
	} 
	
	public Object[][] getRelationship(){ //Method that calls our method getTableAsList() via proxy in webservice. In the Controller
		//we will make calls through our combobox based on the value choosen. 
		
		try { //we surround with try/catch when we make calls to our webservice.
			return soapProxy.getTableAsList("Relationship"); //Call the table: Relationship. 
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}

}
