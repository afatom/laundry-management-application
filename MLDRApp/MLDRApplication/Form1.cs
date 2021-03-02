using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace MLDRApplication
{
    /*
    public class ErrorMsgWindow
    {
        public static void f_application_raiseErrorMsg(string msg)
        {
            return;
        }
    }*/
    
    public partial class Form_MLDR_Application : Form
    {
        public Form_MLDR_Application()
        {

            InitializeComponent();
            //Console.OutputEncoding = Encoding.GetEncoding("Windows-1255");
            List<Customer> CustomersList;
            ExcelReader.ExcelReadergetCustomers(@"C: \Users\fares\OneDrive\Documents\customersInitValues.xlsx");
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //כפתור צור הזמנה
        private void button1_Click(object sender, EventArgs e)
        {
            List<LaundryUnit> LaundryUnitsList = new List<LaundryUnit>();
            List<Customer> CustomersList = new List<Customer>();
            Customer eli = new Customer("axel", "rose", "0585095050", "zefat", 6);
            Customer hadeel = new Customer("hadeel", "faris", "0585095050", "zefat", 6);
            Customer adham = new Customer("אדהם", "פארס", "0585095050", "zefat", 7);
            Customer rami = new Customer("רמי", "רמי", "0585095050", "zefat", 6);

            CustomersList.Add(eli);
            CustomersList.Add(adham);
            CustomersList.Add(hadeel);
            CustomersList.Add(rami);

            Carpet carp = new Carpet(40, 60);
            Dress dres = new Dress(80, 200);
            MenSuit suit = new MenSuit(120, 150);
            MixLaundry mix = new MixLaundry(0, 0);
            LaundryUnitsList.Add(carp);
            LaundryUnitsList.Add(dres);
            LaundryUnitsList.Add(suit);
            LaundryUnitsList.Add(mix);

            FormOrder order = new FormOrder(LaundryUnitsList, CustomersList,this);
            order.Show();
            this.Hide();
        }

        //constructs customers list (all known customers) for sending this list to formOrder ctor
        //to be shown in comboBoxOrderingCustomer
        //this function parses the 
        private List<Customer> f_orderCreate_buildCustomersList()
        {
            List<Customer> customersList = new List<Customer>();
            return customersList;
        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //do some stuff like saving and flashing files and itc...
            //{................}
            //
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //do some stuff befor restart....
            this.Close();
        }

        private void buttonAppendCustomer_Click(object sender, EventArgs e)
        {
            CustomerAppendForm caf = new CustomerAppendForm(this);
            caf.Show();
            this.Hide();
        }
    }
}
