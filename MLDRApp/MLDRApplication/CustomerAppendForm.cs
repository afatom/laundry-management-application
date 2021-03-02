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
    enum E_INPUT
    {
        E_FIRST_NAME=0,
        E_LAST_NAME,
        E_PHONE_ONE,
        E_PHONE_TWO,
        E_FAX,
        E_CITY,
        E_STREET,
        E_MAIL,
        E_KG_COST,
        E_LAST_INPUT
    }
    public partial class CustomerAppendForm : Form
    {
        public Form m_master;
        private string m_firstName;
        private string m_lastName;
        private string m_phoneOne;
        private string m_phoneTwo;
        private string m_fax;
        private string m_city;
        private string m_street;
        private string m_mail;
        private string m_kilogramCost;
        private bool m_isSaved;
        private bool m_isMandatoryFields; //is user insert the minimum fields for customer creation or not
        private bool m_isValidInputs;
        public CustomerAppendForm(Form master /*//fileIO*/)
        {
            this.m_master = master;
            this.m_isSaved = false;
            this.m_isMandatoryFields = false;
            this.m_isValidInputs = false;
            InitializeComponent();
        }

        private void CustomerAppendForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool[] inputsValidityArr = new bool[9] { false, false, false, false, false, false, false, false, false};
            this.f_customerAppendForm_validateUserInputs(inputsValidityArr);
            if (this.m_isMandatoryFields && this.m_isValidInputs)
            {
                //save to file that we get in the ctor
                this.m_isSaved = true;
            }
            else
            {
                //throw message that minimum fields is not inserted yet
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if(this.m_isSaved)
            {
                this.Hide();
                this.m_master.Show();
            }
            else
            {
                //here maybe they forget to save before exit
                //so we need to throw window message with the options //back without save, save and back
                //currently we just go back
                this.Hide();
                this.m_master.Show();
            }
            
        }

        private void f_customerAppendForm_validateUserInputs(bool[] userInputsValidity)
        {
            //validate all text boxes, all user inputs
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            this.m_firstName = textBoxFirstName.Text;
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            this.m_lastName = textBoxLastName.Text;
        }

        private void textBoxFirstPhone_TextChanged(object sender, EventArgs e)
        {
            this.m_phoneOne = textBoxFirstPhone.Text;
        }

        private void textBoxSecondPhone_TextChanged(object sender, EventArgs e)
        {
            this.m_phoneTwo = textBoxSecondPhone.Text;
        }

        private void textBoxFax_TextChanged(object sender, EventArgs e)
        {
            this.m_fax = textBoxFax.Text;
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            this.m_city = textBoxCity.Text;
        }

        private void textBoxStreet_TextChanged(object sender, EventArgs e)
        {
            this.m_street = textBoxStreet.Text;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            this.m_mail = textBoxEmail.Text;
        }

        private void textBoxKilogramCost_TextChanged(object sender, EventArgs e)
        {
            this.m_kilogramCost = textBoxKilogramCost.Text;
        }
    }
}
