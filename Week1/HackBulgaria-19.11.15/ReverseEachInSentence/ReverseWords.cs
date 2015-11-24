using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace ReverseEachInSentence
{
    class ReverseWords
    {
        public static string ReverseMe ( string text )
        {
            StringBuilder newString = new StringBuilder();
            for (int i = text . Length - 1 ; i >= 0 ; i--)
            {
                newString . Append(text[i]);
            }
            return newString . ToString();
        }

        public static string ReverseEveryWord ( string sentence )
        {
            StringBuilder tempSentence = new StringBuilder();
            int s, e;
            for (int i = 0 ; i < sentence . Length ; i++)
            {
                if (sentence[i] == ' ')
                {
                    tempSentence . Append(sentence[i]);
                }
                else
                {
                    s = i;
                    e = i;
                    while (sentence[i] != ' ' && i != sentence . Length - 1)
                    {
                        e++;
                        i++;
                    }
                    if (i != sentence . Length - 1)
                    {
                        i--;
                        tempSentence . Append(ReverseMe(sentence . Substring(s , e - s)));

                    }
                    else
                    {
                        tempSentence . Append(ReverseMe(sentence . Substring(s , e - s+1)));
                    }
                }
            }
            return tempSentence . ToString();
        }
        static void Main ( string[] args )
        {
            string sentence = Console . ReadLine();
            Console . WriteLine(ReverseEveryWord(sentence));
            Console . ReadKey();
        }
    }
}
