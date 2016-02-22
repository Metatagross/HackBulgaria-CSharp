using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class CashDesk
    {
        private SortedDictionary<int , int> money;
        public CashDesk ( )
        {
            money = new SortedDictionary<int , int>();
        }
        public void TakeMoney ( Bill b )
        {
            if(!money.Keys.Contains((int)b))
            {
                money.Add((int)b , 0);
            }
            money[(int)b]++;
        }
        public void TakeMoney ( BatchBill batch )
        {
            foreach(Bill item in batch)
            {
                if(!money.Keys.Contains((int)item))
                {
                    money.Add((int)item , 0);
                }
                money[item.AmountOfBill]++;
            }
        }
        public int Total ( )
        {
            int result = 0;
            foreach(var item in money)
            {
                result += item.Key * item.Value;
            }
            return result;
        }
        public void Inspect ( )
        {
            Console.WriteLine("We have a total of {0:C} in the desk" , Total());
            Console.WriteLine("We have the following count of bills, sorted in ascending order:");
            foreach(var item in money)
            {
                Console.WriteLine("{0:C} bills - {1}" , item.Key , item.Value);
            }
        }
    }
}
