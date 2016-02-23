using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Product
    {
        public Product ( string n, int pId, int cId )
        {
            Name = n;
            ProductId = pId;
            CategoryId = cId;
        }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}
