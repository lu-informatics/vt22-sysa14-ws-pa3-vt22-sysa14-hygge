package ModelViewController;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import javax.swing.table.DefaultTableModel;
import javax.xml.crypto.Data;

import org.tempuri.HyggeServiceSoapProxy;
import org.tempuri.Table;

public class Controller {            //styr GUI och anroppar inte SOAP-tjänster direkt utan anroppar soap-tjänster via proxy, prxy funkar som en DAL
	private HyggeFrame hyggeFrame;
	private HyggeServiceSoapProxy proxy;
	
	public Controller(HyggeFrame hyggeFrame) {
		this.hyggeFrame = hyggeFrame;	
		declareListerns();
		 populateTable();
	
		
	}
	public void populateTable() {
		
		
		Object[] obj = null;
		try {
			obj = proxy.getTableAsList(null);
		} catch (RemoteException e) {
			e.printStackTrace();
		}
	//	hyggeFrame.getTableDataModel();
		

}
	public void addTable () {
		for (int i = 0; i < objects.length; i++) {
			Objects[] obj = Objects[i];
			DefaultTableModel tableModel = (DefaultTableModel table.getModel();
			tableModel.addRow(obj);
			
			
		}
		table.setAutoResizeMode(JTable.AUTO_RESIZE_OFF);
			
		
	}

	
	
	public void declareListerns () {
		hyggeFrame.getComboBox().addActionListener(new ActionListener() {  //	hyggeFrame.getBtnSearch().add hämtar en referens till knappen, knappen ligger på heepen som ett obejkt
			public void actionPerformed(ActionEvent e) {
				
			//Anropa metoden som innehåller switch/case.	kalla på comboboxen och så kör vi fill table metodem, som den ska fill med. 
				//GetTableAsList
			}
		});
	}
}
