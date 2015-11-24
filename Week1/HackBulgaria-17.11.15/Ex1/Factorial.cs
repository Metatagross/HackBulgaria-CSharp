using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Ex1
{
    class Factorial
    {
        public static int FactWithLoop(int number)
        {
            int result = 1;
            if (number<=0)
            {
                return 1;
            }
            for (int i = 1 ; i <= number ; i++)
            { 
                
                result *= i;
            }
            return result;
        }

        public static int FactWithRec(int number)
        {
            if (number<=0)
            {
                return 1;
            }
            return number * FactWithRec(number - 1);
        }
        static void Main ( string[] args )
        {
            int number = int . Parse(Console.ReadLine());
            Console . WriteLine(FactWithRec(number));
            Console . WriteLine(FactWithLoop(number));
            Console . WriteLine(FactWithLoop(5));
            Console . WriteLine(FactWithLoop(-9));
            Console . WriteLine(FactWithRec(5));
            Console . WriteLine(FactWithRec(-5));
            Console . ReadKey();
        }
    }
}
