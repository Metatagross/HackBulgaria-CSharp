using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Pair
    {
        private Object ob1;
        private Object ob2;

        public Pair(object a, object b)
        {
            ob1 = a;
            ob2 = b;
        }
        public object Ob1
        {
            get
            {
                return ob1;
            }
        }

        public object Ob2
        {
            get
            {
                return ob2;
            }
        }
        public override string ToString ( )
        {
            return ob1.ToString()+" "+ob2.ToString();
        }
        public override bool Equals ( object obj )
        {
            if(obj==null)
            {
                return false;
            }
            else
            {
                Pair objEx = (Pair)obj;
                return ob1.Equals(objEx.ob1) && ob2.Equals(objEx.Ob2);
            }
        }
        public static bool operator==(Pair objA, object objB)
        {
            return objA.Equals(objB);

        }
        public static bool operator!=(Pair objA, object objB)
        {
            return !objA.Equals(objB);
        }
        public override int GetHashCode ( )
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + ob1.GetHashCode();
                hash = hash * 23 + ob2.GetHashCode();
                return hash;
            }
        }
    }
}
