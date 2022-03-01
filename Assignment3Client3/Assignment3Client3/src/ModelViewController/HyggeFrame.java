package ModelViewController;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JButton;

import java.awt.event.ActionEvent;
import javax.swing.JTable;
import javax.swing.JLabel;
import javax.swing.JComboBox;
import javax.swing.JScrollPane;

public class HyggeFrame extends JFrame {

	private JPanel contentPane;
	private JTable tableData;
	private JComboBox comboBox;

	 
	 
	public HyggeFrame() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(200, 200, 750, 600);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		contentPane.setBackground(new Color (220,238,255));
		
		JLabel lblNewLabel = new JLabel("Please select a value :");
		lblNewLabel.setBounds(53, 154, 150, 14);
		contentPane.add(lblNewLabel);
		
		comboBox = new JComboBox();
		comboBox.setBounds(53, 171, 150, 22);
		contentPane.add(comboBox);
		
		comboBox.addItem("Person");
		comboBox.addItem("Industry");
		comboBox.addItem("Logins");
		comboBox.addItem("Education");
		comboBox.addItem("Intrest");
		comboBox.addItem("Relationship");;
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(49, 217, 595, 281);
		contentPane.add(scrollPane);
		
		tableData = new JTable();
	
		
		
		scrollPane.setViewportView(tableData);
		this.setVisible(true);
	}

	

	


	public JComboBox getComboBox() {
		return comboBox;
	}
	
	
	
}

