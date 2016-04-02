using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StylishCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string op1 = null;
        private string op2 = null;
        private char sign = default(char);
        private string result = null;
        public MainWindow ( )
        {
            InitializeComponent();
        }
        private void Num_Clicked ( object sender , RoutedEventArgs e )
        {
            switch(((Button)sender).Name)
            {
                case "One":
                    Txt1.Text += "1";
                    break;
                case "Two":
                    Txt1.Text += "2";
                    break;
                case "Three":
                    Txt1.Text += "3";
                    break;
                case "Four":
                    Txt1.Text += "4";
                    break;
                case "Five":
                    Txt1.Text += "5";
                    break;
                case "Six":
                    Txt1.Text += "6";
                    break;
                case "Seven":
                    Txt1.Text += "7";
                    break;
                case "Eight":
                    Txt1.Text += "8";
                    break;
                case "Nine":
                    Txt1.Text += "9";
                    break;
                case "Zero":
                    Txt1.Text += "0";
                    break;
                case "Dot":
                    if(!Txt1.Text.Contains(",") || (Txt1.Text.Contains(",") && sign != default(Char)))
                        Txt1.Text += ",";
                    break;
            }
        }
        private void Sign_Clicked ( object sender , RoutedEventArgs e )
        {
            if(sign != default(char))
            {
                int index = Txt1.Text.LastIndexOf(sign);
                op2 = Txt1.Text.Substring(index + 1);
                Equals_Clicked(new object() , new RoutedEventArgs());
            }
            else
            {
                op1 = Txt1.Text;
            }

            switch(((Button)sender).Name)
            {
                case "Plus":
                    sign = '+';
                    Txt1.Text += "+";
                    break;
                case "Minus":
                    sign = '-';
                    Txt1.Text += "-";
                    break;
                case "Divide":
                    sign = '/';
                    Txt1.Text += "/";
                    break;
                case "Product":
                    sign = '*';
                    Txt1.Text += "*";
                    break;
            }
        }
        private void Equals_Clicked ( object sender , RoutedEventArgs e )
        {
            int index = Txt1.Text.LastIndexOf(sign);
            if(op2 == null)
            {
                op2 = Txt1.Text.Substring(index + 1);
            }

            double num1, num2;
            double.TryParse(op1 , out num1);
            double.TryParse(op2 , out num2);

            switch(sign)
            {
                case '+':
                    result = (num1 + num2).ToString();
                    break;

                case '-':
                    result = (num1 - num2).ToString();
                    break;

                case '*':
                    result = (num1 * num2).ToString();
                    break;

                case '/':
                    if(num2 != 0)
                    {
                        result = (num1 / num2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Can't divide by zero");
                        result = double.NaN.ToString();
                    }
                    break;
            }
            op1 = result;
            sign = default(char);
            op2 = null;
            Txt1.Text = result.ToString();
        }
        private void Control_Clicked(object sender, RoutedEventArgs e)
        {
            op1 = null;
            op2 = null;
            sign = default(char);
            Txt1.Text = null;
        }
    }
}
