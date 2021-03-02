using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLDRApplication
{
    public class Customer
    {
        private string m_customerFirstName;
        private string m_customerLastName;
        private string m_customerPhoneNumberOne;
        private string m_customerPhoneNumberTwo;
        private string m_customerEmailAddress;
        private string m_customerFaxNumber;
        private string m_customerAddress;
        private bool m_customerIsPremium;
        private uint m_customerPricePerKilogram;

        public string FirstName
        {
            get { return m_customerFirstName; }
            set { m_customerFirstName = value; }
        }

        public string LastName
        {
            get { return m_customerLastName; }
            set { m_customerLastName = value; }
        }

        public string PhoneNumberOne
        {
            get { return m_customerPhoneNumberOne; }
            set { m_customerPhoneNumberOne = value; }
        }

        public string PhoneNumberTwo
        {
            get { return m_customerPhoneNumberTwo; }
            set { m_customerPhoneNumberTwo = value; }
        }

        public string EmailAddress
        {
            get { return m_customerEmailAddress; }
            set { m_customerEmailAddress = value; }
        }

        public string FaxNumber
        {
            get { return m_customerFaxNumber; }
            set { m_customerFaxNumber = value; }
        }

        public string Address
        {
            get { return m_customerAddress; }
            set { m_customerAddress = value; }
        }

        public bool isPremium
        {
            get { return m_customerIsPremium; }
            set { m_customerIsPremium = value; }
        }

        public uint PricePerKilogram
        {
            get { return m_customerPricePerKilogram; }
            set { m_customerPricePerKilogram = value; }
        }

        //CTOR
        public Customer(string _fisrtName, string _lastName, string _phoneNumberOne, string _address, 
            uint _pricePerKilogram, string _phoneNumberTwo="N.E", string _emailAdress="N.E",
            string _faxNumber="N.E", bool _isPremium = false
             )
        {
            this.m_customerFirstName = _fisrtName;
            this.m_customerLastName = _lastName;
            this.m_customerPhoneNumberOne = _phoneNumberOne;
            this.m_customerAddress = _address;
            this.m_customerPricePerKilogram = _pricePerKilogram;
            this.m_customerPhoneNumberTwo = _phoneNumberTwo;
            this.m_customerEmailAddress = _emailAdress;
            this.m_customerFaxNumber = _faxNumber;
            this.m_customerIsPremium = _isPremium;
        }

        //ToString
        public override string ToString()
        {
            string output = "";
            output += String.Format("Customer: {0} {1}, {2}, {3}", this.m_customerLastName, 
                LastName, FirstName, PhoneNumberOne,Address);
            return output;
        }
    }
}