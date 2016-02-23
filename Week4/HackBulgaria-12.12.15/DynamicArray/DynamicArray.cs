using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynamicArray<T>
    {
        private T[] arrayList;
        private int capacity;
        private int count;

        public DynamicArray ( int c )
        {
            arrayList = new T[c];
            capacity = c;
            count = -1;
        }
        public DynamicArray ( ) : this(10) { }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public T[] ArrayList
        {
            get
            {
                return arrayList;
            }

            set
            {
                arrayList = value;
            }
        }

        public bool Contains ( T value )
        {
            for(int i = 0 ; i <= Count ; i++)
            {
                if(arrayList[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
        public int IndexOf ( T value )
        {
            for(int i = 0 ; i < Count ; i++)
            {
                if(arrayList[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Add ( T value )
        {
            if(count == capacity - 1)
            {
                if(capacity <= 2048)
                {
                    arrayList = Resize(2 * capacity);
                }
                else
                {
                    count = 255;
                    arrayList = Resize(256);
                }
            }
            count++;
            arrayList[count] = value;
        }

        public void InsertAt ( int index , T value )
        {
            if(count == capacity - 1)
            {
                if(capacity <= 2048)
                {
                    arrayList = Resize(2 * capacity);
                }
                else
                {
                    count = 255;
                    arrayList = Resize(256);
                }
            }
            for(int i = Count ; i >= index ; i--)
            {
                arrayList[i + 1] = arrayList[i];
            }
            arrayList[index] = value;
            count++;
        }

        public void Remove ( T value )
        {
            if(IndexOf(value) == -1)
            {
                throw new InvalidOperationException("Value cannot be found!");
            }
            if(count * 3 < capacity)
            {
                arrayList = Resize(capacity / 2);
            }
            count--;
            for(int j = IndexOf(value) ; j < Count ; j++)
            {
                arrayList[j] = arrayList[j + 1];
            }
        }
        public void RemoveAt ( int index )
        {
            if(index > count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }
            if(count * 3 < capacity)
            {
                arrayList = Resize(capacity / 2);
            }
            count--;
            for(int j = index ; j <= Count ; j++)
            {
                arrayList[j] = arrayList[j + 1];
            }
        }
        public void Clear ( )
        {
            capacity = 8;
            arrayList = new T[capacity];
            count = -1;
        }
        public T this[int index]
        {
            get
            {
                if(index > count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index!");
                }
                return arrayList[index];
            }
            set
            {
                if(index > count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index!");
                }
                arrayList[index] = value;
            }
        }
        public T[] ToArray ( )
        {
            T[] array = new T[capacity];
            for(int i = 0 ; i <= Count ; i++)
            {
                array[i] = arrayList[i];
            }
            return array;
        }
        private T[] Resize ( int newCapacity )
        {
            capacity = newCapacity;
            T[] newArray = new T[capacity];
            for(int i = 0 ; i <= Count ; i++)
            {
                newArray[i] = arrayList[i];
            }
            return newArray;
        }
    }
}
