using DynamicArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    public class Map<T,U>
    {
        private readonly DynamicArray<T> keys;
        private readonly DynamicArray<U> values;
        public Map()
        {
            keys = new DynamicArray<T>();
            values = new DynamicArray<U>();
        }

        public DynamicArray<T> Keys
        {
            get
            {
                return keys;
            }
        }

        public DynamicArray<U> Values
        {
            get
            {
                return values;
            }
        }

        public void Add(T key, U value)
        {
            Keys.Add(key);
            Values.Add(value);
        }
        public bool ContainsKey(T key)
        {
            return Keys.Contains(key);
        }
        public bool ContainsValue ( U value )
        {
            return Values.Contains(value);
        }
        public void Remove(T key)
        {
            Values.RemoveAt(Keys.IndexOf(key));
            Keys.Remove(key);
        }
        public void Clear()
        {
            Keys.Clear();
            Values.Clear();
        }
        public U this[T key]
        {
            get
            {
                if(!Keys.Contains(key))
                {
                    throw new ArgumentOutOfRangeException("Invalid key!");
                }
                return Values[Keys.IndexOf(key)];
            }
            set
            {
                if(!Keys.Contains(key))
                {
                    Add(key , value);
                }
                else
                {
                    Values[Keys.IndexOf(key)] = value;
                }
            }
        }
    }
}
