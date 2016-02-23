using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Point
    {
        private double x;
        private double y;

        public Point ( double x , double y)
        {
            X = x;
            Y = y;
        }
        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public double Distance(Point d)
        {
            return Math.Sqrt(Math.Pow(X - d.X , 2) + Math.Pow(Y - d.Y , 2));
        }
        public override string ToString ( )
        {
            return string.Format("({0},{1})" , X , Y);
        }
    }
}