using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListSimple
{
    public class ArrayListSimple
    {
        protected int[] _items;

        public int Count { get; set; }

        public void Add(int item)
        {
            // Das mitgegebene item an lezter Stelle des Arrays schreiben, Zählen
            _items[Count] = item;
            Count++;
        }

        public void Clear()
        {
            // Alle Item in dem Array löschen

            Array.Clear(_items, 0, _items.Count());
            
            this.Count = 0;
        }

        public int GetAt(int index)
        {
            return _items[index];
        }

        public ArrayListSimple()
        {
            _items = new int[10];
        }

        public ArrayListSimple(int length)
        {
            _items = new int[length];
        }



    }
}
