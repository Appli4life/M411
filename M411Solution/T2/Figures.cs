using System;

namespace T2
{
    /// <summary>
    /// Figuren
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Figures<T>
    {
        /// <summary>
        /// Datenfeld
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
        /// Indexer
        /// </summary>
        /// <param name="i">Index</param>
        /// <returns>Action Figur an dem Index</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public T this[int i]
        {
            get
            {
                if (i >= 0 && i < Count)
                {
                    Node node = first;

                    if (i == 0)
                    {
                        return node.Item;
                    }

                    for (int l = 0; l < i; l++)
                    {
                        node = node.Next;
                    }
                    return node.Item;
                }
                throw new IndexOutOfRangeException();
            }
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
        public void Add(T f)
        {
            // Neues Objekt erstellen
            Node newItem = new Node() { Item = f };

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
        /// Löscht ein Objekt aus der Liste
        /// </summary>
        /// <param name="item">Das zu löschende Objekt</param>
        /// <returns>Gelöscht(true), Nicht gefunden(false)</returns>
        public void Remove(T f)
        {
            if (Count == 0)
            {
                return;
            }
            if (first.Item.Equals(f))
            {
                first = first.Next;
                Count--;
                return;
            }

            Node curr = first;

            while (curr.Next != null)
            {
                if (f.Equals(curr.Next.Item))
                {
                    curr.Next = curr.Next.Next;
                    Count--;
                    return;
                }
                curr = curr.Next;
            }
            return;
        }

        /// <summary>
        /// Alle Löschen
        /// </summary>
        public void Clear()
        {
            first = null;
            Count = 0;
        }

        /// <summary>
        /// Index der Actionfigur
        /// </summary>
        /// <param name="f">Actionfigur</param>
        /// <returns>Index der Actionfigur</returns>
        /// <exception cref="Exception"></exception>
        public int IndexOf(T f)
        {
            Node curr = first;
            int i = 0;
            while (curr != null)
            {
                if (f.Equals(curr.Item))
                {
                    return i;
                }

                curr = curr.Next;
                i++;
            }

            throw new Exception("Action Figur nicht gefunden!");
        }
    }
}
