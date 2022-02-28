package ModelViewController;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

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
		Table[] tables = null;
		try {
			tables = proxy.viewAll(null); //kan ej hämta ett DataSet från WS
		} catch (RemoteException e) {
			e.printStackTrace();
		}
		hyggeFrame.getTableDataModel(tables);
		

}
	public void comboBoxSeach() {    //Måste kalla på en metod som returnerar rätt från databasen baserat på val i combobox
		hyggeFrame.getBtnSearch().addActionListener(new ActionListener() { 
			public void actionPerformed(ActionEvent e) {
				
	}
	});
	}
	
	public void declareListerns () {
		hyggeFrame.getBtnSearch().addActionListener(new ActionListener() {  //	hyggeFrame.getBtnSearch().add hämtar en referens till knappen, knappen ligger på heepen som ett obejkt
			public void actionPerformed(ActionEvent e) {
				System.out.println("Hej");
			}
		});
	}
}
