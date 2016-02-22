using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker1337
{
    class Program
    {
        public static void HackerTime ( )
        {
            DateTime hackerDate = new DateTime(DateTime.Now.Year , 12 , 21 , 13 , 37 , 0);
            if(hackerDate<DateTime.Now)
            {
                hackerDate.AddYears(1);
            }
            TimeSpan diff = hackerDate.Subtract(DateTime.Now);
            Console.WriteLine(diff);
        }
        static void Main ( string[] args )
        {
            HackerTime();
            Console.ReadKey();
        }
    }
}
