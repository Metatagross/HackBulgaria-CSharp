using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace CharHistogram
{
    class CharLog
    {
        public static Dictionary<char, int> CharHiostory(string text)
        {
            Dictionary<char , int> dict = new Dictionary<char , int>();
            for (int i = 0 ; i < text.Length ; i++)
            {
                if (text[i]==' ')
                {
                    continue;
                }
                if (!dict.ContainsKey(text[i]))
                {
                    dict[text[i]] = 1;
                }
                else
                {
                    dict[text[i]]++;
                }
            }
            return dict;
        }
        static void Main ( string[] args )
        {
            string text = Console . ReadLine();
            Dictionary<char , int> dictionary = CharHiostory(text);
            foreach (var item in dictionary)
            {
                Console . WriteLine(item);
            }
            Console . ReadKey();
        }
    }
}
