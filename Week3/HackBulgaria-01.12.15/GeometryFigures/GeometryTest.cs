using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class GeometryTest
    {
        static void Main ( string[] args )
        {
            Point a = new Point(1 , 1);
            Point c = new Point(4 , 2);
            Rectangle r = new Rectangle(a , c);
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(r);
            Console.WriteLine(r.Center);
            Console.WriteLine("Edges: {0} \n {1} \n  {2} \n   {3}" , r.AB , r.BC , r.BD , r.DA);
            Console.WriteLine(r.GetArea());
            Console.WriteLine(r.GetPerimeter());
            Console.WriteLine(r.GetHashCode());
            Console.WriteLine("Read any key...");
            Console.ReadKey();
        }
    }
}
