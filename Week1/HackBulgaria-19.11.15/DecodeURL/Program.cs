using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace DecodeURL
{
    class Program
    {
        public static string DecodeUrl(string input)
        {
            StringBuilder tempInput = new StringBuilder(input);
            for (int i = 0 ; i < tempInput.Length ; i++)
            {
                if (tempInput[i]=='%')
                {

                    switch ((tempInput[i + 1] . ToString() + tempInput[i + 2] . ToString()))
                    {
                        case "20":
                            tempInput[i]=' ';
                            tempInput . Remove(i + 1 , 2);
                            break;
                        case "3A":
                            tempInput[i] = ':';
                            tempInput . Remove(i + 1 , 2);
                            break;
                        case "3D":
                            tempInput[i] = '?';
                            tempInput . Remove(i + 1 , 2);
                            break;
                        case "2F":
                            tempInput[i] = '/';
                            tempInput . Remove(i + 1 , 2);
                            break;
                        default:
                            break;
                    }
                }
            }
            return tempInput . ToString();
        }
        static void Main ( string[] args )
        {
            Console . WriteLine(DecodeUrl("15hop%2Flop%3DMen"));
            Console . ReadKey();
        }
    }
}
