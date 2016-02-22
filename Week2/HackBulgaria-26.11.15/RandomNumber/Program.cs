
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        public static void GenerateRandomMatrix(int rows, int cols, string fileName)
        {
            float[,] matrix = new float[rows , cols];
            Random rand = new Random();
            for(int i = 0 ; i < rows ; i++)
            {
                for(int j = 0 ; j < cols ; j++)
                {
                    matrix[i , j] = (float)(rand.NextDouble() * 1000.5);
                }
            }
            StringBuilder result= new StringBuilder();
            for(int i = 0 ; i < rows ; i++)
            {
                for(int j = 0 ; j < cols ; j++)
                {
                    result.Append(string.Format("{0,6:F2} " , matrix[i , j]));
                }
                result.Append(Environment.NewLine);
            }
            Console.WriteLine(result.ToString());
            File.WriteAllText(fileName, result.ToString());
        }
        static void Main ( string[] args )
        {
            GenerateRandomMatrix(5 , 6 , "C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects\\HackBulgaria-26.11.15\\RandomNumber\\RnadomMatrix.txt");
            Console.ReadKey();
        }
    }
}
