using GenericClasses;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    class Program
    {
        static void Main ( string[] args )
        {
            Stack<int> stacker = new Stack<int>();
            stacker.Push(5);
            stacker.Push(4);
            Console.WriteLine(stacker.Contains(4));
            Console.WriteLine(stacker.Peek());
            Console.WriteLine(stacker.Pop());
            Console.WriteLine(stacker.Contains(4));
            Console.WriteLine(stacker.Peek());
            stacker.Clear();
            Console.WriteLine(stacker.IsEmpty());
            Console.WriteLine(stacker.Peek().GetType().Name);
            Console.ReadKey();

        }
    }
}
