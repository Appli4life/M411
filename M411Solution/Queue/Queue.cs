namespace My.Collections
{
    using System;

    public class Queue<T> : ICollection
    {
        private T[] items;

        public int Count { get; private set; }
        
        public Queue(int length)
        {
            items = new T[length == 0 ? 10 : length];
        }

        public Queue()
            : this(0)
        {
        }

        public void Enqueue(T item)
        {
            grow();

            items[Count] = item;

            Count++;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("No items in queue.");

            return items[0];
        }

        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException("No items in queue.");

            T item = items[0];

            Array.Copy(items, 1, items, 0, Count - 1);

            items[Count - 1] = default(T);
            
            Count--;

            return item;
        }

        public void Clear()
        {
            items = new T[10];
            Count = 0;
        }

        public override string ToString()
        {
            string s = "";

            for(int i = 0; i < Count; i++)
            { 
                s += items[i].ToString() + " -> ";
            }
            s += "Count: " + Count.ToString();

            return s;
        }

        private void grow()
        {
            // Überprüfen, ob noch Platz
            if (items.Length >= Count + 1)
                return;

            // Array-Kapazität verdoppeln
            int newLength = items.Length * 2;

            Array.Resize(ref items, newLength);            
        }
    }
}