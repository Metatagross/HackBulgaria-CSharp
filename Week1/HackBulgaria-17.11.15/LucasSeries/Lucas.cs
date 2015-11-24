using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace LucasSeries
{
    class Lucas
    {
        public static int NthLucas(int number)
        {
            if (number==0)
            {
                return 2;
            }
            if (number==1)
            {
                return 1;
            }
            return NthLucas(number - 1) + NthLucas(number - 2);
        }

        public static int[] FirstNLucas(int n)
        {
            int[] result = new int[n+1];
            for (int i = 0 ; i < result.Length ; i++)
            {
                result[i] = NthLucas(i);
            }
            return result;
        }
        static void Main ( string[] args )
        {

            int number = int . Parse(Console . ReadLine());
            Console . WriteLine("N-th Lucas' number: {0}",NthLucas(number));
            int[] collection = FirstNLucas(number);
            foreach (var item in collection)
            {
                Console . WriteLine(item);
            }
            Console . ReadKey();
        }

    }
}
