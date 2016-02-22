using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class CalendarTest
    {
        public static void PrintCalendar ( int month , int year , CultureInfo culture )
        {
            DateTime start = new DateTime(year , month , 01 , culture.Calendar);
            Dictionary<string , List<int>> monthCalendar = new Dictionary<string , List<int>>();
            Console.WriteLine(start.ToString("MMMM" , culture));
            while(start.Month == month)
            {
                if(!monthCalendar.Keys.Contains(culture.DateTimeFormat.GetDayName(start.DayOfWeek)))
                {
                    monthCalendar.Add(culture.DateTimeFormat.GetDayName(start.DayOfWeek) , new List<int> { });
                }
                
                monthCalendar[culture.DateTimeFormat.GetDayName(start.DayOfWeek)].Add(start.Day);
                start = start.AddDays(1);
            }
            foreach(var item in monthCalendar.Keys)
            {
                Console.Write("{0,10}" , item.ToString());
            }
            Console.WriteLine();
            for(int i = 0 ; i < 5 ; i++)
            {
                foreach(var item in monthCalendar.Keys)
                {
                    if(i > monthCalendar[item].Count - 1)
                    {
                        Console.Write("{0,10}" , " ");
                    }
                    else
                    {
                        Console.Write("{0,10}" , monthCalendar[item][i]);
                    }
                }
                Console.WriteLine();
            }

        }
        static void Main ( string[] args )
        {
            PrintCalendar(5 , 2015 , new CultureInfo("bg-BG"));
            Console.ReadKey();
        }
    }
}
