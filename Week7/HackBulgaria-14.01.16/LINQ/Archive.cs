using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Archive
    {
        public Archive ( List<Order> o , List<Product> p, List<Category> c)
        {
            Orders = new List<Order>(o);
            Products = new List<Product>(p);
            Categories = new List<Category>(c);
        }
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }

        public List<Product> GetProducts()
        {
            return Products.Select(x => x).Where(x => x.ProductId>=1 && x.ProductId <= 100).ToList<Product>();
        }
        public List<Product> GetProductsWithCondition()
        {
            return Products.Select(x => x).Where(x => x.ProductId>=15 && x.ProductId <= 30).ToList<Product>();

        }
        public List<Category> GetCategories()
        {
            var categorySelection =
                from item in Categories
                where item.CategoryId >= 101 && item.CategoryId <= 200
                select item;
            return categorySelection.ToList<Category>();
        }
        public List<Category> GetCategoriesWithCondition()
        {
            return Categories.Select(x => x).Where(x => x.CategoryId >= 105 && x.CategoryId <= 125).ToList<Category>();
        }
        public List<Order> GetFirst15Orders()
        {
            return Orders.Select(x => x).OrderBy(x => x.OrderName).Take(15).ToList<Order>();
        }
        public List<Order> GetFirst3Orders (int id )
        {
            return Orders.Select(x => x).OrderBy(x => x.OrderDate).Where(x=>x.ProductsId.Contains(id)).Take(3).ToList<Order>();
        }
        public void PrintProductsWithCategoriew()
        {
            var selection =
                from item in Products
                from item2 in Categories
                where item.CategoryId == item2.CategoryId
                select new { Name = item.Name , ProductCategory = item2.CategoryName };
            foreach(var item in selection)
            {
                Console.WriteLine("{0} from {1}",item.Name,item.ProductCategory);
            }
        }
        public void GroupedProducts()
        {
            var groupSelecion =
                from item in Products
                from item2 in Categories
                where item.CategoryId == item2.CategoryId
                group item by item2.CategoryName into groups
                select new { CategoryName = groups.Key, Groups=groups };
            foreach(var item in groupSelecion)
            {
                Console.WriteLine(item.CategoryName);
                foreach(var item2 in item.Groups)
                {
                    Console.Write(item2.Name+" ");
                }
                Console.WriteLine();
            }
        }
        public void GetOrdersWithProducts()
        {
            var ordersAndProducts=
                from item in Orders
                join 
                select  

        }
        public List<Order> GetOrders()
        {
            var ordersSelection =
                from item in Orders
                where item.OrderId >= 201 && item.OrderId <= 300
                select item;
            return ordersSelection.ToList<Order>();
        }
    }
}
