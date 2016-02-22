using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBalance
{
    class BalanceTesting
    {
        public static void BankManager ( string text , DateTime start , DateTime end )
        {
            string[] strings = text.Split(';','\n','\r');
            DateTime[] dates = new DateTime[strings.Length];
            double plus = 0;
            double minus = 0;
            int dateCounter = 0;
            for(int i = 0 ; i < strings.Length ; i++)
            {
                if(DateTime.TryParse(strings[i] , out dates[dateCounter]))
                {
                    if(dates[dateCounter] >= start && dates[dateCounter] <= end)
                    {
                        if(strings[i + 1] == "теглене")
                        {
                            minus+= double.Parse(strings[i + 2].Substring(0 , strings[i + 2].Length - 2).Replace('.' , ','));
                        }
                        else
                        {
                            plus += double.Parse(strings[i + 2].Substring(0 , strings[i + 2].Length - 2).Replace('.' , ','));
                        }
                    }
                }
                dateCounter++;
            }
            Console.WriteLine("Withdraw: {0:C} \n Deposit:  {1:C} \n  Balance:  {2:C}", minus, plus, plus-minus);
        }
        static void Main ( string[] args )
        {
            string text = File.ReadAllText("C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects\\HackBulgaria-26.11.15\\BankAccountBalance\\BankLog.txt");
            BankManager(text , new DateTime(2015 , 03 , 01) , new DateTime(2015 , 04 , 05));
            Console.ReadKey();
        }
    }
}
