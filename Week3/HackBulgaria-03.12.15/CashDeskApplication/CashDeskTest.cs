using CashDesk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDeskApplication
{
    class CashDeskTest
    {

        static void Main ( string[] args )
        {
           CashDesk.CashDesk desk = new CashDesk.CashDesk();
            bool checkForExit = false;
            while(true)
            {
                Console.WriteLine("takebill < number > -adds a bill with value < number > to the cashdesk");
                Console.WriteLine("takebatch < number1 > < number2 > ... - adds a batch of bills to the cashdesk");
                Console.WriteLine("total - prints the total money in the cash desk");
                Console.WriteLine("inspect - prints detailed information of the money in the cashdesk");
                Console.WriteLine("exit - exits the application");
                string command = Console.ReadLine();
                string[] words = command.Split(new char[] { ' ' } , StringSplitOptions.RemoveEmptyEntries);
                switch(words[0])
                {
                    case "takebill": desk.TakeMoney(new Bill(int.Parse(words[1]))); Console.WriteLine("Added!"); break;
                    case "takebatch":
                        for(int i = 1 ; i < words.Length ; i++)
                        {
                            desk.TakeMoney(new Bill(int.Parse(words[i]))); 
                        }
                        Console.WriteLine("Added!");
                        break;
                    case "total": Console.WriteLine(desk.Total()); break;
                    case "inspect": desk.Inspect(); break;
                    case "exit": checkForExit = true; break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        break;
                }
                if(checkForExit)
                {
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void Tests ( )
        {
            var a = new Bill(10);
            var b = new Bill(5);
            var c = new Bill(10);

            Console.WriteLine((int)a); //10
            Console.WriteLine(a); // "A 10$ bill"
            Console.WriteLine(a == b); //False
            Console.WriteLine(a == c); //True
            Console.WriteLine();
            var bills = new List<Bill> { new Bill(10) , new Bill(20) , new Bill(50) , new Bill(100) };
            var batch = new BatchBill(bills);

            foreach(var bill in batch)
            {
                Console.WriteLine(bill);
            }

            // A 10$ bill
            // A 20$ bill
            // A 50$ bill
            // A 100$ bill
            Console.WriteLine("Batch test passed!");
            var billsForCashDesk = new Bill[] { new Bill(10) , new Bill(20) , new Bill(50) , new Bill(100) , new Bill(100) };
            var batchForCashDesk = new BatchBill(billsForCashDesk);

            CashDesk.CashDesk desk = new CashDesk.CashDesk();

            desk.TakeMoney(new Bill(100));
            desk.TakeMoney(batchForCashDesk);
            desk.TakeMoney(new Bill(10));

            Console.WriteLine(desk.Total()); // 390
            desk.Inspect();

            // We have a total of 390$ in the desk
            // We have the following count of bills, sorted in ascending order:
            // 10$ bills - 2
            // 20$ bills - 1
            // 50$ bills - 1
            // 100$ bills - 3
        }
    }
}
