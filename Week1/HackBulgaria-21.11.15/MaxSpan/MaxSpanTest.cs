using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace MaxSpan
{
    class MaxSpanTest
    {
        public static int MaxSpan(List<int> numbers)
        {
            int first = numbers[0];
            int last= numbers[numbers . Count - 1];
            int counterFirst = 0;
            int counterLast = 0;
            for (int i = 0 ; i < numbers.Count ; i++)
            {
                if (numbers[i]==first)
                {
                    counterFirst++;
                }
                if (numbers[i]==last)
                {
                    counterLast++;
                }
            }
            return counterLast + counterFirst;
        }
        static void Main ( string[] args )
        {
            List<int> numbers = new List<int>{ 5 , 4 , 4 , 8 , 9 , 5 , 6 , 6 , 5 , 4 , 8 , 8 , 8 };
            Console . WriteLine(MaxSpan(numbers));
            Console . WriteLine("Press any key...");
            Console . ReadKey();
        }
    }
}
