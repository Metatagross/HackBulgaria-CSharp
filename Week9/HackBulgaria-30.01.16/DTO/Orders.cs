using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Orders
    {
        public Orders(int id, DateTime date, decimal price, int cID)
        {
            OrderID = id;
            DateOfOrder = date;
            TotalPrice = price;
            CustomerID = cID;
        }
        public int OrderID { get; set; }
        public DateTime DateOfOrder { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerID { get; set; }
    }
}
