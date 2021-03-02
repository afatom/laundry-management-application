using System;

namespace LaundaryApplication
{
    class Customer
    {
        private string fname;
        private string lname;
        private string email;
        private string phone;
        private bool isPremium = false;
        private int rebatePercentage = 0;

        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }

        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }

        public string EmailAddress
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phone; }
            set { phone = value; }
        }

        public bool IsPremiumCustomer
        {
            get { return isPremium; }
            set { isPremium = value; }
        }

        public int CustomerRebatePercentage
        {
            get { return rebatePercentage; }
            set { rebatePercentage = value; }
        }
        
        public Customer(string _fname, string _lname, bool _isprem = false,
            string _email = "___@___.com", string _phone = "000", int _rebPer = 0)
        {
            if (_fname.Length == 0 || _lname.Length == 0)
            {
                Exception ex = new Exception();
                throw ex;
            }
            fname = _fname;
            lname = _lname;
            isPremium = _isprem;
            email = _email;
            phone = _phone;
            rebatePercentage = _rebPer;
        }
    }
}
