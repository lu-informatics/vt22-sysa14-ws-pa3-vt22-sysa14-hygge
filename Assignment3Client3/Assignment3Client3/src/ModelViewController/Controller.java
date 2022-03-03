package ModelViewController;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import javax.swing.JTable;
import javax.swing.table.AbstractTableModel;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.JTableHeader;
import javax.swing.table.TableColumn;
import javax.swing.table.TableColumnModel;
import javax.xml.crypto.Data;

import org.tempuri.HyggeServiceSoapProxy;
import org.tempuri.Table;

public class Controller { // controls the GUI and call the SOAP via proxy, proxy is working like a DAL.

	HyggeServiceSoapProxy proxy = new HyggeServiceSoapProxy();

	private String[] personHeaders = new String[] { "personID", "userName", "age", "gender", "email",
			"relationshipType", "industryName", "educationName", "preference" };
	private String[] educationHeaders = new String[] { "educationName", "locale" };
	private String[] industryHeaders = new String[] { "category", "interestGroup" };
	private String[] interestHeaders = new String[] { "educationName", "locale" };
	private String[] loginsHeaders = new String[] { "pword", "email" };
	private String[] relationshipHeaders = new String[] { "relationshipType", "levelOfCommitment" };
	private String[] educationIndustryHeaders = new String[] { "industryName", "educationName" };
	private String[] personInterestHeaders = new String[]  { "personID", "category" };

	private HyggeFrame hyggeFrame;

	public Controller(HyggeFrame hyggeFrame) {
		this.hyggeFrame = hyggeFrame;
		declareListerns();

	}

	public void declareListerns() {
		hyggeFrame.getComboBox().addActionListener(new ActionListener() { // hyggeFrame.getComboBox().add gets a
																			// reference to the comboBox, it's placed on
																			// the heap as an object.
			public void actionPerformed(ActionEvent e) {

				try {
					String response = hyggeFrame.getComboBox().getSelectedItem().toString(); // call response on the
																								// GUI.
					Object[][] tableArray = proxy.getTableAsList(response);
					addTable(hyggeFrame.getTableData(), tableArray, allHeaders());

				} catch (RemoteException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}

			}

		});
	}

	public void addTable(JTable table, Object[][] array, String[] headers) { // take the table we want to fill and which
																				// data to fill it
		// with.
		Object[][] objects = array;
		DefaultTableModel model = new DefaultTableModel(); // create a new DefaulTableModel.
		model.setColumnCount(objects[0].length); // set how many columns there should be in the table, depending on
													// amount of columns in the array.
		table.setModel(model); // set model to the JTable.

		for (int i = 0; i < headers.length; i++) {
			JTableHeader tHeader = table.getTableHeader();
			TableColumnModel tableColumnModel = tHeader.getColumnModel(); // adding cast to DefaultTableModel.
			TableColumn tc = tableColumnModel.getColumn(i); // adding cast to model.
			tc.setHeaderValue(headers[i]);
			tc.setMinWidth(300);
			tHeader.repaint();

		}

		for (int i = 0; i < objects.length; i++) { // put the data into the model.
			Object[] obj = objects[i]; // object on the index i.
			DefaultTableModel tableModel = (DefaultTableModel) table.getModel(); // get the model from table.
			tableModel.addRow(obj); // add row.

		}
		table.setAutoResizeMode(JTable.AUTO_RESIZE_OFF);

	}

	// tar emot response och returnerar en header.
	public String[] allHeaders() {
		String response1 = hyggeFrame.getComboBox().getSelectedItem().toString();

		switch (response1) {  
		case "Person":
			return personHeaders;
		case "Education":
			return educationHeaders;
		case "Industry":
			return industryHeaders;
		case "Interest":
			return interestHeaders;
		case "Login":
			return loginsHeaders;
		case "Relationship":
			return relationshipHeaders;
		case "EducationIndustry":
			return educationIndustryHeaders;
		case "PersonInterest"
			return personInterestHeaders;

		}
		return null;

	}

}
