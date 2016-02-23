using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public static class SortAndSearchExtensions
    {
        public static IList<T> BubbleSort<T>( this IList<T> list , IComparer<T> com )
        {
            bool finish = true;
            while(finish)
            {
                finish = false;
                for(int i = 0 ; i < list.Count - 1 ; i++)
                {

                    if(com.Compare(list[i] , list[i + 1]) > 0)
                    {
                        T temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        finish = true;
                    }
                }
            }
            return list;
        }
        public static IList<T> SelectionSort<T>( this IList<T> list , IComparer<T> com )
        {

            for(int i = 0 ; i < list.Count - 1 ; i++)
            {

                int maxPos = 0;
                T maxE = list[0];
                for(int j = 0 ; j < list.Count - i ; j++)
                {
                    if(com.Compare(list[j] , maxE) > 0)
                    {
                        maxE = list[j];
                        maxPos = j;
                    }
                }
                T temp = list[maxPos];
                list[maxPos] = list[list.Count - i - 1];
                list[list.Count - i - 1] = temp;
            }
            return list;
        }
        public static int BinarySearch<T>( this IList<T> list , T numberToFind , IComparer<T> com )
        {
            int mid = list.Count / 2;
            if(list[mid].Equals(numberToFind))
            {
                return mid;
            }
            List<T> left = list.ToList().GetRange(0 , mid);
            List<T> right = list.ToList().GetRange(mid + 1 , mid);
            return (com.Compare(list[mid] , numberToFind) > 0) ?
                    BinarySearch(left , numberToFind , com) :
                        BinarySearch(right , numberToFind , com);
        }
        public static List<T> MergeSort<T>( this List<T> list , IComparer<T> com )
        {
            if(list.Count == 1)
            {
                return list;
            }
            List<T> left = new List<T>();
            List<T> right = new List<T>();
            for(int i = 0 ; i < list.Count ; i++)
            {
                if(i < list.Count / 2)
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }
            left = MergeSort(left , com);
            right = MergeSort(right , com);
            List<T> merged = new List<T>();
            for(int i = 0, j = 0 ; i + j < list.Count ;)
            {
                if(i < left.Count && j < right.Count)
                {
                    if(com.Compare(left[i] , right[j]) < 0)
                    {
                        merged.Add(left[i]);
                        i++;
                    }
                    else
                    {
                        merged.Add(right[j]);
                        j++;
                    }
                }
                else if(i < left.Count && j >= right.Count)
                {
                    merged.Add(left[i]);
                    i++;
                }
                else
                {
                    merged.Add(right[j]);
                    j++;
                }

            }
            return merged;
        }
        public static IList<T> QuickSort<T>( this IList<T> list , IComparer<T> com )
        {
            if(list.Count() <= 1)
            {
                return list;
            }
            IList<T> left = new List<T>();
            IList<T> right = new List<T>();

            T pivot = list[0];
            int pivotCounter = 0;

            foreach(T item in list)
            {
                if(com.Compare(item , pivot) < 0)
                {
                    left.Add(item);
                }
                else if(com.Compare(item , pivot) > 0)
                {
                    right.Add(item);
                }
                else
                {
                    pivotCounter++;
                }
            }
            left = QuickSort(left , com);
            right = QuickSort(right , com);

            List<T> result = new List<T>();
            result.AddRange(left);
            for(int i = 0 ; i < pivotCounter ; i++)
            {
                result.Add(pivot);
            }
            result.AddRange(right);
            return result;
        }
    }
}
