using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLDRApplication
{
    public enum LaundryUnitNames
    {
        E_LUN_= 0,

    }
    public class LaundryUnit
    {
        private string m_name;
        private uint m_washingPrice;
        private uint m_washingAndIroningPrice;

        public LaundryUnit(uint _washingPrice, uint _washingAndIroningPrice, string _name)
        {
            this.m_name = _name;
            this.m_washingPrice = _washingPrice;
            this.m_washingAndIroningPrice = _washingAndIroningPrice;
        }
        public uint WashingPrice
        {
            get { return this.m_washingPrice; }
            set { this.m_washingPrice = value; }
        }

        public uint WashingAndIroningPrice
        {
            get { return this.m_washingAndIroningPrice; }
            set { this.m_washingAndIroningPrice = value; }
        }

        public string Name
        {
            get { return this.m_name; }
            set { this.m_name = value; }
        }

        public override string ToString()
        {
            string retval = "";
            retval += string.Format("[Name,Washing,WashingAndIroning]=[{0},{1},{2}]", this.m_name, this.m_washingPrice, this.m_washingAndIroningPrice);
            return retval;
        }
    }

    class Other : LaundryUnit
    {
        public Other(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "אחר")
        { }
    }

    class SofaSeat : LaundryUnit //מושב ספה
    {
        public SofaSeat(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "מושב ספה")
        { }

    }

    class Pillow: LaundryUnit //כרית
    {
        public Pillow(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "כרית")
        { }
    }

    class DoubleBlanket: LaundryUnit
    {
        public DoubleBlanket(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "שמיכה זוגית")
        { }
    }

    class SingleBlanket: LaundryUnit
    {
        public SingleBlanket(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "שמיכת יחיד")
        { }
    }

    class PoochBlanket : LaundryUnit
    {
        public PoochBlanket(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "שמיכת פוך")
        { }
    }

    class SummerBlanket : LaundryUnit
    {
        public SummerBlanket(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "שמיכת קיץ")
        { }
    }

    class WinterBlanket : LaundryUnit
    {
        public WinterBlanket(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "שמיכת חורף")
        { }
    }

    class TshirtOrTrousers : LaundryUnit
    {
        public TshirtOrTrousers(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "חולצה או מכנס")
        { }
    }

    class Coat : LaundryUnit //מעיל
    {
        public Coat(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "מעיל")
        { }
    }
    
    class Dress : LaundryUnit//שמלה
    {
        public Dress(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "שמלה")
        { }
    }

    class BrideDress : LaundryUnit
    {
        public BrideDress(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "שמלת כלה")
        { }
    }

    class EveningDress : LaundryUnit
    {
        public EveningDress(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "שמלת ערב")
        { }
    }

    class MenSuit : LaundryUnit
    {
        public MenSuit(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "חליפת גבר")
        { }
    }

    class BedCover : LaundryUnit
    {
        public BedCover(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "כיסוי מיטה")
        { }
    }

    class PrivateLaundry : LaundryUnit
    {
        public PrivateLaundry(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "כביסה פרטית")
        { }
    }

    class MinimumLaundry : LaundryUnit
    {
        public MinimumLaundry(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "כביסת מינימום")
        { }
    }

    class Curtain : LaundryUnit//"וילון"
    {
        public Curtain(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "וילון")
        { }
    }

    class Carpet : LaundryUnit//שטיח
    {
        public Carpet(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "שטיח")
        { }
    }

    class MixLaundry : LaundryUnit
    {
        public MixLaundry(uint _washingPrice, uint _washingAndIroningPrice) : base(_washingPrice, _washingAndIroningPrice, "כביסה מעורבת")
        { }
    }
}
