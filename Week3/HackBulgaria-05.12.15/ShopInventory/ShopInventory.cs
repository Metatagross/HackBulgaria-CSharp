using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VATTaxCalculator;

namespace ShopInventory
{
    public class NotAvailableInInventoryException : Exception
    {
        public NotAvailableInInventoryException ( ) { }
        public NotAvailableInInventoryException ( string message ) : base(message) { }
    }
    public class Product
    {
        private readonly int id;
        private readonly string name;
        private readonly decimal untaxed;
        private readonly decimal taxed;
        private int quantity;
        private readonly int country;

        public Product ( int id , string name , decimal untaxed , int quantity , int country , VATTaxCalculator.VATTaxCalculator calculator )
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.country = country;
            this.untaxed = untaxed;
            taxed = calculator.CalculateTax(untaxed , country);
        }
        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public decimal Untaxed
        {
            get
            {
                return untaxed;
            }
        }

        public decimal Taxed
        {
            get
            {
                return taxed;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public int Country
        {
            get
            {
                return country;
            }
        }
    }
    public class Inventory
    {
        private List<Product> listOfProducts;
        public Inventory ( List<Product> products )
        {
            ListOfProducts = new List<Product>(products);
        }
        public List<Product> ListOfProducts
        {
            get
            {
                return listOfProducts;
            }

            set
            {
                listOfProducts = value;
            }
        }
        public decimal Audit ( )
        {
            decimal result = 0;
            foreach(var item in ListOfProducts)
            {
                result += item.Quantity * (item.Taxed - item.Untaxed);
            }
            return result;
        }
        public decimal RequestOrder ( Order order )
        {
            decimal result = 0;
            bool found = false;
            foreach(var item in order.OrderList)
            {
                foreach(var product in ListOfProducts)
                {
                    if(item.Key == product.Id && item.Value <= product.Quantity)
                    {
                        result += item.Value * product.Taxed;
                        found = true;
                    }
                }
                if(!found)
                {
                    throw new NotAvailableInInventoryException("The product is either not found or its amount is bigger than the quantity in the inventory!");
                }
                found = false;
            }
            foreach(var item in order.OrderList)
            {
                foreach(var product in ListOfProducts)
                {
                    if(item.Key == product.Id && item.Value <= product.Quantity)
                    {
                        product.Quantity -= item.Value;
                    }
                }
            }
            return result ;
        }
    }

    public class Order
    {
        Dictionary<int , int> orderList;
        public Order ( Dictionary<int , int> list )
        {
            OrderList = new Dictionary<int , int>(list);
        }

        public Dictionary<int , int> OrderList
        {
            get
            {
                return orderList;
            }

            set
            {
                orderList = value;
            }
        }

    }
}
