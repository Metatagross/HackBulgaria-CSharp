using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        public static List<int> GetProductIDs ( List<Product> p )
        {
            return p.Select(x => x.ProductId).ToList<int>();
        }
        public static void Display ( List<Category> categories )
        {
            foreach(var item in categories)
            {
                Console.WriteLine("{0} - {1}" , item.CategoryId , item.CategoryName);
            }
        }
        public static void Display ( List<Product> products )
        {
            foreach(var item in products)
            {
                Console.WriteLine("{0} - {1} - {2}" , item.CategoryId , item.ProductId , item.Name);
            }
        }
        static void Main ( string[] args )
        {
            List<Category> categories = new List<Category>
            {
                new Category("Food", 11),
                new Category("Drink", 101),
                new Category("Book", 1001),
                new Category("Make-up", 15),
                new Category("Clothing", 105),
                new Category("Furniture", 1005),
                new Category("Car", 18),
                new Category("Equipment",108),
                new Category("Utensils",1008)
            };
            List<Product> products = new List<Product>
            {
                new Product("Orange", 15, 11),
                new Product("Cucumber", 16,11),
                new Product("Bread", 17,11),
                new Product("Banana", 18,11),
                new Product("Water",150,101 ),
                new Product("Coca-Cola", 160,101),
                new Product("Milk", 170,101),
                new Product("Chair", 250,1005),
                new Product("Table", 260,1005),
                new Product("Wardrobe", 270,1005),
                new Product("Harry Potter", 350,1001),
                new Product("C# for Dummies", 360,1001),
                new Product("HackBulgaria's history", 370,1001),
                new Product("Lipstick", 450,15),
                new Product("Rouge",460,15),
                new Product("Brush", 470,15),
                new Product("Mercedes", 550,18),
                new Product("BMW", 560,18),
                new Product("Audi", 570,18),
                new Product("Shirt",650,105),
                new Product("Dress", 660,105),
                new Product("Shoes", 670,105),
                new Product("Spoons",750,1008),
                new Product("Forks", 760,1008),
                new Product("Pan", 770,1008),
                new Product("Plates",780,1008),
                new Product("Pot",790,1008),
                new Product("Hammer", 850,108),
                new Product("Screwdriver", 860,108),
                new Product("Nails",870,108),
                new Product("Shovel", 880,108),
                new Product("Pincers", 890,108)
            };
            Random r = new Random();
            List<Order> orders = new List<Order>
            {
                new Order(1,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(2,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(3,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(204,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(205,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(206,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(307,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(308,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(309,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(410,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(411,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(412,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(513,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(514,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(515,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(616,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(617,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(618,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(719,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(720,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(721,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(822,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),
                new Order(823,GetProductIDs(products).OrderBy(x=>r.Next()).Take(5).ToList<int>()),

            };
            //foreach(var item in orders)
            //{
            //    item.Display(products);
            //}
            Console.WriteLine();
            Archive ar = new Archive(orders , products , categories);
            List<Category> sortedCategories = ar.GetCategories();
            List<Category> sortedCategoriesWithCondition = ar.GetCategoriesWithCondition();
            List<Product> sortedProducts = ar.GetProducts();
            List<Product> sortedProductsWithCondition = ar.GetProductsWithCondition();
            List<Order> sortedOrders = ar.GetOrders();
            List<Order> first15Orders = ar.GetFirst15Orders();
            List<Order> first3Orders = ar.GetFirst3Orders(450);
            Display(sortedCategories);
            Console.WriteLine();
            Display(sortedCategoriesWithCondition);
            Console.WriteLine();
            Display(sortedProducts);
            Console.WriteLine();
            Display(sortedProductsWithCondition);
            Console.WriteLine();
            foreach(var item in sortedOrders)
            {
                item.Display(products);
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach(var item in first15Orders)
            {
                item.Display(products);
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach(var item in first3Orders)
            {
                item.Display(products);
                Console.WriteLine();
            }
            Console.WriteLine();
            ar.PrintProductsWithCategoriew();
            Console.WriteLine();
            ar.GroupedProducts();
            
            Console.ReadKey();
        }
    }
}
