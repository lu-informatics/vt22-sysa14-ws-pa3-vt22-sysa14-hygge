package ModelViewController;

import java.rmi.RemoteException;

import javax.swing.table.AbstractTableModel;

import org.tempuri.HyggeServiceSoapProxy;

public class EducationTableModel extends AbstractTableModel {
	
	private HyggeServiceSoapProxy soapProxy = new HyggeServiceSoapProxy();
	
	private Object[][] objArray = this.getEducation();
	
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
	public Object[][] getEducation(){
		
		try {
			return soapProxy.getTableAsList("Education");
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}

}
