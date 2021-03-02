using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLDRApplication
{
    public class LaundryType
    {
        private string m_laundryType;
        private uint m_laundryCost;

        public string LaundryUnitType
        {
            get { return m_laundryType; }
            set { m_laundryType = value; }
        }

        public uint LaundryUnitCost
        {
            get { return m_laundryCost; }
            set { m_laundryCost = value; }
        }

        public LaundryType(string _laundryType, uint _laundryCost)
        {
            this.m_laundryType = _laundryType;
            this.m_laundryCost = _laundryCost;
        }

        public override string ToString()
        {
            string output = "";
            output = "LaundryType: " + LaundryUnitType + " " + LaundryUnitCost;
            return output;
        }
    }
}
