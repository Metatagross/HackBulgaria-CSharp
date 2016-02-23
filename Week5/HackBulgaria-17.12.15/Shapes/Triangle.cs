using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        private Point vertex1;
        private Point vertex2;
        private Point vertex3;

        public Triangle(Point a, Point b, Point c)
        {
            Vertex1 = a;
            Vertex2 = b;
            Vertex3 = c;
        }
        public Point Vertex1
        {
            get
            {
                return vertex1;
            }

            set
            {
                vertex1 = value;
            }
        }

        public Point Vertex2
        {
            get
            {
                return vertex2;
            }

            set
            {
                vertex2 = value;
            }
        }

        public Point Vertex3
        {
            get
            {
                return vertex3;
            }

            set
            {
                vertex3 = value;
            }
        }

        public override double GetArea ( )
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt((p * (p - Vertex1.Distance(Vertex2)) * (p - Vertex2.Distance(Vertex3)) * (p - Vertex3.Distance(Vertex1))) / 16);
        }

        public override double GetPerimeter ( )
        {
            return Vertex1.Distance(Vertex2) + Vertex2.Distance(Vertex3) + Vertex3.Distance(Vertex1);
        }
    }
}
