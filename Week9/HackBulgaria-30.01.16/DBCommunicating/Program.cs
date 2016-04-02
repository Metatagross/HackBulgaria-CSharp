using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Globalization;

namespace DBCommunicating
{
    public class Program
    {
        static void Main ( string[] args )
        {
            DataBaseController controller = new DataBaseController();
            Orders o = new Orders(16 , new DateTime(2015 , 01 , 29) , 18 , 7);
            controller.AddOrder(o);
            Console.ReadKey();
        }
    }
}
