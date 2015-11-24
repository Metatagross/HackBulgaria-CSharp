using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace PalindromScore
{
    class PalindromValue
    {
        public static int Reverse(int number)
        {
            string result = null;
            for (int i = number.ToString().Length-1 ;i>=0 ; i--)
            {
                result += number . ToString()[i];
            }
            return int . Parse(result);
        }
        public static int PaliScore(int number)
        {
            int k = number . ToString() . Length-1;
            for (int i = 0 ; i < number.ToString().Length/2 ; i++)
            {
                if (number.ToString()[i]!=number.ToString()[k])
                {
                    return 1 + PaliScore(number + Reverse(number));
                }
                k--;
            }
            return 1;
        }
        static void Main ( string[] args )
        {
            int number = int . Parse(Console . ReadLine());
            Console . WriteLine(PaliScore(number));
            Console . ReadKey();
        }
    }
}
