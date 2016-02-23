using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    class Program
    {
        static void Main ( string[] args )
        {
            Employee e = new Employee() { FirstName = "Ivan" , LastName = "Ivanov" , Position = "Manager" , Salary = 2400 , Bonus = 300 };
            Console.WriteLine(e.CalculateAllIncome());
            Console.WriteLine(e.CalculateBalance());
        }
    }
}
