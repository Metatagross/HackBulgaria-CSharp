using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeExample
{
    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> Books { get; set; }
    }
}
