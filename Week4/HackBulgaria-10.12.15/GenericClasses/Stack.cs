using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class Stack<T>
    {
        private T[] stacker;
        private int capacity;
        private int current;

        public Stack ( )
        {
            current = -1;
            Capacity = 2;
            Stacker = new T[Capacity];
        }
        public Stack ( int capacity )
        {
            if(capacity==0)
            {
                Capacity = 1;
            }
            else
            {
                Capacity = capacity;
            }
            current = -1;
            Stacker = new T[Capacity];
        }
        public T[] Stacker
        {
            get
            {
                return stacker;
            }

            set
            {
                stacker = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }

        private T[] ReSize ( )
        {
            T[] resized = null;
            if(current + 1 == capacity)
            {
                resized = new T[2 * capacity];
                for(int i = 0 ; i <= current ; i++)
                {
                    resized[i] = stacker[i];
                }
            }
            else if(current + 1 < capacity / 2)
            {

                resized = new T[capacity / 2];
                for(int i = 0 ; i <= current ; i++)
                {
                    resized[i] = stacker[i];
                }
            }
            return resized;
        }

        public T Peek ( )
        {
            if(current == -1)
            {
                throw new InvalidOperationException("You cannot peek from an empty stack!");
            }
            return Stacker[current];
        }
        public T Pop ( )
        {
            if(current == -1)
            {
                throw new InvalidOperationException("You cannot pop from an empty stack!");
            }
            if(current + 1 < capacity / 2)
            {
                Stacker = ReSize();
            }
            return Stacker[current--];
        }
        public void Push ( T obj )
        {
            if(current + 1 == capacity)
            {
                Stacker = ReSize();
            }
            Stacker[++current] = obj;
        }
        public void Clear ( )
        {
            capacity = 2;
            Stacker = new T[capacity];
            current = -1;
        }
        public bool Contains(T obj)
        {
            for(int i = 0 ; i <= current ; i++)
            {
                if(obj.Equals(stacker[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsEmpty()
        {
            return current == -1 ? true : false;
        }
    }
}
