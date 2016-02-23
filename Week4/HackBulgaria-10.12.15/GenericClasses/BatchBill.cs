using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class BatchBill<T> : IEnumerable
        where T :struct
    {
        List<Bill<T>> bills;

        public BatchBill ( List<Bill<T>> newBills )
        {
            Bills = newBills;
        }
        public BatchBill ( Bill<T>[] bills ) : this(bills.ToList())
        { }
        public List<Bill<T>> Bills
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
        //Here we have a problem we will solve when we take Interfaces!
        public T Total ( )
        {
            T result = default(T);
            foreach(var item in Bills)
            {
                result = (T)item;
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
