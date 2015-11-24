using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace MaxScalar
{
    class ScalarTest
    {

        public static int[] MergeSort ( int[] array )
        {
            if (array . Length == 1)
            {
                return array;
            }
            int[] leftSide = new int[array . Length / 2];
            int[] rightSide = array . Length % 2 == 0 ?new int[array . Length / 2]:new int[array . Length / 2 + 1];
            for (int i = 0 ; i < array . Length ; i++)
            {
                if (i < array . Length / 2)
                {
                    leftSide[i] = array[i];
                }
                else
                {
                    rightSide[i - array . Length / 2] = array[i];
                }
            }
            rightSide = MergeSort(rightSide);
            leftSide = MergeSort(leftSide);
            int[] merge = new int[array . Length];
            int leftCounter = 0;
            int rightCounter = 0;
            for (int i = 0 ; i < merge . Length ; i++)
            {
                if (leftCounter == leftSide . Length)
                {
                        merge[i] = rightSide[rightCounter];
                        rightCounter++;   
                }
                else if (rightCounter == rightSide . Length)
                {
                        merge[i] = leftSide[leftCounter];
                        leftCounter++;
                }
                else
                {
                    if (leftSide[leftCounter] < rightSide[rightCounter])
                    {
                        merge[i] = leftSide[leftCounter];
                        leftCounter++;
                    }
                    else
                    {
                        merge[i] = rightSide[rightCounter];
                        rightCounter++;
                    }
                }
            }
            return merge;
        }
        public static void MaxScalar ( int[] v1 , int[] v2 )
        {
            int sum = 0;
            if (v1 . Length != v2 . Length)
            {
                Console . WriteLine("Operation impossible!");
            }
            else
            {
                v1 = MergeSort(v1);
                v2 = MergeSort(v2);
                for (int i = 0 ; i < v1 . Length ; i++)
                {
                    sum += v1[i] * v2[i];
                }
            }
            Console . WriteLine(sum);
        }
        static void Main ( string[] args )
        {
            int[] v1 = { 5 , 6 , 9 , 7 , 1 , 10 };
            int[] v2 = { 1 , 4 , 5 , 2 , 8 , 11 };
            MaxScalar(v1 , v2);
     
            Console . ReadKey();
        }
    }
}
