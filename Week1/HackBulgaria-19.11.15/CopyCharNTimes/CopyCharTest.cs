using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace CopyCharNTimes
{
    class CopyCharTest
    {
        public static string CopyEveryChar(string text, int times)
        {
            StringBuilder tempText = new StringBuilder();
            for (int i = 0 ; i < text.Length ; i++)
            {
                for (int j = 0 ; j < times ; j++)
                {
                    tempText . Append(text[i]);
                }
            }
            return tempText . ToString();
        }
        static void Main ( string[] args )
        {
            string text = Console . ReadLine();
            int times = int . Parse(Console . ReadLine());
            Console . WriteLine(CopyEveryChar(text,times));
            Console . ReadKey();
        }
    }
}
