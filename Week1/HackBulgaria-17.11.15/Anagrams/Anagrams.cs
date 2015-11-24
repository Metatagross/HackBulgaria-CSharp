using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Anagrams
{
    class Anagrams
    {
        public static Boolean AreAnagrams ( string text , string textToCompare )
        {
            int counter=0;
            if (text . Length != textToCompare . Length)
            {
                return false;
            }
            for (int i = 0 ; i < text . Length ; i++)
            {
                for (int j = 0 ; j < text . Length ; j++)
                {
                    if (text[i]==textToCompare[j])
                    {
                        textToCompare . ToCharArray()[j] = ' ';
                        counter++;
                        break;
                    }
                }
                if (i==counter)
                {
                    return false;
                }
            }
            return true;
        }
        public static Boolean HasAnagramOf ( string text , string textToCompare )
        {
            int counter = 0;
            for (int i = 0 ; i < textToCompare . Length ; i++)
            {
                if (text . Contains(textToCompare[i]))
                {
                    counter++;
                    if (counter == text . Length)
                    {
                        return true;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            return false;
        }
        static void Main ( string[] args )
        {
            Console . WriteLine(AreAnagrams("console", "console"));
            Console . WriteLine(AreAnagrams("console" , "solocen"));
            Console . WriteLine(AreAnagrams("borbara" , "arabrob"));
            Console . WriteLine(AreAnagrams("musical" , "liscomana"));
            Console . WriteLine(AreAnagrams("monokini" , "kinomoni"));
            Console . WriteLine(HasAnagramOf("musical","nomlisamucnopr"));
            Console . ReadKey();
        }
    }
}
