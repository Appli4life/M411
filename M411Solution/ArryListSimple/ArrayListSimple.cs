using System;
using System.Linq;

namespace ArrayListSimple
{
    public class ArrayListSimple
    {
        protected int[] _items;

        public int Count { get; set; } = 0;

        public void Add(int item)
        {
            // Das mitgegebene item an lezter Stelle des Arrays schreiben, Zählen
            if (Count < _items.Length)
            {
                _items[Count] = item;
                Count++;
            }
            else
            {
                throw new IndexOutOfRangeException("Array ist voll!");
            }
        }

        public void Clear()
        {
            // Alle Item in dem Array löschen
            Array.Clear(_items, 0, _items.Count());
            this.Count = 0;
        }

        public int GetAt(int index)
        {
            if (index >= 0 && index < _items.Length)
            {
                return _items[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Falscher Index");
            }
        }

        public ArrayListSimple()
        {
            _items = new int[10];
        }

        public ArrayListSimple(int length)
        {
            if (length > 0)
            {
                _items = new int[length];
            }
            else
            {
                throw new Exception("Länge muss grösser 0 sein!");
            }
        }
    }
}
