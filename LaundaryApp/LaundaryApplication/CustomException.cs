using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundaryApplication
{
    public partial class CustomException : SystemException
    {
        private string thrownClass;
        private string thrownfn;
        private string msg;
        
        public string ThrownClass
        {
            get { return thrownClass; }
            set { thrownClass = value; }
        }

        public string ThrownFunction
        {
            get { return thrownfn; }
            set { thrownfn = value; }
        }

        public string Message
        {
            get { return msg; }
            set { msg = value; }
        }

        public CustomException(string _thrownClass, string _thrownFunction, string _msg = "")
        {
            thrownClass = _thrownClass;
            thrownfn = _thrownFunction;
            msg = _msg;
        }

        public override string ToString()
        {
            string output = "";
            output += String.Format("{0}:{1}:<\"{2}\">", thrownClass, thrownfn, msg);
            return output;
        }

    }
}
