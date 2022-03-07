package ModelViewController;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.JTableHeader;
import javax.swing.JButton;

import java.awt.event.ActionEvent;
import javax.swing.JTable;
import javax.swing.ScrollPaneConstants;
import javax.swing.JLabel;
import javax.swing.JComboBox;
import javax.swing.JScrollPane;
import java.awt.event.ActionListener;

public class HyggeFrame extends JFrame {

	private JPanel contentPane;
	private JTable tableData;
	private JComboBox comboBox;
	private JTableHeader jTableHeader;

	public JPanel getContentPane() {
		return contentPane; 
	}

	public HyggeFrame() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(500, 400, 1060, 616);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		contentPane.setBackground(new Color(220, 238, 255));
		JLabel lblNewLabel = new JLabel("Please select a value :");
		lblNewLabel.setBounds(53, 154, 150, 14);
		contentPane.add(lblNewLabel);

		comboBox = new JComboBox();

		comboBox.setBounds(53, 171, 150, 22);
		contentPane.add(comboBox);
		this.setVisible(true); // makes the frame visible on the screen.

		comboBox.addItem("Person");
		comboBox.addItem("Industry");
		comboBox.addItem("Login");
		comboBox.addItem("Education");
		comboBox.addItem("Interest");
		comboBox.addItem("Relationship");
		comboBox.addItem("EducationIndustry");
		comboBox.addItem("PersonInterest");

		JScrollPane scrollPane = new JScrollPane();
		
		scrollPane.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
		scrollPane.setHorizontalScrollBarPolicy(ScrollPaneConstants.HORIZONTAL_SCROLLBAR_ALWAYS);
	
		
		scrollPane.setToolTipText("");
		scrollPane.setBounds(48, 217, 1000, 267);
		contentPane.add(scrollPane);


		tableData = new JTable();
		jTableHeader = new JTableHeader();

		scrollPane.setViewportView(tableData);
		this.setVisible(true);
	}

	public JTable getTableData() {
		return tableData;
	}

	public JComboBox getComboBox() {
		return comboBox;
	}

	public void setTableData(JTable tableData) {
		this.tableData = tableData;
	}

	public void setComboBox(JComboBox comboBox) {
		this.comboBox = comboBox;
	}

	public JTableHeader getJTableHeader() {
		return jTableHeader;
	}

	public void setJTableHeader(JTableHeader jTableHeader) {
		this.jTableHeader = jTableHeader;
	}

}
