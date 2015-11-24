using System;
using System . Collections . Generic;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace GrayscaleImage
{
    class GrayTest
    {
        static void Main ( string[] args )
        {
            Bitmap bmp = (Bitmap)Image . FromFile("colorfull.bmp");
            Bitmap grayBmp = new Bitmap(bmp.Width, bmp.Height);
            int averageColor = 0;
            int x, y;
            for ( x = 0 ; x < bmp.Width ; x++)
            {
                for ( y = 0 ; y < bmp.Height ; y++)
                {
                    Color currPixel = bmp . GetPixel(x , y);
                    averageColor = (currPixel . G + currPixel . B + currPixel . R) / 3;
                    Color newPixel = Color.FromArgb(averageColor,averageColor,averageColor);
                    grayBmp . SetPixel(x , y , newPixel);
                }
            }
            grayBmp . Save("img000245.bmp");
            Console . ReadKey();
        }
    }
}
