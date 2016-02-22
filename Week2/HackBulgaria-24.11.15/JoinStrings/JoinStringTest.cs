using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace JoinStrings
{
    class JoinStringTest
    {
        public static string JoinStrings(string separator, params string[] strings)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0 ; i < strings.Length ; i++)
            {
                if (i==strings.Length-1)
                {
                    result . Append(strings[i]);
                }
                else
                {
                    result . Append(strings[i]);
                    result . Append(separator);
                }
            }
            return result . ToString();
        }
        static void Main ( string[] args )
        {
            Console . WriteLine(JoinStrings(" ", "5","kyufteta","se","pekat","na","skara!"));
            Console . ReadKey();
        }
    }
}
