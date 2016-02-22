using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace SearchInList
{
    class Program
    {
        public static bool TryFindSubstring(List<string> list, string searched, out int foundIndex)
        {
            foundIndex = -1;
            for (int i = 0 ; i < list.Count ; i++)
            {
                if (list[i] . Contains(searched))
                {
                    foundIndex = i;
                    return true;
                }
            }
            return false;
        }
        static void Main ( string[] args )
        {
            List<string> strings = new List<string> { "alabala" , "kokomicin" , "Koshi" , "shiba" , "menta" };
            int index;
            Console . WriteLine("{0}-{1}", TryFindSubstring(strings, "shi", out index), index);
            Console . WriteLine("{0}-{1}" , TryFindSubstring(strings , "mon" , out index),index);
            Console . ReadKey();
        }
    }
}
