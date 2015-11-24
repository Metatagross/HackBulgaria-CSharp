using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Palindrome
{
    class Palindrome
    {
        public static Boolean IsIntPlaindrome ( int number )
        {
            int k = number . ToString() . Length - 1;
            for (int i = 0 ; i < number . ToString() . Length / 2 ; i++)
            {
                if (number . ToString()[i] != number . ToString()[k])
                {
                    return false;
                }
                k--;
            }
            return true;
        }

        public static int GetLargestPalindrome(int number)
        {
            number--;
            while (number>=0)
            {
                if (IsIntPlaindrome(number))
                {
                    return number;
                }
                number--;
            }
            return -1;
        }
        static void Main ( string[] args )
        {
            int number = int . Parse(Console.ReadLine());
            Console . WriteLine("{0}-{1}",number, IsIntPlaindrome(number));
            Console . WriteLine("Upper limit: {0} \nLargest palindrome:{1}",number, GetLargestPalindrome(number));
            Console . ReadKey();
        }
    }
}
