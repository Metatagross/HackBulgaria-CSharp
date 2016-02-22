using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace ReverseList
{
    class ReverseTest
    {
        public static void ReverseList(List<int> list)
        {
            int temp;
            for (int i = 0 ; i < list.Count/2 ; i++)
            {
                temp = list[i];
                list[i] = list[list . Count - 1 - i];
                list[list . Count - 1 - i] = temp;
            }
        }
        static void Main ( string[] args )
        {
            List<int> list = new List<int> { 1, 2, 5, 8, 9 };
            ReverseList(list);
            foreach (var item in list)
            {
                Console . Write(item+" ");
            }
            Console . ReadKey();

        }
    }
}
