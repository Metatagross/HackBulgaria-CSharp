using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class Bill<T> where T : struct
    {
        private T amountOfBill;
        public Bill ( T bill )
        {
            AmountOfBill = bill;
        }

        public T AmountOfBill
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
            return string.Format("{0:C}" , AmountOfBill);
        }
        public override bool Equals ( object obj )
        {
            if(obj == null || !(obj is Bill<T>))
            {
                return false;
            }
            Bill<T> newBill = (Bill<T>)obj;
            return AmountOfBill.Equals(newBill.AmountOfBill);
        }

        public override int GetHashCode ( )
        {
            return AmountOfBill.GetHashCode();
        }
        public static bool operator ==( Bill<T> bill1 , object bill2 )
        {
            return bill1.Equals(bill2);
        }
        public static bool operator !=( Bill<T> bill1 , object bill2 )
        {
            return !bill1.Equals(bill2);
        }
        public static explicit operator T ( Bill<T> bill1 )
        {
            return bill1.AmountOfBill;
        }
    }
}
