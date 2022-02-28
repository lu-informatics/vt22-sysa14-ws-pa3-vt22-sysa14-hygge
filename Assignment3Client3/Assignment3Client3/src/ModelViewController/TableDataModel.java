package ModelViewController;

import java.lang.reflect.Proxy;
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
		return 2;
	}

	@Override
	public int getColumnCount() {
		// TODO Auto-generated method stub
		return 2;
	}

	@Override
	public Object getValueAt(int rowIndex, int columnIndex) {
		Table tmpTable = tables.get(rowIndex);
		// TODO Auto-generated method stub

	}

}
