using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace InDeCreasing
{
    class InDeCreasingTest
    {
        public static Boolean IsIncreasing ( int[] sequence )
        {
            int check = sequence[0];
            for (int i = 0 ; i < sequence . Length ; i++)
            {
                if (sequence[i] < check)
                {
                    return false;
                }
                check = sequence[i];
            }
            return true;
        }

        public static Boolean IsDecreasing ( int[] sequence )
        {
            int check = sequence[0];
            for (int i = 0 ; i < sequence . Length ; i++)
            {
                if (sequence[i] > check)
                {
                    return false;
                }
                check = sequence[i];
            }
            return true;
        }
        static void Main ( string[] args )
        {
            Console . WriteLine(IsIncreasing(new int[] { 0 , 1 , 2 , 4 , 8 , 9 , 55 , 152 }));
            Console . WriteLine(IsIncreasing(new int[] { 0 , 1 , 2 , 4 , 8 , 9 , 41 , 2 }));
            Console . WriteLine(IsDecreasing(new int[] { 29 , 18 , 17 , 15 , 13 , 10 , 8 , 5 , 4 , 1 }));
            Console . WriteLine(IsDecreasing(new int[] { 29 , 18 , 17 , 15 , 13 , 10 , 8 , 5 , 4 , 1 , 25 }));
            Console . ReadKey();
        }
    }
}
