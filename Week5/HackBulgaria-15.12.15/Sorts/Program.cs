using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    {

        static void Main ( string[] args )
        {
            List<int> array = new List<int>() { 2 , 4 , 1 , 6 , 10 };
            Console.WriteLine(array.BinarySearch(10 , Comparer<int>.Default));

            List<int> sortedArrayBS = array.BubbleSort<int>(Comparer<int>.Default).ToList();
            List<int> sortedArraySS = array.SelectionSort<int>(Comparer<int>.Default).ToList();
            List<int> sortedArrayMS = array.MergeSort<int>(Comparer<int>.Default).ToList();
            List<int> sortedArrayQS = array.QuickSort<int>(Comparer<int>.Default).ToList();

            Console.Write("Original array: " + array.Count + "\n ");
            foreach(var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Bubble Sort: ");
            foreach(var item in sortedArrayBS)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Selection Sort: ");
            foreach(var item in sortedArraySS)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Merge Sort: ");
            foreach(var item in sortedArrayMS)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Quick Sort: ");
            foreach(var item in sortedArrayQS)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
