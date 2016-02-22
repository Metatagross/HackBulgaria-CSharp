using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    class ClockAngleTest
    {
        public static int GetClockHandsAngle ( DateTime time )
        {
            return (int)Math.Abs(0.5 * (60 * time.Hour - 11 * time.Minute))%360;
        }
        static void Main ( string[] args )
        {
            Console.WriteLine(GetClockHandsAngle(new DateTime(2014 , 2 , 5 , 12 , 00 , 00)));
            Console.WriteLine(GetClockHandsAngle(new DateTime(2014 , 2 , 5 , 15 , 10 , 00)));
            Console.WriteLine(GetClockHandsAngle(new DateTime(2014 , 2 , 5 , 16 , 00 , 00)));
            Console.WriteLine(GetClockHandsAngle(new DateTime(2014 , 2 , 5 , 20 , 10 , 00)));
            Console.WriteLine(GetClockHandsAngle(new DateTime(2014 , 2 , 5 , 22 , 30 , 00)));
            Console.ReadKey();
        }
    }
}
