using System.Collections.Generic;

namespace _13.LinkedQueue
{
    public class LinkedQueue<T>
    {
        private LinkedList<T> items;
        private int size;

        public LinkedQueue()
        {
            items = new LinkedList<T>();
            size = 0;
        }

        public int Count
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public void Enqueue(T item)
        {
            if (Count == 0)
            {
                items.AddFirst(item);
            }
            else
            {
                items.AddAfter(items.Last, item);
            }
            Count++;
        }

        public T Dequeue()
        {
            T item;
            item = items.First.Value;
            items.Remove(item);
            Count--;
            return item;
        }
    }
}
