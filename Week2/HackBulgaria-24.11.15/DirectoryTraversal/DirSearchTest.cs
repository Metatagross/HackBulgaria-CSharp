using System;
using System . Collections . Generic;
using System . IO;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace DirectoryTraversal
{
    class DirSearchTest
    {
        public static IEnumerable<string> IterateDirectory ( DirectoryInfo dir , int n )
        {
            foreach (var item in dir . GetDirectories())
            {
                for (int i = 0 ; i < n ; i++)
                {
                    Console . Write(" ");
                }
                yield return string . Format("|*" + item . ToString());
                foreach (var item2 in IterateDirectory(item , n + 1))
                {
                    yield return item2;
                }
            }
            foreach (var item in dir . GetFiles())
            {
                for (int i = 0 ; i < n ; i++)
                {
                    Console . Write(" ");
                }
                yield return string . Format("-" + item . ToString());
            }
        }
        static void Main ( string[] args )
        {
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects");
            foreach (var item in IterateDirectory(dir , 0))
            {
                Console . WriteLine(item);
            }
            Console . ReadKey();
        }
    }
}
