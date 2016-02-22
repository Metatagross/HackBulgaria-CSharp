using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class Bill
    {
        private int amountOfBill;
        public Bill(int bill)
        {
            AmountOfBill = bill; 
        }

        public int AmountOfBill
        {
            get
            {
                return amountOfBill;
            }

            set
            {
                amountOfBill = value;
            }
        }
        public override string ToString ( )
        {
            return string.Format("{0:C}",AmountOfBill);
        }
        public override bool Equals ( object obj )
        {
            if(obj==null||!(obj is Bill))
            {
                return false;
            }
            Bill newBill = (Bill)obj;
            return AmountOfBill==newBill.AmountOfBill;
        }

        public override int GetHashCode ( )
        {
            return AmountOfBill.GetHashCode();
        }
        public static bool operator==(Bill bill1, object bill2)
        {
            return bill1.Equals(bill2);
        }
        public static bool operator!=(Bill bill1, object bill2)
        {
            return !bill1.Equals(bill2);
        }
        public static explicit operator int(Bill bill1)
        {
            return bill1.AmountOfBill;
        }
    }
}
