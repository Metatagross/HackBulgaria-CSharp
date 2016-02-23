using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class Dequeue<T>
    {
        private List<T> queue;
        public Dequeue()
        {
            queue = new List<T>();
        }
        public void Clear()
        {
            queue.Clear();
        }
        public bool Contains ( T obj )
        {
            foreach(var item in queue)
            {
                if(obj.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public T RemoveFromEnd()
        {
            T last = queue.Last();
            queue.Remove(queue.Last());
            return last;
        }
        public T RemoveFromFront ( )
        {
            T first = queue[0];
            queue.Remove(queue[0]);
            return first;
        }
        public void AddToFront(T obj)
        {
            queue.Insert(0 , obj);
        }
        public void AddToEnd ( T obj )
        {
            queue.Add(obj);
        }
        public T PeekToFront()
        {
            return queue[0];
        }
        public T PeekToEnd()
        {
            return queue.Last();
        }
    }
}
