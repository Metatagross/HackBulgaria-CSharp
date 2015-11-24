using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace HackNumbers
{
    class HackNum
    {
        public static Boolean IsHack ( int number )
        {
            string binary = null;
            int counter = 0;
            while (number > 0)
            {
                binary += number % 2;
                if (number % 2 == 1)
                {
                    counter++;
                }
                number /= 2;
            }
            if (counter%2!=1)
            {
                return false;
            }
            int k = binary . Length-1;
            for (int i = 0 ; i < binary.Length/2 ; i++)
            {
                if (binary[i]!=binary[k])
                {
                    return false;
                }
                k--;
            }
            return true;
        }
        
        public static int NextHack(int number)
        {
            while (!IsHack(number+1))
            {
                number++;
            }
            return number+1;
        }
        static void Main ( string[] args )
        {
            int number = int . Parse(Console . ReadLine());
            Console . WriteLine("{0} - {1}", number, IsHack(number));
            Console . WriteLine(NextHack(8031));
            Console . ReadKey();
        }
    }
}
