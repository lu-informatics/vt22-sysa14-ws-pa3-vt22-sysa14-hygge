using HyggeService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Client22.DataAccessLayer;
using static HyggeService.HyggeServiceSoapClient;
using System.Configuration;
using System.Data.SqlClient;



namespace Client22
{
    public partial class Form1 : Form
    {
        private static HyggeService.HyggeServiceSoapClient.EndpointConfiguration config = HyggeServiceSoapClient.EndpointConfiguration.HyggeServiceSoap;
        private HyggeServiceSoapClient proxy = new HyggeServiceSoapClient(config);
        public Form1()
        {

            InitializeComponent();
            comboBoxValue.Items.Clear();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxValue.Items.Add("Person");
            comboBoxValue.Items.Add("Logins");
            comboBoxValue.Items.Add("Relationship");
            comboBoxValue.Items.Add("Intrest");
            comboBoxValue.Items.Add("Education");
            comboBoxValue.Items.Add("Industry");


        }

        private void comboBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {

            
                ComboBox cb = sender as ComboBox;
                DataSet ds = new DataSet();



                switch (cb.Text)
                {
                    case "Logins":
                    ds = proxy.ViewAll(Table.Logins);
                        break;

                    case "Person":
                    ds = proxy.ViewAll(Table.Person);
                    break;

                   case "Relationship":
                    ds = proxy.ViewAll(Table.Relationship);
                    break;

                    case "Intrest":
                      ds = proxy.ViewAll(Table.Interest);
                    break;

                    case "Industry":
                        ds = proxy.ViewAll(Table.Industry); 
                           break;

                     case "Education":
                         ds = proxy.ViewAll(Table.Logins);
                            break;

                        }

                        dataGridViewData.DataSource = ds.Tables[0];
                    }
            }
        }























