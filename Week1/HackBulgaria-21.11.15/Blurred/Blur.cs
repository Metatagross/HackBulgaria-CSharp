using System;
using System . Collections . Generic;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Blurred
{

    class Blur
    {
        public static void FillArea ( Bitmap bmp , int x , int y , Bitmap newBmp )
        {
            int averageR = 0;
            int averageG = 0;
            int averageB = 0;
            for (int i = -1 ; i < 2 ; i++)
            {
                for (int j = -1 ; j < 2 ; j++)
                {
                    averageR += bmp . GetPixel(x + i , y + j) . R;
                    averageG += bmp . GetPixel(x + i , y + j) . G;
                    averageB += bmp . GetPixel(x + i , y + j) . B;
                }
            }
            Color color = Color . FromArgb(averageR / 9 , averageG / 9 , averageB / 9);
            for (int i = -1 ; i < 2 ; i++)
            {
                for (int j = -1 ; j < 2 ; j++)
                {
                    newBmp . SetPixel(x + i , y + j , color);
                }
            }
        }



        static void Main ( string[] args )
        {
            Bitmap bmp = (Bitmap)Image . FromFile("colorfull.bmp");
            Bitmap newBmp = new Bitmap(bmp . Width , bmp . Height);
            int x, y;
            for (x = 0 ; x < bmp . Width ; x++)
            {
                for (y = 0 ; y < bmp . Height ; y++)
                {
                    if (y == 0 || x == 0 || x == bmp . Width - 1 || y == bmp . Height - 1)
                    {

                    }
                    else
                    {
                        FillArea(bmp , x , y , newBmp);
                    }
                }
            }

            newBmp . Save("BlurredMyPic.bmp");
            Console . ReadKey();

        }
    }
}
