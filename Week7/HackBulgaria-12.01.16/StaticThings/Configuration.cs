using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticThings
{
    public static class Configuration
    {
        private static readonly char ReplacingValue;
        static Configuration ( )
        {
            DateTime dateNow = DateTime.Now;
            ReplacingValue = (char)((sumDigits(dateNow.Year)
                + sumDigits(dateNow.Month)
                + sumDigits(dateNow.Day) 
                + sumDigits(dateNow.Hour) 
                + sumDigits(dateNow.Minute) 
                + sumDigits(dateNow.Second))%25+65);

        }
        public static char GetReplacingValue()
        {
            return ReplacingValue;
        }
        private static int sumDigits ( int number )
        {
            int result = 0;
            while(number > 0)
            {
                result += number % 10;
                number /= 10;
            }
            return result;
        }
    }
}
