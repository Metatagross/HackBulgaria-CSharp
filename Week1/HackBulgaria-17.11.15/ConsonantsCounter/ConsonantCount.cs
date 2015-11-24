using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace ConsonantsCounter
{
    class ConsonantCount
    {
        public static int CountVowels ( string text )
        {
            text = text . ToLower();
            int counter = 0;
            for (int i = 0 ; i < text . Length ; i++)
            {
                switch (text[i])
                {
                    case 'a':
                    case 'o':
                    case 'u':
                    case 'e':
                    case 'y':
                    case 'i':  break;
                    default:
                        if (char.IsLetter(text[i]))
                        {
                            counter++;
                        }
                        break;
                }
            }
            return counter;
        }
        static void Main ( string[] args )
        {
            Console . WriteLine(CountVowels("Github is the second best thing that happend to programmers , after the keyboard"));
            Console . ReadKey();
        }
    }
}
