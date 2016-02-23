using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class NotifyCollection<T> : INotifyPropertyChanged, IList<T>
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly IList<T> list;

        public NotifyCollection ( )
        {
            list = new List<T>();
        }
        public IList<T> List
        {
            get
            {
                return list;
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return true;
            }
        }

        public T this[int index]
        {
            get
            {
                return list[index];
            }

            set
            {
                list[index] = value;
            }
        }

        public void Add ( T value )
        {
            list.Add(value);
            if(PropertyChanged != null)
            {
                PropertyChanged(this , new PropertyChangedEventArgs(string.Format("{0} was added" , value.ToString())));
            }
        }
        public void Insert ( int index , T value )
        {
            list.Insert(index , value);
            if(PropertyChanged != null)
            {
                PropertyChanged(this , new PropertyChangedEventArgs(string.Format("{0} was inserted at index {1}" , value.ToString() , index)));
            }
        }
        public bool Remove ( T value )
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this , new PropertyChangedEventArgs(string.Format("{0} was removed" , value.ToString())));
            }
            return list.Remove(value);

        }
        public void RemoveAt ( int index )
        {
            T removed = list[index];
            list.RemoveAt(index);
            if(PropertyChanged != null)
            {
                PropertyChanged(this , new PropertyChangedEventArgs(string.Format("{0} at index {1} was removed" , removed.ToString() , index)));
            }
        }
        public void Replace ( int index , T value )
        {
            if(list[index].Equals(value))
            {
                return;
            }
            T oldValue = list[index];
            list[index] = value;
            if(PropertyChanged != null)
            {
                PropertyChanged(this , new PropertyChangedEventArgs(string.Format("{0} was replaced with {1}" , oldValue , value)));
            }
        }

        public int IndexOf ( T item )
        {
            for(int i = 0 ; i < list.Count ; i++)
            {
                if(list[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Clear ( )
        {
            list.Clear();
        }

        public bool Contains ( T item )
        {
            if(list.Contains(item))
            {
                return true;
            }
            return false;
        }

        public void CopyTo ( T[] array , int arrayIndex )
        {
            for(int i = arrayIndex, j = 0 ; i < array.Length ; i++, j++)
            {
                array[i] = list[j];
            }
        }

        public IEnumerator<T> GetEnumerator ( )
        {
            return List.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator ( )
        {
            return List.GetEnumerator();
        }
    }
}
