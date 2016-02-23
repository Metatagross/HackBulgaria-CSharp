using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousAndNestedThings
{
    class Program
    {
        static void Main ( string[] args )
        {
            List<Book> books = new List<Book>
            {
                new Book() {Id=1,  Name="V-created"},
                new Book() {Id=15, Name="Artrave" },
                new Book() {Id=24, Name="Methods and decisions" },
                new Book() {Id=55, Name="Express yourself" },
                new Book() {Id=106, Name="Polynomial world" }
            };
            List<Magazine> magazines = new List<Magazine>
            {
                new Magazine() {Isbn=4, Title="Me and you" },
                new Magazine() {Isbn=14, Title="Heroes" },
                new Magazine() {Isbn=15, Title="Be eKo" },
                new Magazine() {Isbn=55, Title="Artrave" },
                new Magazine() {Isbn=106, Title="Music with rage" }
            };
            List<string> sorted =MagazineAndBookSorter.Sort(books , magazines);
            foreach(string item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
