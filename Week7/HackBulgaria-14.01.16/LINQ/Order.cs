using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Order
    {
        public Order ( int oId , List<int> p )
        {
            OrderId = oId;
            ProductsId = new List<int>(p);
            OrderName = "Order" + oId;
            OrderDate = DateTime.Now;
        }
        public int OrderId { get; set; }
        public List<int> ProductsId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderName { get; set; }
        public void Display ( List<Product> products )
        {
            Console.WriteLine("{0} created on {1}:" , OrderName , OrderDate);
            foreach(var id in ProductsId)
            {
                foreach(var item in products)
                {
                    if(id.Equals(item.ProductId))
                    {
                        Console.Write("{0} ", item.Name);
                    }
                }
            }
        }
    }
}
