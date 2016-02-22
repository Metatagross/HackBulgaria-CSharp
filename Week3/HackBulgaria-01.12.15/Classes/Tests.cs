using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Tests
    {
        static void Main ( string[] args )
        {
            Time t = new Time();
            Time t1 = new Time(new DateTime(2015 , 12 , 14 , 2 , 14 , 12));
            Console.WriteLine(t);
            Console.WriteLine(t1);
            Console.WriteLine(t.Now());
            Console.WriteLine("Time test passed!");

            Pair p = new Pair(5 , t);
            Pair p2 = new Pair(5 , t);
            Console.WriteLine(p);
            Console.WriteLine(p2);
            Console.WriteLine("{0} \n {1} \n  {2} \n   {3}" , p == p2 , p.Equals(p2) , p != p2 , p == null);
            Console.WriteLine("Pair test passed!");
            Console.WriteLine();

            Fractions f1 = new Fractions(1 , 2);
            Fractions f2 = new Fractions(5 , 6);
            Fractions f3 = new Fractions(7 , 14);
            Console.WriteLine(f3);
            Console.WriteLine(f1 + f2);
            Console.WriteLine(f1 - f2);
            Console.WriteLine(f1 * f2);
            Console.WriteLine(f1 / f2);
            Console.WriteLine(f1 + 0.9);
            Console.WriteLine(f1 - 12);
            Console.WriteLine(f1 * 0);
            Console.WriteLine(f1 / 8);
            Console.WriteLine(f1==f3);
            Console.WriteLine(f1.Equals(f2));
            Console.WriteLine("Fractions test passed!");
            Console.WriteLine();

            Vector v = new Vector(5 , 3 , 8);
            Vector anotherV = new Vector(2 , 4 , 7);
            Console.WriteLine(v);
            Console.WriteLine(v.Length);
            Console.WriteLine(v.Dimensionality);
            Console.WriteLine(v+5);
            Console.WriteLine(v-1);
            Console.WriteLine(v*4);
            Console.WriteLine(v/2);
            Console.WriteLine(v + anotherV);
            Console.WriteLine(v - anotherV);
            Console.WriteLine(v * anotherV);
            Console.WriteLine("Vector test passed!");
            Console.WriteLine();
            Console.WriteLine("Read any key...");
            Console.ReadKey();
        }
    }
}
