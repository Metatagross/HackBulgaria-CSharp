using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Line
    {
        private Point pointA;
        private Point pointB;

        public Line ( Point a , Point b )
        {
            if(a == b)
            {
                throw new ArgumentException("Cannot create a line segment with zero length!");
            }
            pointA = a;
            pointB = b;
        }

        public Line ( Line line ) : this(line.pointA , line.pointB) { }
        public Point PointA
        {
            get
            {
                return pointA;
            }
        }

        public Point PointB
        {
            get
            {
                return pointB;
            }
        }
        public double GetLength ( )
        {
            return Math.Sqrt(Math.Pow(PointA.X - PointB.X , 2) + Math.Pow(PointB.Y - PointA.Y , 2));
        }
        public override string ToString ( )
        {
            return string.Format("Line[({0},{1}),({2},{3})]" , PointA.X , PointA.Y , PointB.X , PointB.Y);
        }

        public override bool Equals ( object obj )
        {
            if(obj == null)
            {
                return false;
            }
            else
            {
                Line objEx = (Line)obj;
                return PointA == objEx.PointA && PointB == objEx.PointB;
            }
        }
        public static bool operator ==( Line objA , object objB )
        {
            return objA.Equals(objB);

        }
        public static bool operator !=( Line objA , object objB )
        {
            return !objA.Equals(objB);
        }
        public override int GetHashCode ( )
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + PointA.GetHashCode();
                hash = hash * 23 + PointB.GetHashCode();
                return hash;
            }
        }

        public static bool operator>(Line objA, Line objB)
        {
            return objA.GetLength() > objB.GetLength();
        }
        public static bool operator <( Line objA , Line objB )
        {
            return objA.GetLength() < objB.GetLength();
        }
        public static bool operator >=( Line objA , Line objB )
        {
            return objA.GetLength() >= objB.GetLength();
        }
        public static bool operator <=( Line objA , Line objB )
        {
            return objA.GetLength() <= objB.GetLength();
        }
        public static bool operator >( Line objA , double objB )
        {
            return objA.GetLength() > objB;
        }
        public static bool operator <( Line objA , double objB )
        {
            return objA.GetLength() < objB;
        }
        public static bool operator >=( Line objA , double objB )
        {
            return objA.GetLength() >= objB;
        }
        public static bool operator <=( Line objA , double objB )
        {
            return objA.GetLength() <= objB;
        }
        
    }
}
