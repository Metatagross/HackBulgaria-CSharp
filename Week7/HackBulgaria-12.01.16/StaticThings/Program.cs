using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticThings
{
    class Program
    {

        static void Main ( string[] args )
        {
            List<int> l1 = new List<int> { 5 , 6 , 7 , 8 , 10 , 11 , 15 , 4 };
            List<int> l2 = new List<int> { 6 , 8 , 14 , 13 , 17 , 4 };
            List<string> l3 = new List<string> { "merak" , "tabela" , "vinetka" , "pari" };
            foreach(var item in ArrayExtension.Intersect(l1,l2))
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine(ArrayExtension.Join(l3));
            Console.WriteLine();
            foreach(var item in ArrayExtension.UnionAll(l1 , l2))
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
