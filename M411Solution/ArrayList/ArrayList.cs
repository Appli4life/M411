namespace My.Collections
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// ArrayList Generisch
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Liste Generische Items
        /// </summary>
        protected T[] items;

        /// <summary>
        /// Zählung der Items
        /// </summary>
        public int Count { get; private set; } = 0;
        
        /// <summary>
        /// Ctor mit Länge
        /// </summary>
        /// <param name="length">Länge des Array</param>
        public ArrayList(int length)
        {
            items = new T[length == 0 ? 4 : length];
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public ArrayList()
            : this(0)
        {
        }

        /// <summary>
        /// Objekt Hinzufügen
        /// </summary>
        /// <param name="item">Das Objekt zum Hinzufügen</param>
        public void Add(T item)
        {
            grow();

            items[Count] = item;

            Count++;
        }

        /// <summary>
        /// Hinzufügen mehrerer Objekte
        /// </summary>
        /// <param name="items">Liste der Objekte</param>
        public void AddRange(T[] items)
        {
            foreach (T item in items)
                Add(item);
        }

        /// <summary>
        /// Der Index des Objekt
        /// </summary>
        /// <param name="item">Objekt</param>
        /// <returns>Index des Objekt</returns>
        public int IndexOf(T item) 
        {
            return Array.IndexOf<T>(items, item);

            //for(int i = 0; i < Count; i++)
            //{
            //    if(items[i].Equals(item))
            //        return i;
            //}
            //return -1;
        }

        /// <summary>
        /// Objekt an Index Löschen
        /// </summary>
        /// <param name="index">Index</param>
        public void RemoveAt(int index)
        {
            if (index < 0 || index > Count)
                throw new IndexOutOfRangeException();

            // Array zusammenrücken
            Array.Copy(items, index + 1, items, index, Count - (index + 1));

            Count--;
            items[Count] = default(T);
        }

        /// <summary>
        /// Löscht Objekt
        /// </summary>
        /// <param name="item">Objekt</param>
        /// <returns>true/false</returns>
        public bool Remove(T item)
        {
            for(int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Array Leeren
        /// </summary>
        public void Clear()
        {
            items = new T[4];
            Count = 0;
        }

        /// <summary>
        /// Auf Index zugreiffen
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                if (index >= Count)
                    throw new IndexOutOfRangeException();

                return items[index];
            }
            set
            {
                if (index >= Count)
                    throw new IndexOutOfRangeException();

                items[index] = value;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for(int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
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

        /// <summary>
        /// Array vergrössern
        /// </summary>
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