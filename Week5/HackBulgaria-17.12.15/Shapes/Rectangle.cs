using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private Point center;
        private double width;
        private double height;

        public Rectangle ( ) : this(new Point(0 , 0) , 1 , 1) { }
        public Rectangle ( Point c , double w , double h )
        {
            Center = c;
            Width = w;
            Height = h;
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

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public override double GetArea ( )
        {
            return Width * Height;
        }

        public override double GetPerimeter ( )
        {
            return 2 * (Width + Height);
        }
        public override string ToString ( )
        {
            return string.Format("Center: {0}\nWidth: {1}\nHeight: {2}" , Center , Width , Height);
        }
    }
}
