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
    public partial class FormOrder : Form
    {
        public Form m_master;
        private List<Customer> m_customers;
        private List<LaundryUnit> m_laundryUnitsList;
        private List<List<string>> m_orderData = new List<List<string>>();
        //private List<string> m_rowOneData;
        //private List<string> m_rowTwoData;
        //private List<string> m_rowThreeData;
        //private List<string> m_rowFourData;
        //private List<string> m_rowFiveData;
        //private List<string> m_rowSixData;
        //private List<string> m_rowSevenData;

        public FormOrder(List<LaundryUnit> laundryUnitsList, List<Customer> customersList, Form master)
        {
            this.m_master = master;
            this.m_customers = customersList;
            this.m_laundryUnitsList = laundryUnitsList;
            InitializeComponent();
            //Initialize all Order form combo boxes
            this.f_formOrder_initComboBoxOrderingCustomer();
            this.f_formOrder_initComboBoxTypeRowOne();
            this.f_formOrder_initComboBoxTypeRowTwo();
            this.f_formOrder_initComboBoxTypeRowThree();
            this.f_formOrder_initComboBoxTypeRowFour();
            this.f_formOrder_initComboBoxTypeRowFive();
            this.f_formOrder_initComboBoxTypeRowSix();
            this.f_formOrder_initComboBoxTypeRowSeven();
            this.f_formOrder_initComboBoxOpRowOne();
            this.f_formOrder_initComboBoxOpRowTwo();
            this.f_formOrder_initComboBoxOpRowThree();
            this.f_formOrder_initComboBoxOpRowFour();
            this.f_formOrder_initComboBoxOpRowFive();
            this.f_formOrder_initComboBoxOpRowSix();
            this.f_formOrder_initComboBoxOpRowSeven();
        }

        //Init Ordering Customer for current order
        private void f_formOrder_initComboBoxOrderingCustomer()
        {
            foreach (Customer value in this.m_customers)
            {
                string fullName = value.FirstName + " " + value.LastName;
                comboBoxOrderingCustomer.Items.Add(fullName);
            }
        }

        //Init laundry units or types at row 1
        private void f_formOrder_initComboBoxTypeRowOne()
        {
            foreach (LaundryUnit value in this.m_laundryUnitsList)
            {
                comboBoxTypeRowOne.Items.Add(value.Name);
            }
        }

        //Init laundry units or types at row 2
        private void f_formOrder_initComboBoxTypeRowTwo()
        {
            foreach (LaundryUnit value in this.m_laundryUnitsList)
            {
                comboBoxTypeRowTwo.Items.Add(value.Name);
            }
        }

        //Init laundry units or types at row 3
        private void f_formOrder_initComboBoxTypeRowThree()
        {
            foreach (LaundryUnit value in this.m_laundryUnitsList)
            {
                comboBoxTypeRowThree.Items.Add(value.Name);
            }
        }

        //Init laundry units or types at row 4
        private void f_formOrder_initComboBoxTypeRowFour()
        {
            foreach (LaundryUnit value in this.m_laundryUnitsList)
            {
                comboBoxTypeRowFour.Items.Add(value.Name);
            }
        }

        //Init laundry units or types at row 5
        private void f_formOrder_initComboBoxTypeRowFive()
        {
            foreach (LaundryUnit value in this.m_laundryUnitsList)
            {
                comboBoxTypeRowFive.Items.Add(value.Name);
            }
        }

        //Init laundry units or types at row 6
        private void f_formOrder_initComboBoxTypeRowSix()
        {
            foreach (LaundryUnit value in this.m_laundryUnitsList)
            {
                comboBoxTypeRowSix.Items.Add(value.Name);
            }
        }

        //Init laundry units or types at row 7
        private void f_formOrder_initComboBoxTypeRowSeven()
        {
            foreach (LaundryUnit value in this.m_laundryUnitsList)
            {
                comboBoxTypeRowSeven.Items.Add(value.Name);
            }
        }

        //Init service or laundry operation at row 1
        private void f_formOrder_initComboBoxOpRowOne()
        {
            comboBoxOpRowOne.Items.Add("כביסה");
            comboBoxOpRowOne.Items.Add("כביסה וגיהוץ");
        }

        //Init service or laundry operation at row 2
        private void f_formOrder_initComboBoxOpRowTwo()
        {
            comboBoxOpRowTwo.Items.Add("כביסה");
            comboBoxOpRowTwo.Items.Add("כביסה וגיהוץ");
        }

        //Init service or laundry operation at row 3
        private void f_formOrder_initComboBoxOpRowThree()
        {
            comboBoxOpRowThree.Items.Add("כביסה");
            comboBoxOpRowThree.Items.Add("כביסה וגיהוץ");
        }

        //Init service or laundry operation at row 4
        private void f_formOrder_initComboBoxOpRowFour()
        {
            comboBoxOpRowFour.Items.Add("כביסה");
            comboBoxOpRowFour.Items.Add("כביסה וגיהוץ");
        }

        //Init service or laundry operation at row 5
        private void f_formOrder_initComboBoxOpRowFive()
        {
            comboBoxOpRowFive.Items.Add("כביסה");
            comboBoxOpRowFive.Items.Add("כביסה וגיהוץ");
        }

        //Init service or laundry operation at row 6
        private void f_formOrder_initComboBoxOpRowSix()
        {
            comboBoxOpRowSix.Items.Add("כביסה");
            comboBoxOpRowSix.Items.Add("כביסה וגיהוץ");
        }

        //Init service or laundry operation at row 7
        private void f_formOrder_initComboBoxOpRowSeven()
        {
            comboBoxOpRowSeven.Items.Add("כביסה");
            comboBoxOpRowSeven.Items.Add("כביסה וגיהוץ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_FormOrder_OrderNumberOut_Click(object sender, EventArgs e)
        {
         
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_master.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private uint OrderCalculateRow(uint quantity, string laundryUnit, string service, string customerId)
        {
            uint total = 0;
            if (laundryUnit == "כביסה מעורבת")
            {
                //calculation in Kg per customer
                string fullname = "";
                foreach (Customer customer in this.m_customers)
                {
                    fullname = customer.FirstName + " " + customer.LastName; 
                    if(fullname == customerId)
                    {
                        total = quantity * customer.PricePerKilogram;
                        break;
                    }
                }
            }
            else
            {
                foreach(LaundryUnit unit in this.m_laundryUnitsList)
                {
                    if(unit.Name == laundryUnit)
                    {
                        if(service == "כביסה")
                        {
                            total = quantity * unit.WashingPrice;
                        }
                        else
                        {
                            total = quantity * unit.WashingAndIroningPrice;
                        }
                    }
                }
            }
            return total;
        }

        private void button_CalcOrder_Click(object sender, EventArgs e)
        {
            string customerFullName = comboBoxOrderingCustomer.Text;
            float rowOneCost = f_formOrder_getRowCost(1, customerFullName);
            float rowTwoCost = f_formOrder_getRowCost(2, customerFullName);
            float rowThreeCost = f_formOrder_getRowCost(3, customerFullName);
            float rowFourCost = f_formOrder_getRowCost(4, customerFullName);
            float rowFiveCost = f_formOrder_getRowCost(5, customerFullName);
            float rowSixCost = f_formOrder_getRowCost(6, customerFullName);
            float rowSevenCost = f_formOrder_getRowCost(7, customerFullName);
            float orderTotalCost = rowOneCost + rowTwoCost + rowThreeCost + rowFourCost + rowFiveCost + rowSixCost + rowSevenCost;
            labelTotCostRowOne.Text = rowOneCost.ToString();
            labelTotCostRowTwo.Text = rowTwoCost.ToString();
            labelTotCostRowThree.Text = rowThreeCost.ToString();
            labelTotCostRowFour.Text = rowFourCost.ToString();
            labelTotCostRowFive.Text = rowFiveCost.ToString();
            labelTotCostRowSix.Text = rowSixCost.ToString();
            labelTotCostRowSeven.Text = rowSevenCost.ToString();
            labelTotOrderWithOutVat.Text = orderTotalCost.ToString();
            labelVatPercent.Text = "17%";
            labelTotOrderWithVat.Text = (orderTotalCost * 1.17).ToString();
        }

        private float f_formOrder_calculateRowCost(uint quantity, string laundryType, string serviceOperation, string customerFullName)
        {
            uint total = 0;
            if (laundryType == "כביסה מעורבת")
            {
                //calculation in Kg per customer
                string fullname = "";
                foreach (Customer customer in this.m_customers)
                {
                    fullname = customer.FirstName + " " + customer.LastName;
                    if (fullname == customerFullName)
                    {
                        total = quantity * customer.PricePerKilogram;
                        break;
                    }
                }
            }
            else
            {
                foreach (LaundryUnit unit in this.m_laundryUnitsList)
                {
                    if (unit.Name == laundryType)
                    {
                        if (serviceOperation == "כביסה")
                        {
                            total = quantity * unit.WashingPrice;
                        }
                        else
                        {
                            total = quantity * unit.WashingAndIroningPrice;
                        }
                    }
                }
            }
            return total;
        }
        

        private float f_formOrder_getRowCost(uint row, string customerFullName)
        {
            if(row == 1) 
            {
                int quantity = Int32.Parse(textBoxQuantRowOne.Text);
                string laundryType = comboBoxTypeRowOne.Text;
                string serviceOperation = comboBoxOpRowOne.Text;
                return this.f_formOrder_calculateRowCost((uint)quantity, laundryType, serviceOperation, customerFullName);
            }
            else if(row == 2)
            {
                int quantity = Int32.Parse(textBoxQuantRowTwo.Text);
                string laundryType = comboBoxTypeRowTwo.Text;
                string serviceOperation = comboBoxOpRowTwo.Text;
                return this.f_formOrder_calculateRowCost((uint)quantity, laundryType, serviceOperation, customerFullName);
            }
            else if (row == 3)
            {
                int quantity = Int32.Parse(textBoxQuantRowThree.Text);
                string laundryType = comboBoxTypeRowThree.Text;
                string serviceOperation = comboBoxOpRowThree.Text;
                return this.f_formOrder_calculateRowCost((uint)quantity, laundryType, serviceOperation, customerFullName);
            }
            else if (row == 4)
            {
                int quantity = Int32.Parse(textBoxQuantRowFour.Text);
                string laundryType = comboBoxTypeRowFour.Text;
                string serviceOperation = comboBoxOpRowFour.Text;
                return this.f_formOrder_calculateRowCost((uint)quantity, laundryType, serviceOperation, customerFullName);
            }
            else if (row == 5)
            {
                int quantity = Int32.Parse(textBoxQuantRowFive.Text);
                string laundryType = comboBoxTypeRowFive.Text;
                string serviceOperation = comboBoxOpRowFive.Text;
                return this.f_formOrder_calculateRowCost((uint)quantity, laundryType, serviceOperation, customerFullName);                          
            }
            else if (row == 6)
            {
                int quantity = Int32.Parse(textBoxQuantRowSix.Text);
                string laundryType = comboBoxTypeRowSix.Text;
                string serviceOperation = comboBoxOpRowSix.Text;
                return this.f_formOrder_calculateRowCost((uint)quantity, laundryType, serviceOperation, customerFullName);
            }
            else
            {
                int quantity = Int32.Parse(textBoxQuantRowSeven.Text);
                string laundryType = comboBoxTypeRowSeven.Text;
                string serviceOperation = comboBoxOpRowSeven.Text;
                return this.f_formOrder_calculateRowCost((uint)quantity, laundryType, serviceOperation, customerFullName);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void labelRow1TotakCost_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox_quantityRow_2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
