using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace NumberListConvert
{
    class Convertions
    {
        public static List<int> NumberToList(int number)
        {
            List<int> result = new List<int>();
            while (number>0)
            {
                result . Add(number % 10);
                number /= 10;
            }
            result.Reverse();
            return result;
        }

        public static int ListToNumber(List<int> listOfDigits)
        {
            int result=0;
            for (int i = 0 ; i < listOfDigits.Count ; i++)
            {
                result += listOfDigits[i] * (int)Math . Pow(10 , listOfDigits.Count-i-1);
            }
            return result;
        }

        static void Main ( string[] args )
        {
            int number = int . Parse(Console . ReadLine());
            foreach (var item in NumberToList(number))
            {
                Console . Write(item);
            }
            Console . WriteLine();
            Console . WriteLine(ListToNumber(NumberToList(number)));
            Console . ReadKey();
        }
    }
}
