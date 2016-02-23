using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Rectangle
    {   
        public Square( Point c,double side ) : base(c , side , side) { }
        public double Side
        {
            get
            {
                return Width;
            }
            set
            {
                Width = value;
                Height = value;
            }
        }
        public override string ToString ( )
        {
            return base.ToString();
        }
    }
}
