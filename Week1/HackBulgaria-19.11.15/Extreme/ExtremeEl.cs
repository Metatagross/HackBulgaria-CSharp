using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Extreme
{
    class ExtremeEl
    {
        public static int Min(int[] items)
        {
            int min = items[0];
            for (int i = 0 ; i < items.Length ; i++)
            {
                if (min>items[i])
                {
                    min = items[i];
                }
            }
            return min;
        }
        public static int Max ( int[] items )
        {
            int max = items[0];
            for (int i = 0 ; i < items . Length ; i++)
            {
                if (max < items[i])
                {
                    max = items[i];
                }
            }
            return max;
        }

        public static int GetIndex(int[] items, int item)
        {
            for (int i = 0 ; i < items.Length ; i++)
            {
                if (items[i]==item)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int NthMin(int n, int[] items)
        {
            int[] tempItems = new int[items . Length];
            for (int i = 0 ; i < items.Length ; i++)
            {
                tempItems[i] = items[i];
            }
            int counter = 1;
            for (int i = 0 ; i < items.Length ; i++)
            {
                if (counter==n)
                {
                    return Min(tempItems);
                }
                tempItems[GetIndex(tempItems , Min(tempItems))] = Max(tempItems);
                counter++;
            }
            return Max(tempItems);
        }

        public static int NthMax ( int n , int[] items )
        {
            int[] tempItems = new int[items . Length];
            for (int i = 0 ; i < items . Length ; i++)
            {
                tempItems[i] = items[i];
            }
            int counter = 1;
            for (int i = 0 ; i < items . Length ; i++)
            {
                if (counter == n)
                {
                    return Max(tempItems);
                }
                tempItems[GetIndex(tempItems , Max(tempItems))] = Min(tempItems);
                counter++;
            }
            return Min(tempItems);
        }
        static void Main ( string[] args )
        {
            int[] numbers = new int[] { 1 , 8 , 9 , 15 , 14 , 16 , 2 , 8700 };
            Console . WriteLine(Max(numbers));
            Console . WriteLine(Min(numbers));
            Console . WriteLine(NthMin(5, numbers));
            Console . WriteLine(NthMin(numbers.Length+1 , numbers));
            Console . WriteLine(NthMax(5 , numbers));
            Console . ReadKey();
        }
    }
}
