using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousAndNestedThings
{
    public static class MagazineAndBookSorter
    {
        public class Edition
        {
            public string EditionName { get; set; }
            public int Order { get; set; }

            public Edition ( Book b )
            {
                EditionName = b.Name;
                Order = b.Id;
            }
            public Edition(Magazine m)
            {
                EditionName = m.Title;
                Order = m.Isbn;
            }
        }

        public static List<string> Sort ( List<Book> books , List<Magazine> magazines )
        {
            List<Edition> editions = new List<Edition>();
            foreach(Book book in books)
            {
                editions.Add(new Edition(book));
            }
            foreach(Magazine magazine in magazines)
            {
                editions.Add(new Edition(magazine));
            }
            var sorted =
                from item in editions
                orderby item.Order, item.EditionName
                select item.EditionName;
            return sorted.ToList<string>();
        }
    }
}
