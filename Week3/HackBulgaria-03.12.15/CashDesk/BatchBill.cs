using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class BatchBill : IEnumerable
    {
        List<Bill> bills;

        public BatchBill ( List<Bill> newBills )
        {
            Bills = newBills;
        }
        public BatchBill ( Bill[] bills ) : this(bills.ToList())
        { }
        public List<Bill> Bills
        {
            get
            {
                return bills;
            }

            set
            {
                bills = value;
            }
        }
        public int Count
        {
            get
            {
                return Bills.Count;
            }
        }
        public int Total ( )
        {
            int result = 0;
            foreach(var item in Bills)
            {
                result += (int)item;
            }
            return result;
        }
        public override string ToString ( )
        {
            return string.Format("{0} bills with {1} total value." , Count , Total());
        }

        public IEnumerator GetEnumerator ( )
        {
            return ((IEnumerable)Bills).GetEnumerator();
        }
    }
}
