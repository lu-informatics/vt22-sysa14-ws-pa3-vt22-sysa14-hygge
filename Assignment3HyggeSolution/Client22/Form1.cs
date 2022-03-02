using HyggeService;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;



namespace Client22
{
    public partial class Form1 : Form
    {
        private static HyggeServiceSoapClient.EndpointConfiguration config = HyggeServiceSoapClient.EndpointConfiguration.HyggeServiceSoap;
        private HyggeServiceSoapClient proxy = new HyggeServiceSoapClient(config);
        public Form1()
        {

            InitializeComponent();
            comboBoxValue.Items.Clear();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxValue.Items.Add("Person");
            comboBoxValue.Items.Add("Login");
            comboBoxValue.Items.Add("Relationship");
            comboBoxValue.Items.Add("Interest");
            comboBoxValue.Items.Add("Education");
            comboBoxValue.Items.Add("Industry");
            comboBoxValue.Items.Add("EducationIndustry");

        }

        private void comboBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {


            ComboBox cb = sender as ComboBox;

            ArrayOfXElement ds = null;

            switch (cb.Text)
            {
                case "Login":
                    ds = proxy.ViewAll("Login");
                    break;

                case "Person":
                    ds = proxy.ViewAll("Person");
                    break;

                case "Relationship":
                    ds = proxy.ViewAll("Relationship");
                    break;

                case "Interest":
                    ds = proxy.ViewAll("Interest");
                    break;

                case "Industry":
                    ds = proxy.ViewAll("Industry");
                    break;

                case "Education":
                    ds = proxy.ViewAll("Education");
                    break;
                case "EducationIndustry":
                    ds = proxy.ViewAll("EducationIndustry");
                    break;

            }

            
            dataGridViewData.DataSource = ToDataSet(ds).Tables[0];    
        }

        public DataSet ToDataSet(ArrayOfXElement arrayOfXElement) //konverterar från ArrayOfXElements till DataSet
        {
            var strSchema = arrayOfXElement.Nodes[0].ToString();
            var strData = arrayOfXElement.Nodes[1].ToString();
            var strXml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n\t<DataSet>";
            strXml += strSchema + strData;
            strXml += "</DataSet>";

            DataSet ds = new DataSet("TestDataSet");
            ds.ReadXml(new MemoryStream(Encoding.UTF8.GetBytes(strXml)));

            return ds;
        }
    }
}























