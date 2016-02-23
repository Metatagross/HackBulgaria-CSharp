using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LListDefinition<T> : IEnumerable
    {
        private Node head;
        private int counter;
        public LListDefinition ( )
        {
            Counter = 0;
            Head = null;
        }
        public Node Head
        {
            get
            {
                return head;
            }

            set
            {
                head = value;
            }
        }

        public int Counter
        {
            get
            {
                return counter;
            }

            set
            {
                counter = value;
            }
        }

        public class Node
        {
            private T value;
            private Node next;

            public Node ( T v , Node n )
            {
                Value = v;
                Next = n;
            }
            public T Value
            {
                get
                {
                    return value;
                }

                set
                {
                    this.value = value;
                }
            }

            public Node Next
            {
                get
                {
                    return next;
                }

                set
                {
                    next = value;
                }
            }
            public override string ToString ( )
            {
                if(Next == null)
                {
                    return string.Format("{0}" , Value);
                }
                return string.Format("{0}->" , Value);
            }
        }
        public void Add ( T value )
        {
            Node current = Head;
            if(Head == null)
            {
                Head = new Node(value , null);
            }
            else
            {
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(value , null);
            }

            Counter++;
        }
        public bool InsertAfter ( T key , T value )
        {
            Node current = Head;
            while(!current.Value.Equals(key))
            {
                if(current.Next == null)
                {
                    return false;
                }
                current = current.Next;
            }
            Node added = new Node(value , current.Next);
            current.Next = added;
            Counter++;
            return true;
        }
        public bool InsertBefore ( T key , T value )
        {
            if(head.Value.Equals(key))
            {
                Node exHead = head;
                head = new Node(value , exHead);
                return true;
            }
            Node previous = Head;
            Node current = Head;
            while(!current.Value.Equals(key))
            {
                if(current.Next == null)
                {
                    return false;
                }
                previous = current;
                current = current.Next;
            }
            Node added = new Node(value , current);
            previous.Next = added;
            Counter++;
            return true;
        }
        public bool InsertAt ( int index , T value )
        {
            if(index > Counter)
            {
                return false;
            }
            int helper = 0;
            Node current = Head;
            while(helper != index - 1)
            {
                if(current.Next == null)
                {
                    return false;
                }
                helper++;
                current = current.Next;
            }
            current.Next = new Node(value , current.Next);
            Counter++;
            return true;
        }
        public bool Remove ( T value )
        {
            if(head.Value.Equals(value))
            {
                head = head.Next;
                return true;
            }
            Node current = Head;
            Node previous = Head;
            while(!current.Value.Equals(value))
            {
                if(current.Next == null)
                {
                    return false;
                }
                previous = current;
                current = current.Next;
            }
            previous.Next = current.Next;
            Counter--;
            return true;
        }
        public bool RemoveAt ( int index )
        {
            if(index > Counter || index < 0)
            {
                return false;
            }
            if(index == 0)
            {
                Head = Head.Next;
                return true;
            }
            int helper = 0;
            Node current = Head;
            while(helper != index - 1)
            {
                if(current.Next == null)
                {
                    return false;
                }
                current = current.Next;
            }
            current.Next = current.Next.Next;
            Counter--;
            return true;
        }
        public void Clear ( )
        {
            Node current = Head;
            Node after;
            while(current.Next != null)
            {
                after = current.Next;
                current.Next = null;
                current = after;
            }
            Head = null;
            Counter = 0;
        }

        public IEnumerator GetEnumerator ( )
        {
            Node current = Head;
            while(current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        public T this[int index]
        {
            get
            {
                if(index > Counter)
                {
                    throw new InvalidOperationException("Index out of range!");
                }
                int helper = 0;
                Node current = Head;
                while(helper != index)
                {
                    current = current.Next;
                }
                return current.Value;
            }
            set
            {

                if(index > Counter)
                {
                    throw new InvalidOperationException("Index out of range!");
                }
                int helper = 0;
                Node current = Head;
                while(helper != index)
                {
                    current = current.Next;
                    helper++;
                }
                current.Value = value;
            }
        }

    }
}
