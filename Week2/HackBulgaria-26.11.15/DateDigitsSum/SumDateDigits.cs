using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDigitsSum
{
    class SumDateDigits
    {
        public static void PrintDateWithGivenSum ( int year , int sum )
        {
            DateTime start = new DateTime(year , 01 , 01);
            int yearSum = +start.Year % 10 + (start.Year / 10) % 10
                     + start.Year / 100 % 10 + start.Year / 1000;
            while(start.Year <= year)
            {
                int maxSum = start.Day / 10 + start.Day % 10 + start.Month / 10 + start.Month % 10 + yearSum;
                if(maxSum==sum)
                {
                    Console.WriteLine(start.ToString("dd MM yyyy" , new CultureInfo("bg-BG")));
                }
                maxSum = 0;
                start=start.AddDays(1);
            }
        }
        static void Main ( string[] args )
        {
            PrintDateWithGivenSum(2014 , 15);
            Console.ReadKey();
        }
    }
}
