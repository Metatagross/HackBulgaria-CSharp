using System;
using System . Collections . Generic;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace InterpolationPicture
{
    class NewSizeTest
    {
        static void Main ( string[] args )
        {
            Console . WriteLine("Scale for x");
            double scaleX = double . Parse(Console . ReadLine());
            Console . WriteLine("Scale for y");
            double scaleY = double . Parse(Console . ReadLine());
            Bitmap bmp = (Bitmap)Image . FromFile("colorfull.bmp");
            Bitmap bmpWithNewSize = new Bitmap((int)(scaleX * bmp . Width) , (int)(scaleY * bmp . Height));
            int x, y;
            for (x = 0 ; x < bmpWithNewSize . Width ; x++)
            {
                for (y = 0 ; y < bmpWithNewSize . Height ; y++)
                {
                    int oldX = (int)Math . Round((double)x / scaleX);
                    int oldY = (int)Math . Round((double)y / scaleY);
                    if (oldX>bmp.Width-1)
                    {
                        oldX--;
                    }
                    if(oldY>bmp.Height-1)
                    {
                        oldY--;
                    }
                    Color currPixel = bmp . GetPixel(oldX , oldY);
                    bmpWithNewSize . SetPixel(x , y , currPixel);   
                }
            }
            bmpWithNewSize . Save("Larger.bmp");
            Console . ReadKey();
        }
    }
}
