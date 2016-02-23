using Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedTest
    {
        static void Main ( string[] args )
        {
            LListDefinition<int> list = new LListDefinition<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list[1] = 5;
            if(!list.InsertAfter(5 , 9))
            {
                Console.WriteLine("Invalid operation!");
            }
            if(!list.InsertAfter(5 , 10))
            {
                Console.WriteLine("Invalid!");
            }
            else if(!list.InsertAt(3 , 8))
            {
                Console.WriteLine("Invalid");
            }
            else if(!list.InsertBefore(5 , 10))
            {
                Console.WriteLine("Invalid!");
            }
            else if(!list.Remove(10))
            {
                Console.WriteLine("Invalid!");
            }
            else
            {
                Console.WriteLine("Great!");
            }
            foreach(var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            var list1 = new LListDefinition<string>();
            list1.Add("x");
            list1.Add("g");
            list1.Add("s");

            Console.WriteLine(list.Counter); //output: 3

            list1.InsertAfter("g" , "a");
            list1.InsertAt(10 , "z"); //throws an exception - IndexOutOfRangeException
            list1.InsertAt(2 , "z");
            list1.Remove("z");
            list1[1] = "m";

            foreach(var value in list1)
            {
                Console.WriteLine(value);
            }

            Map<int , string> m = new Map<int , string>();
            m.Add(8 , "eight");
            m.Add(9 , "nine");
            m.Add(11 , "eleven");
            m[7] = "seven";
            m[10] = "ten";
            m[12] = "twelve";
            m[3] = "three";
            m[4] = "four";
            m[5] = "five";
            m[6] = "six";
            m[69] = "sex";
            m[70] = "seventy";
            Console.WriteLine(m.Keys.Count);
            Console.WriteLine(m.Keys.Capacity);
            Console.WriteLine(m.ContainsKey(7));
            Console.WriteLine(m.ContainsKey(1));
            Console.WriteLine(m.ContainsValue("ten"));
            Console.WriteLine(m.ContainsValue("pen"));
            m.Remove(8);
            Console.WriteLine(m.ContainsKey(8));
            m.Clear();
            Console.ReadKey();
        }
    }
}
