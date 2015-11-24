using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace StringFib
{
    class ConcatFib
    {
        public static long ConcatFibs(int number)
        {
            int[] fibs = new int[number];
            string result = null;
            for (int i = 0 ; i < number ; i++)
            {
                if (i==0||i==1)
                {
                    fibs[i] = 1;
                }
                else
                {
                    fibs[i] = fibs[i - 1] + fibs[i - 2];
                }
                result += fibs[i];
            }
            return long.Parse(result);
        }
        static void Main ( string[] args )
        {
            int number = int . Parse(Console . ReadLine());
            Console . WriteLine(ConcatFibs(number));

            Console . ReadKey();
        }
    }
}
