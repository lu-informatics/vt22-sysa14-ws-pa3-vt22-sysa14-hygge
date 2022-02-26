package ModelViewController;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import javax.xml.crypto.Data;

import org.tempuri.HyggeServiceSoapProxy;
import org.tempuri.Table;

public class Controller {
	private HyggeFrame hyggeFrame;
	HyggeServiceSoapProxy proxy = new HyggeServiceSoapProxy();
	
	public Controller(HyggeFrame hyggeFrame) {
		this.hyggeFrame = hyggeFrame;	
		declareListerns();
	
		
	}
	public void populateTable() {
		Table[] tables = null;
		try {
			tables = proxy.viewAll((Table table);
		} catch (RemoteException e) {
			e.printStackTrace();
		}
		
		for (Table tmpTable : tables) {
		hyggeFrame.getTableDataModel().addTable(tmpTable);
		
	}
}
	public void comboBoxSeach() {    //Måste kalla på en metod som returnerar rätt från databasen baserat på val i combobox
		hyggeFrame.getBtnSearch().addActionListener(new ActionListener() { 
			public void actionPerformed(ActionEvent e) {
				
				ComboBox cb;
				Dataset data = new DefaultDataset();
				
				  switch (cb.Text)
		            {
		                case "Logins":
		                    ds = DataAccessLayer.Utils.ViewAll(Table.Logins);
		                    break;

		                case "Person":
		                    ds = DataAccessLayer.Utils.ViewAll(Table.Person);
		                    break;

		                case "Relationship":
		                   ds = DataAccessLayer.Utils.ViewAll(Table.Relationship);
		                    break;

		                case "Intrest":
		                   ds = DataAccessLayer.Utils.ViewAll(Table.Interest);
		                    break;

		                case "Industry":
		                    ds = DataAccessLayer.Utils.ViewAll(Table.Industry);
		                    break;

		                case "Education":
		                    ds = DataAccessLayer.Utils.ViewAll(Table.Education);
		                    break;

		            }
				  tableDataModel..DataSource = ds.Tables[0];
			}

				
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
