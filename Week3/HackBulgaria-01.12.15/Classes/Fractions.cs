using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Fractions
    {
        private int nominator;
        private int denominator;

        public Fractions ( ) : this(1 , 1) { }
        public Fractions ( int nominator , int denominator )
        {
            int nokA = 2;
            while(nokA <= Math.Abs(nominator) && nokA < denominator)
            {
                if(nominator % nokA == 0 && denominator % nokA == 0)
                {
                    nominator /= nokA;
                    denominator /= nokA;
                    nokA = 1;
                }
                nokA++;
            }
            Nominator = nominator;
            Denominator = denominator;
        }

        public int Nominator
        {
            get
            {
                return nominator;
            }

            set
            {
                nominator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }

            set
            {

                if(value == 0)
                {
                    throw new ArgumentException("The denominator cannot be 0!");
                }
                else
                {
                    denominator = value;
                }
            }
        }
        public override string ToString ( )
        {
            return string.Format("{0}/{1}" , nominator , denominator);
        }
        public override bool Equals ( object obj )
        {
            if(obj == null)
            {
                return false;
            }
            else
            {
                Fractions objEx = (Fractions)obj;
                return nominator == objEx.nominator && denominator == objEx.denominator;
            }
        }
        public static bool operator ==( Fractions objA , object objB )
        {
            return objA.Equals(objB);

        }
        public static bool operator !=( Fractions objA , object objB )
        {
            return !objA.Equals(objB);
        }
        public override int GetHashCode ( )
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + nominator.GetHashCode();
                hash = hash * 23 + denominator.GetHashCode();
                return hash;
            }
        }
        public static Fractions operator +( Fractions a , Fractions b )
        {
            Fractions result = new Fractions(a.nominator * b.denominator + b.nominator * a.denominator , a.denominator * b.denominator);
            int nokA = 2;
            while(nokA <= result.nominator && nokA < result.denominator)
            {
                if(result.nominator % nokA == 0 && result.denominator % nokA == 0)
                {
                    result.nominator /= nokA;
                    result.denominator /= nokA;
                    nokA = 1;
                }
                nokA++;
            }
            return result;
        }
        public static Fractions operator -( Fractions a , Fractions b )
        {
            Fractions result = new Fractions(a.nominator * b.denominator - b.nominator * a.denominator , a.denominator * b.denominator);
            int nokA = 2;
            while(nokA <= Math.Abs(result.nominator) && nokA < result.denominator)
            {
                if(result.nominator % nokA == 0 && result.denominator % nokA == 0)
                {
                    result.nominator /= nokA;
                    result.denominator /= nokA;
                    nokA = 1;
                }
                nokA++;
            }
            return result;
        }
        public static Fractions operator *( Fractions a , Fractions b )
        {
            Fractions result = new Fractions(a.nominator * b.nominator , a.denominator * b.denominator);
            int nokA = 2;
            while(nokA < result.nominator && nokA < result.denominator)
            {
                if(result.nominator % nokA == 0 && result.denominator % nokA == 0)
                {
                    result.nominator /= nokA;
                    result.denominator /= nokA;
                    nokA = 1;
                }
                nokA++;
            }
            return result;
        }
        public static Fractions operator /( Fractions a , Fractions b )
        {
            Fractions result = new Fractions(a.nominator * b.denominator , a.denominator * b.nominator);
            int nokA = 2;
            while(nokA < result.nominator && nokA < result.denominator)
            {
                if(result.nominator % nokA == 0 && result.denominator % nokA == 0)
                {
                    result.nominator /= nokA;
                    result.denominator /= nokA;
                    nokA = 1;
                }
                nokA++;
            }
            return result;
        }
        public static double operator +( Fractions a , double b )
        {
            return ((double)a.nominator / (double)a.denominator) + b;

        }
        public static double operator -( Fractions a , double b )
        {
            return ((double)a.nominator / (double)a.denominator) - b;

        }
        public static double operator *( Fractions a , double b )
        {
            return ((double)a.nominator / (double)a.denominator) * b;

        }
        public static double operator /( Fractions a , double b )
        {
            return ((double)a.nominator / (double)a.denominator) / b;
        }
        public static explicit operator double ( Fractions fract )
        {
            return (double)fract.nominator / (double)fract.denominator;
        }
    }
}
