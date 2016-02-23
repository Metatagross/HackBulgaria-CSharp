using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main ( string[] args )
        {
            Owl owl = new Owl();
            owl.Eat();
            owl.Move();
            owl.GiveBirth();
            owl.Greet();

            Console.ReadKey();
        }
    }
}
