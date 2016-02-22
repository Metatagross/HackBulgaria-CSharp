using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Vector
    {
        private double[] vector;
        public Vector ( ) : this(0 , 0 , 0) { }
        public Vector ( params double[] numbers )
        {
            vector = new double[numbers.Length];
            for(int i = 0 ; i < numbers.Length ; i++)
            {
                VectorA[i] = numbers[i];
            }
        }
        public Vector ( Vector v ) : this(v.VectorA) { }
        public double this[int index]
        {
            get
            {
                return VectorA[index];
            }
            set
            {
                VectorA[index] = value;
            }
        }
        public double[] VectorA
        {
            get
            {
                return vector;
            }
            set
            {
                vector = new double[value.Length];
                for(int i = 0 ; i < value.Length ; i++)
                {
                    vector[i] = value[i];
                }
            }
        }
        public int Dimensionality
        {
            get
            {
                return VectorA.Length;
            }
        }
        public double Length
        {
            get
            {
                double squares = 0;
                for(int i = 0 ; i < vector.Length ; i++)
                {
                    squares += Math.Pow(VectorA[i] , 2);
                }
                return Math.Sqrt(squares);
            }
        }


        public override string ToString ( )
        {
            StringBuilder name = new StringBuilder();
            name.Append("Vector(");
            for(int i = 0 ; i < VectorA.Length ; i++)
            {
                if(i == VectorA.Length - 1)
                {
                    name.Append(VectorA[i] + ")");
                }
                else
                {
                    name.Append(VectorA[i] + " , ");
                }
            }
            return name.ToString();
        }
        public override bool Equals ( object obj )
        {
            if(obj == null || !(obj is Vector))
            {
                return false;
            }
            else
            {
                Vector objEx = (Vector)obj;
                if(Dimensionality != objEx.Dimensionality)
                {
                    return false;
                }
                for(int i = 0 ; i < Dimensionality ; i++)
                {
                    if(VectorA[i] != objEx[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool operator ==( Vector objA , object objB )
        {
            return Equals(objA , objB);

        }
        public static bool operator !=( Vector objA , object objB )
        {
            return !Equals(objA , objB);
        }
        public override int GetHashCode ( )
        {
            unchecked
            {
                int hash = 17;
                for(int i = 0 ; i < Dimensionality ; i++)
                {
                    hash = 23 * hash + VectorA[i].GetHashCode();
                }
                return hash;
            }
        }
        public static Vector operator +( Vector v1 , Vector v2 )
        {
            if(v1.Dimensionality != v2.Dimensionality)
            {
                throw new InvalidOperationException("Invalid operation! The dimensionalities are different!");
            }
            double[] result = new double[v1.Dimensionality];
            for(int i = 0 ; i < v1.Dimensionality ; i++)
            {
                result[i] = v1[i] + v2[i];
            }
            return new Vector(result);
        }
        public static Vector operator -( Vector v1 , Vector v2 )
        {
            if(v1.Dimensionality != v2.Dimensionality)
            {
                throw new InvalidOperationException("Invalid operation! The dimensionalities are different!");
            }
            double[] result = new double[v1.Dimensionality];
            for(int i = 0 ; i < v1.Dimensionality ; i++)
            {
                result[i] = v1[i] - v2[i];
            }
            return new Vector(result);
        }
        public static double operator *( Vector v1 , Vector v2 )
        {
            if(v1.Dimensionality != v2.Dimensionality)
            {
                throw new InvalidOperationException("Invalid operation! The dimensionalities are different!");
            }
            double result = 0;
            for(int i = 0 ; i < v1.Dimensionality ; i++)
            {
                result += v1[i] * v2[i];
            }
            return result;
        }
        public static Vector operator +( Vector v1 , int scalar )
        {
            double[] result = new double[v1.Dimensionality];
            for(int i = 0 ; i < v1.Dimensionality ; i++)
            {
                result[i] = v1[i] + scalar;
            }
            return new Vector(result);
        }
        public static Vector operator -( Vector v1 , int scalar )
        {
            double[] result = new double[v1.Dimensionality];
            for(int i = 0 ; i < v1.Dimensionality ; i++)
            {
                result[i] = v1[i] - scalar;
            }
            return new Vector(result);
        }
        public static Vector operator *( Vector v1 , int scalar )
        {
            double[] result = new double[v1.Dimensionality];
            for(int i = 0 ; i < v1.Dimensionality ; i++)
            {
                result[i] = v1[i] * scalar;
            }
            return new Vector(result);
        }
        public static Vector operator /( Vector v1 , int scalar )
        {
            double[] result = new double[v1.Dimensionality];
            for(int i = 0 ; i < v1.Dimensionality ; i++)
            {
                result[i] = v1[i] / scalar;
            }
            return new Vector(result);
        }

    }
}
