using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnfortunateFridays
{
    class UFridaysTest
    {
        public static int UnfortunateFridays ( int startYear , int endYear )
        {
            if(startYear>endYear)
            {
                int temp = startYear;
                startYear = endYear;
                endYear = temp;
            }
            DateTime start = new DateTime(startYear,1,13);
            int counter = 0;
            while(start.Year <= endYear)
            {
                if(start.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    counter++;
                    Console.WriteLine(start.ToString("dd MM yyyy",new CultureInfo("bg-BG")));
                }
                start = start.AddMonths(1);
            }
            return counter;
        }
        static void Main ( string[] args )
        {
            Console.WriteLine(UnfortunateFridays(2015 , 2016));
            Console.ReadKey();
        }
    }
}
