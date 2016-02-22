using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Rectangle
    {
        private Point vertexA;
        private Point vertexC;

        public Rectangle ( ) : this(new Point(0 , 0) , new Point(1 , 1)) { }
        public Rectangle ( Point a , Point c )
        {
            if(a.X == c.X || a.Y == c.Y)
            {
                throw new ArgumentException("Vertices cannot be on the same axis!");
            }
            vertexA = a;
            vertexC = c;
        }

        public Rectangle ( Rectangle r ) : this(r.VertexA , r.VertexC) { }

        public Point VertexA
        {
            get
            {
                return vertexA;
            }
        }
        public Point VertexB
        {
            get
            {
                return new Point(vertexC.X , vertexA.Y);
            }
        }
        public Point VertexC
        {
            get
            {
                return vertexC;
            }
        }
        public Point VertexD
        {
            get
            {
                return new Point(VertexA.X , VertexC.Y);
            }
        }
        public Line AB
        {
            get
            {
                return new Line(VertexA , VertexB);
            }
        }
        public Line BC
        {
            get
            {
                return new Line(VertexB , VertexC);
            }
        }
        public Line BD
        {
            get
            {
                return new Line(VertexB , VertexD);
            }
        }
        public Line DA
        {
            get
            {
                return new Line(VertexD , VertexA);
            }
        }
        public double Width
        {
            get
            {
                return Math.Abs(VertexA.X - VertexB.X);
            }
        }
        public double Height
        {
            get
            {
                return Math.Abs(VertexA.Y - VertexC.Y);
            }
        }
        public Point Center
        {
            get
            {
                return new Point(VertexA.X + Width / 2 , VertexA.Y + Height / 2);
            }
        }
        public double GetPerimeter ( )
        {
            return 2 * (Width + Height);
        }
        public double GetArea ( )
        {
            return Width * Height;
        }
        public override string ToString ( )
        {
            return string.Format("Rectangle[({0},{1}),({2},{3})]" , VertexA.X , VertexA.Y , Width , Height);
        }
        public override bool Equals ( object obj )
        {
            if(obj == null)
            {
                return false;
            }
            else
            {
                Rectangle objEx = (Rectangle)obj;
                return VertexA == objEx.VertexA && VertexC == objEx.VertexC;
            }
        }
        public static bool operator ==( Rectangle objA , object objB )
        {
            return objA.Equals(objB);

        }
        public static bool operator !=( Rectangle objA , object objB )
        {
            return !objA.Equals(objB);
        }
        public override int GetHashCode ( )
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + VertexA.GetHashCode();
                hash = hash * 23 + VertexC.GetHashCode();
                return hash;
            }
        }
    }
}
