package ModelViewController;

import java.util.ArrayList;

import javax.swing.table.AbstractTableModel;

import org.tempuri.Table;

public class TableDataModel extends AbstractTableModel {
	private ArrayList<Table> tables = new  ArrayList<Table>();
	
	public void addTable(Table newTable) {
		tables.add(newTable);
		
	}
	
	@Override
	public int getRowCount() {
		// TODO Auto-generated method stub
		return 5;
	}

	@Override
	public int getColumnCount() {
		// TODO Auto-generated method stub
		return 2;
	}

	@Override
	public Object getValueAt(int rowIndex, int columnIndex) {
		// TODO Auto-generated method stub
		return null;
	}

}
