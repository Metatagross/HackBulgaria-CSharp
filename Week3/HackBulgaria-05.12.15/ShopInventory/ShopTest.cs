using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VATTaxCalculator;

namespace ShopInventory
{
    class ShopTest
    {
        static void Main ( string[] args )
        {
            List<CountryVatTax> countryList = new List<CountryVatTax>();
            countryList.Add(new CountryVatTax(5 , 0.2 , false));
            countryList.Add(new CountryVatTax(7 , 0.7 , false));
            countryList.Add(new CountryVatTax(12 , 0.9 , true));
            countryList.Add(new CountryVatTax(18 , 1.5 , false));
            countryList.Add(new CountryVatTax(25 , 2.0 , false));

            VATTaxCalculator.VATTaxCalculator calculator = new VATTaxCalculator.VATTaxCalculator(countryList);

            List<Product> products = new List<Product>();
            products.Add(new Product(7 , "bread" , (decimal)0.6 , 30 , 5 , calculator));
            products.Add(new Product(8 , "oil" , (decimal)2.5 , 15 , 7 , calculator));
            products.Add(new Product(12 , "coffee" , 4 , 20 , 18 , calculator));
            products.Add(new Product(15 , "milk" , (decimal)1.4 , 10 , 5 , calculator));
            products.Add(new Product(20 , "cheese" , 5 , 15 , 25 , calculator));
            products.Add(new Product(54 , "cigarettes" , 6 , 20 , 12 , calculator));
            products.Add(new Product(62 , "waffles" , 1 , 30 , 7 , calculator));

            Inventory inventory = new Inventory(products);

            Console.WriteLine(inventory.Audit());

            Dictionary<int , int> order = new Dictionary<int , int>();
            order.Add(15 , 1);
            order.Add(7 , 2);
            order.Add(8 , 1);
            order.Add(20 , 5);
            order.Add(54 , 4);
            order.Add(62 , 15);
            order.Add(12 , 2);

            Order orderO = new Order(order);

            Console.WriteLine( inventory.RequestOrder(orderO));
            Console.ReadKey();
        }
    }
}
