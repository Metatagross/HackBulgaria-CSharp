using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Elipse : Shape
    {
        private Point center;
        private double radiusX;
        private double radiusY;

        public Elipse():this(new Point(0 , 0) , 2 , 1) { }
        public Elipse(Point c, double rX, double rY)
        {
            Center = c;
            RadiusX = rX;
            RadiusY = rY;        
        }

        public Point Center
        {
            get
            {
                return center;
            }

            set
            {
                center = value;
            }
        }

        public double RadiusX
        {
            get
            {
                return radiusX;
            }

            set
            {
                radiusX = value;
            }
        }

        public double RadiusY
        {
            get
            {
                return radiusY;
            }

            set
            {
                radiusY = value;
            }
        }

        public override double GetArea ( )
        {
            return Math.PI * RadiusY * RadiusX;
        }

        public override double GetPerimeter ( )
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(RadiusX , 2) + Math.Pow(RadiusY , 2)) / 2);
        }
        public override string ToString ( )
        {
            return string.Format("Center: {0}\nRadiusX: {1}\nRadiusY: {2}" , Center , RadiusX , RadiusY);
        }
    }
}
