using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Pair<T1, T2>
    {
        private T1 ob1;
        private T2 ob2;

        public Pair(T1 a, T2 b)
        {
            ob1 = a;
            ob2 = b;
        }
        public T1 Ob1
        {
            get
            {
                return ob1;
            }
        }

        public T2 Ob2
        {
            get
            {
                return ob2;
            }
        }
        public override string ToString ( )
        {
            return "Pair"+ob1.ToString()+" "+ob2.ToString();
        }
        public override bool Equals ( object obj )
        {
            if(obj==null)
            {
                return false;
            }
            else
            {
                Pair<T1,T2> objEx = (Pair<T1, T2>)obj;
                return ob1.Equals(objEx.ob1) && ob2.Equals(objEx.Ob2);
            }
        }
        public static bool operator==(Pair<T1, T2> objA, object objB)
        {
            return objA.Equals(objB);

        }
        public static bool operator!=(Pair<T1, T2> objA, object objB)
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
