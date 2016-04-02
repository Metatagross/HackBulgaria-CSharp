using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem;
using System.Data.Entity;

namespace DBTest
{
    class Program
    {
        static void Main ( string[] args )
        {
            using(var db = new TicketSystemModel())
            {
                //db.Database.Create();
                Console.WriteLine("Enter a name of a city:");
                string name = Console.ReadLine();
                City city = new City() { CityID = 1 , Name = name };
                db.Cities.Add(city);
                db.SaveChanges();
            }
        }
    }
}
