using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class Employee
    {
        public const decimal  taxPercentage = (decimal)(0.2);
        partial void Print ( )
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
        public decimal CalculateAllIncome ( )
        {
            Print();
            return Salary + Bonus;
        }
        public decimal CalculateBalance ( )
        {
            return CalculateAllIncome() - CalculateAllIncome() * taxPercentage;
        }
    }
}
