using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Category
    {
        public Category ( string n , int cId )
        {
            CategoryName = n;
            CategoryId = cId;
        }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
    }
}
