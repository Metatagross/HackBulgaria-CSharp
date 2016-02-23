using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Elipse
    {
        public Circle(Point c, double radius ) : base(c , radius , radius) { }

        public double Radius
        {
            get
            {
                return RadiusX;
            }
            set
            {
                RadiusX = value;
                RadiusY = value;
            }
        }
        public override string ToString ( )
        {
            return base.ToString();
        }
    }
}
