using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace StringReverse
{
    class ReverseMeTest
    {
        public static string ReverseMe(string text)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = text . Length-1 ; i >=0 ; i--)
            {
                newString . Append(text[i]);
            }
            return newString . ToString();
        }
        static void Main ( string[] args )
        {
            string text = Console . ReadLine();
            Console . WriteLine(ReverseMe(text));
            Console . ReadKey();
        }
    }
}
