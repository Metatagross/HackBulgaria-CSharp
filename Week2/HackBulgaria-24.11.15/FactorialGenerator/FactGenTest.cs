using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace FactorialGenerator
{
    class FactGenTest
    {
        public static IEnumerable<int> GenerateFactorials(int n)
        {
            int fact = 1;
            for (int i = 0 ; i < n ; i++)
            {
                if (i==0)
                {
                    yield return 1;
                }
                else
                {
                    fact *= i;
                    yield return fact;
                }
            }
        }
        static void Main ( string[] args )
        {
            foreach (var item in GenerateFactorials(10))
            {
                Console . Write(item+" ");
            }
            Console . ReadKey();
        }
    }
}
