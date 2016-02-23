using Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegaters;
using System.ComponentModel;

namespace DelegatesTest
{
    class Program
    {
        public static bool IsEven ( int number )
        {
            return number % 2 == 0;
        }

        public static void ChangeList ( object sender , PropertyChangedEventArgs e )
        {
            Console.WriteLine("The list has changed!\n{0}" , e.PropertyName);
        }
        public static void PropChange ( object sender , PropertyChangedEventArgs e )
        {
            Console.WriteLine("The property name {0} was changed!" , e.PropertyName);
        }
        static void Main ( string[] args )
        {
            Delegates del = new Delegates();
            List<int> numbers = new List<int> { 5 , 4 , 8 , 7 , 9 , 6 , 6 , 6 , 3 , 1 , 20 };
            List<int> evens = del.FilterCollection(numbers , IsEven);
            foreach(var item in evens)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            AverageAggregator aggregator = new AverageAggregator();
            aggregator.AverageChanged += delegate ( object sender )
            {
                if(sender is AverageAggregator)
                {
                    AverageAggregator newSender = (AverageAggregator)sender;
                    Console.WriteLine("Average has changed!\nNew value: {0}" , newSender.Average);
                }
            };
            aggregator.AddNumber(6);
            aggregator.AddNumber(4);
            aggregator.AddNumber(2);
            aggregator.AddNumber(3);
            Student stu = new Student();
            stu.PropertyChanged += PropChange;
            stu.Name = "Anton";
            stu.FacultyNumber = 65888;
            stu.Grade = 5.58;

            NotifyCollection<int> newList = new NotifyCollection<int>();
            newList.PropertyChanged += (object sender, PropertyChangedEventArgs e)=>
        {
            Console.WriteLine("The list has changed!\n{0}" , e.PropertyName);
        };
            newList.Add(5);
            newList.Add(12);
            newList.Insert(1 , 20);
            newList.Remove(12);
            Console.ReadKey();
        }
    }
}
