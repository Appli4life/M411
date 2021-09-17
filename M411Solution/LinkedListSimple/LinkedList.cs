using System;

namespace LinkedListSimple
{
    /// <summary>
    /// Generische Liste
    /// </summary>
    public class LinkedList<T>
    {
        /// <summary>
        /// Inhalt der Liste, Jedes Objekt, dass man in dieser Liste instanziieren kann, hat das Objekt in sich und eine referenz auf das nächste 
        /// </summary>
        private sealed class Node
        {
            /// <summary>
            /// Das Objekt
            /// </summary>
            public T Item { get; set; }

            /// <summary>
            /// Das Nächste Objekt
            /// </summary>
            public Node Next { get; set; } = null;
        }

        /// <summary>
        /// Von der Liste das erste Objekt
        /// </summary>
        private Node first = null;

        /// <summary>
        /// Von der Liste das letzte Objekt
        /// </summary>
        private Node last = null;

        /// <summary>
        /// Die Zählung der Objekten
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Objekt zur liste Hinzufügen
        /// </summary>
        /// <param name="item">Das Objekt das Hinzugefügt wird</param>
        public void Add(T item)
        {
            // Neues Objekt erstellen
            Node newItem = new Node() { Item = item };

            // Wenn es das erste Objekt ist
            if (first == null)
            {
                // Erstes und Letztes Objekt in der Liste = neues setzen
                first = newItem;
                last = newItem;
            }
            else
            {
                // Letztes Objekt.Next = neues 
                last.Next = newItem;
                last = newItem;
            }
            Count++;
        }

        /// <summary>
        /// Überprüft ob das eingegebene Objekt in der Liste vorhanden ist
        /// </summary>
        /// <param name="item">Objekt zur Prüfen</param>
        /// <returns>Vorhanden(true), Nicht Vorhanden(false)</returns>
        public bool Contains(T item)
        {
            if (this.Find(item) != null)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Löscht ein Objekt aus der Liste
        /// </summary>
        /// <param name="item">Das zu löschende Objekt</param>
        /// <returns>Gelöscht(true), Nicht gefunden(false)</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public bool Remove(T item)
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (first.Item.Equals(item))
            {
                first = first.Next;
                Count--;
                return true;
            }

            Node curr = first;

            while (curr.Next != null)
            {
                if (item.Equals(curr.Next.Item))
                {
                    if(curr.Next == last)
                    {
                        last = curr;
                    }
                    curr.Next = curr.Next.Next;
                    Count--;
                    return true;
                }

                curr = curr.Next;
            }

            return false;
        }

        /// <summary>
        /// Findet ein Objekt in der Liste
        /// </summary>
        /// <param name="item">Das zufindende Objekt</param>
        /// <returns>Das Gefundene Objekt (null = nicht Gefunden)</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        private Node Find(T item)
        {
             if (Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            Node curr = first;

            while (curr != null)
            {
                if (item.Equals(curr.Item))
                {
                    return curr;
                }

                curr = curr.Next;
            }

            return null;
        }

        /// <summary>
        /// Finden Anhand der Stelle
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Objekt an der Stelle</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public T FindByIndex(int index)
        {
            if (index > Count || index < 1)
            {
                throw new IndexOutOfRangeException();
            }
            Node node = first;

            for (int i = 1; i < index; i++)
            {
                node = node.Next;
            }

            return node.Item;
        }

        /// <summary>
        /// Alle Löschen
        /// </summary>
        public void Clear()
        {
            first = null;
            Count = 0;
        }


        public override string ToString()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException();
            }

            string s = "";
            Node node = first;

            while (true)
            {

                if (node.Next == null)
                {
                    s += node.Item.ToString();
                    break;
                }

                s += node.Item.ToString() + " -> ";
                node = node.Next;
            }
            s += ", Count: " + Count.ToString();

            return s;
        }

    }
}
