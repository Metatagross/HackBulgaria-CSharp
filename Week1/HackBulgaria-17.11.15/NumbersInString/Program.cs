using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace NumbersInString
{
    class Program
    {
        
        public static int SumOfNumbers(string text)
        {
            int result = 0;
            for (int i = 0 ; i < text.Length ; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    string number = text[i].ToString();
                    for (int j = i+1 ; j < text.Length ; j++)
                    {
                        if (char.IsDigit(text[j]))
                        {
                            number += text[j] . ToString();
                        }
                        else
                        {
                            i = j;
                            break;
                        }
                    }
                    result += int . Parse(number);
                }
            }
            return result;
        }

        static void Main ( string[] args )
        {
            string text = Console . ReadLine();
            Console . WriteLine(SumOfNumbers(text));
            Console . ReadKey();
        }
    }
}
