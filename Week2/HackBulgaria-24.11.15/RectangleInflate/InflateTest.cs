using System;
using System . Collections . Generic;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Threading . Tasks;


namespace RectangleInflate
{
    class InflateTest
    {
        public static void RectInflate(ref Rectangle rect, Size inflateSize)
        {
            rect . X -= inflateSize . Width;
            rect . Y -= inflateSize . Height;
            rect . Width += 2 * inflateSize . Width;
            rect . Height += 2 * inflateSize . Height;
        }
        static void Main ( string[] args )
        {
            Rectangle rect = new Rectangle(0 , 0 , 5 , 7);
            Size s = new Size(2 , 2);
            RectInflate(ref rect , s);
            Console . WriteLine(rect);
            Console . WriteLine("(x:{0},y:{1},w:{2}, h:{3})" , rect . X , rect . Y , rect . Width , rect . Height);
            Console . ReadKey();
        }
    }
}
