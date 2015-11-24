using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace DigitsOperations
{
    class Operations
    {
        public static int CountDigits(int number)
        {
            number = Math . Abs(number);
            int counter = 0;
            while (number>0)
            {
                counter++;
                number /= 10;
            }
            return counter;
        }

        public static int SumDigits(int number)
        {
            number = Math . Abs(number);
            int sum = 0;
            while (number>0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        public static int FactWithRec ( int number )
        {
            if (number <= 0)
            {
                return 1;
            }
            return number * FactWithRec(number - 1);
        }

        public static int FactorialDigits(int number)
        {
            number = Math . Abs(number);
            int result = 0;
            while (number>0)
            {
                result += FactWithRec(number % 10);
                number /= 10;
            }
            return result;
        }
        static void Main ( string[] args )
        {
            int number = int . Parse(Console.ReadLine());
            Console . WriteLine(CountDigits(number));
            Console . WriteLine(SumDigits(number));
            Console . WriteLine(FactorialDigits(number));
            Console . ReadKey();
        }
    }
}
