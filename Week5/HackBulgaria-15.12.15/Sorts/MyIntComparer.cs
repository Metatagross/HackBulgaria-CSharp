using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public  class MyIntComparer : IComparer<int>
    {
        public int Compare ( int x , int y )
        {
            return x - y;
        }
    }
    public class OddEvenComparer : IComparer<int?>
    {
        public int Compare ( int? x , int? y )
        {
            return (x == null && y == null) ? 0 : (x == null) ? -1 : (y == null) ? 1 : ((x % 2 + y % 2) % 2 == 1) ? (int)(x % 2 - y % 2) : (x % 2 == 0) ? (int)(x - y) : (x % 2 == 1) ? (int)(y - x) : 0;
        }
    }
    public class StringLengthComparer : IComparer<string>
    {
        public int Compare ( string a , string b )
        {
            return (a ?? String.Empty).Length - (b ?? String.Empty).Length;
        }
    }
    public class LastDigitComparer : IComparer<int>
    {
        public int Compare ( int x , int y )
        {
            return x % 10 - y % 10;
        }
    }
}
