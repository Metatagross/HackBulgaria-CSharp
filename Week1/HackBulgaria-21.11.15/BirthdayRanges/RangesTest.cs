using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace BirthdayRanges
{
    class RangesTest
    {
        public static List<int> BirthdayRanges ( List<int> birthdays , List<KeyValuePair<int , int>> ranges )
        {
            List<int> result = new List<int>();
            for (int i = 0 ; i < ranges . Count ; i++)
            {
                result . Add(0);
                for (int j = 0 ; j < birthdays . Count ; j++)
                {
                    if (birthdays[j] <= ranges[i] . Value && birthdays[j] >= ranges[i] . Key)
                    {
                        result[i]++;
                    }
                }
            }
            return result;
        }
        static void Main ( string[] args )
        {
            List<int> birthdays = new List<int> { 5 , 10 , 6 , 7 , 3 , 4 , 5 , 11 , 21 , 300 , 15 };
            List<KeyValuePair<int , int>> ranges = new List<KeyValuePair<int , int>>
                {
                    new KeyValuePair<int, int>( 4 , 30 ),
                    new KeyValuePair<int, int>(31, 122),
                    new KeyValuePair<int, int>(123, 200),
                    new KeyValuePair<int, int>(201, 225),
                    new KeyValuePair<int, int>(225, 289),
                    new KeyValuePair<int, int>(240,331),
                    new KeyValuePair<int, int>(332,365)
                };
            List<int> result = BirthdayRanges(birthdays , ranges);
            foreach (var item in result)
            {
                Console . Write(item+" ");
            }
            Console . WriteLine("Press any key...");
            Console . ReadKey();
        }
    }
}
