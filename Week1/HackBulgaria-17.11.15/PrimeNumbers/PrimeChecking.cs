using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace PrimeNumbers
{
    class PrimeChecking
    {
        public static Boolean IsPrime ( int n )
        {
            for (int i = 2 ; i <= Math . Sqrt(n) ; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> ListFirstPrimes ( int number )
        {
            List<int> numbers = new List<int>();
            int counter = 0;
            for (int i=2 ; ; i++)
            {
                if (IsPrime(i))
                {
                    counter++;
                    numbers . Add(i);
                }
                if (counter==number)
                {
                    break;
                }
            }
            return numbers;
        }

        public static List<int> SieveOfEr(int n)
        {
            Boolean[] numbers = new Boolean[n];
            List<int> result = new List<int>();
            for (int i = 0 ; i < n ; i++)
            {
                numbers[i] = true;
            }
            numbers[0] = false;
            numbers[1] = false;
            for (int i = 0 ; i < n ; i++)
            {
                if (numbers[i])
                {
                    for (int j = 0 ; j*i < n ; j++)
                    {
                        numbers[i * j] = false;
                    }
                    result . Add(i);
                }
            }
            return result;
        }

        static void Main ( string[] args )
        {
            int number = int . Parse(Console.ReadLine());
            List<int> firstNNumbers = ListFirstPrimes(number);
            Console . WriteLine("Is {0} prime? {1}" , number , IsPrime(number));
            Console . WriteLine("First {0} primes:",number);
            foreach (var item in firstNNumbers)
            {
                Console . Write(item + " , ");
            }
            Console . WriteLine();
            //Using the Sieve of Eratosthenes
            List<int> firstNOfEr = SieveOfEr(number);
            foreach (var item in firstNOfEr)
            {
                Console . Write(" "+item);
            }
            Console . ReadKey();
        }
    }
}
