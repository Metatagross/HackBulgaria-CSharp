using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Point
    {
        private readonly double x;
        private readonly double y;
        public static readonly Point origin = new Point();
        public Point ( ) : this(0 , 0) { }
        public Point ( double x , double y )
        {
            this.x = x;
            this.y = y;
        }

        public Point ( Point a ) : this(a.x , a.y) { }
        public double X
        {
            get
            {
                return x;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
        }

        public override string ToString ( )
        {
            return string.Format("Point({0} , {1})" , x , y);
        }

        public override bool Equals ( object obj )
        {
            if(obj == null||!(obj is Point))
            {
                return false;
            }
            else
            {
                Point objEx = (Point)obj;
                return X == objEx.X && Y == objEx.Y;
            }
        }
        public static bool operator ==( Point objA , Point objB )
        {
            return Equals(objA , objB);
        }
        public static bool operator !=( Point objA , Point objB )
        {
            return !objA.Equals(objB);
        }
        public static Line operator +( Point objA , Point objB )
        {
            return new Line(objA , objB);
        }
        public override int GetHashCode ( )
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + x.GetHashCode();
                hash = hash * 23 + y.GetHashCode();
                return hash;
            }
        }
    }
}
