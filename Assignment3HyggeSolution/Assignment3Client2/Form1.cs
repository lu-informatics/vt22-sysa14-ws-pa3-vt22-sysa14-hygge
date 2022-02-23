using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Assignment3Client2
{
    public partial class Form1 : Form

    {
       
      
        public Form1()
        {
            InitializeComponent();
            comboBoxValues.Items.Clear();
           
        }

        private void comboBoxValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Person");
            comboBox.Items.Add("Logins");
            comboBox.Items.Add("Relationship");
            comboBox.Items.Add("Intrest");
            comboBox.Items.Add("Industry");
            comboBox.Items.Add("Logins");
            comboBox.Items.Add("Education");

            this.Controls.Add(comboBox);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string response = "";
            while (response != "Exit")
            {
                response = Console.ReadLine();
                switch (response.ToLower())
                {
                    case "Logins":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Logins);

                        break;

                    case "Person":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Person);
                        break;

                    case "Relationship":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Relationship);
                        break;

                    case "Intrest":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Intrest);
                        break;

                    case "Industry":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Industry);
                        break;

                    case "Education":
                        DataAccessLayer.Utils.ViewAll(DataAccessLayer.Table.Education);
                        break;

                }
            }
        }

        private void dataGridViewLoadDataBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
