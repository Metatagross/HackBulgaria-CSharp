using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PolygonCircumference
{
    class CalcCTest
    {
        public static float CalcCircumference(PointF[] points)
        {
            float c = 0;
            for(int i = 0 ; i < points.Length ; i++)
            {
                if(i==points.Length-1)
                {
                    c += (float)Math.Sqrt(Math.Pow((points[i].X - points[0].X) , 2) + Math.Pow((points[i].Y - points[0].Y) , 2));
                    break;
                }
                c += (float)Math.Sqrt(Math.Pow((points[i].X - points[i + 1].X) , 2) + Math.Pow((points[i].Y - points[i + 1].Y) , 2));
            }
            return c;
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
            Console.WriteLine(CalcCircumference(polygonPoints));
            Console.ReadKey();
        }
    }
}
