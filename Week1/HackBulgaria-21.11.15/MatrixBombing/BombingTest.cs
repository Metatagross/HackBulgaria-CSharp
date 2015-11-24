using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace MatrixBombing
{
    class BombingTest
    {
        public static int BombMatrix ( int[,] matrix )
        {
            int[,] extendedMatrix = new int[matrix . GetLength(0) + 2, matrix . GetLength(1) + 2];
            int row = -1, col = 0;
            for (int i = 0 ; i < extendedMatrix . GetLength(0) ; i++)
            {
                for (int j = 0 ; j < extendedMatrix . GetLength(1) ; j++)
                {
                    if (i == 0 || j == 0 || i == extendedMatrix . GetLength(0)-1 || j == extendedMatrix . GetLength(1)-1)
                    {
                        extendedMatrix[i , j] = 0;
                    }
                    else
                    {
                        extendedMatrix[i , j] = matrix[row , col];
                        col++;
                    }
                }
                col = 0;
                row++;
            }
            int damage = 0;
            int tempDamage = 0;
            for (int i = 1 ; i <= matrix . GetLength(0) ; i++)
            {
                for (int j = 1 ; j <= matrix . GetLength(1) ; j++)
                {
                    for (int k = -1 ; k < 2 ; k++)
                    {
                        for (int t = -1 ; t < 2 ; t++)
                        {
                            if (extendedMatrix[i + k , j + t] <= extendedMatrix[i , j])
                            {
                                tempDamage += extendedMatrix[i + k , j + t];
                            }
                            else
                            {
                                tempDamage += extendedMatrix[i , j];
                            }
                        }
                    }
                    if (damage < tempDamage-extendedMatrix[i,j])
                    {
                        damage = tempDamage-extendedMatrix[i,j];
                    }
                    tempDamage = 0;
                }
            }
            return damage;
        }
        static void Main ( string[] args )
        {
            int[,] matrix = new int[,]
            {
                { 0 , 1 , 5 , 6 , 8 },
                { 4 , 8 , 5 , 7 , 9 },
                { 7 , 6 , 7 , 10 , 4 },
                { 12 , 12 , 14 , 7 , 5 },
                { 4 , 3 , 18 , 5 , 1 }
            };
            Console . WriteLine(BombMatrix(matrix));
            Console . ReadKey();
        }
    }
}
