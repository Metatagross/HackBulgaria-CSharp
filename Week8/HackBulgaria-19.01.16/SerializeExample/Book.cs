using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeExample
{
    [Serializable]
    public class Book
    {
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }

    }
}
