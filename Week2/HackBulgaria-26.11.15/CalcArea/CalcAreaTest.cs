using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcArea
{
    class CalcAreaTest
    {
        public static float CalcArea ( PointF[] points )
        {
            float c = 0;
            for(int i = 0 ; i < points.Length ; i++)
            {
                if(i == points.Length - 1)
                {
                    c += (points[i].X * points[0].Y) - (points[i].Y * points[0].X);
                    break;
                }
                c += (points[i].X * points[i + 1].Y) - (points[i].Y * points[i + 1].X);
            }
            return Math.Abs(c / 2);
        }
        static void Main ( string[] args )
        {
            PointF[] polygonPoints = new PointF[]
            {
                new PointF((float)0.2, (float)2.5),
                new PointF((float)1.2, (float)2.5),
                new PointF((float)2.2, (float)2.5),
                new PointF((float)3.2, (float)2.5),
                new PointF((float)4.2, (float)2.5),
                new PointF((float)5.2, (float)2.5),
                new PointF((float)6.5, (float)2.5)
            };
            Console.WriteLine("{0:F4}",CalcArea(polygonPoints));
            PointF[] polygonPoints2 = new PointF[]
            {
                new PointF((float)2, (float)2),
                new PointF((float)4, (float)10),
                new PointF((float)9, (float)7),
                new PointF((float)11, (float)2)
            };

            Console.WriteLine("{0:N4}" , CalcArea(polygonPoints2));

            Console.ReadKey();
        }
    }
}
