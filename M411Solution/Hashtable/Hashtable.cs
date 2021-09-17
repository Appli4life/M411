namespace My.Collections
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Hashtable<TKey, TValue>
    {
        internal class Pair<TPairKey, TPairValue>
        {
            public TPairKey Key { get; private set; } // key nicht nachträglich ändern
            public TPairValue Value { get; set; }

            public Pair(TPairKey key, TPairValue value)
            {
                Key = key;
                Value = value;
            }
        }

        private ArrayList<Pair<TKey, TValue>>[] items;

        public int Count { get; private set; }

        public double LoadFactor 
        { 
            get
            {
                int buckets = 0;

                foreach (var pairs in items)
                {
                    if (pairs != null)
                        buckets++;
                }
                
                return 1.0 - ((items.Length - buckets) / (double)items.Length);
            }
        }

        // durchschnittlicher Belegungsfaktor
        public double OccupationFactor
        {
            get
            {
                int buckets = 0;

                foreach (var pairs in items)
                {
                    if (pairs != null)
                        buckets++;
                }

                return (double)Count / buckets;
            }
        }

        public Hashtable(int length = 0)
        {
            length = length == 0 ? 500 : length;    // keine Verdopplung, da eigentlich Daten in ArrayList

            length = calcPrimeLength(length);

            items = new ArrayList<Pair<TKey, TValue>>[length];
        }

        public void Add(TKey key, TValue value)
        {
            if (ContainsKey(key))
                throw new ArgumentException("Item already exist in collection.");

            int hash = getHash(key);

            var list =  items[hash];

            if (list == null)    // Liste mit Werten existiert noch nicht
            {
                list = new ArrayList<Pair<TKey, TValue>>();
                items[hash] = list;
            }

            list.Add(new Pair<TKey, TValue>(key, value)); 

            Count++;
        }

        public void Remove(TKey key)
        {
            int hash = getHash(key);

            var list = items[hash];

            if(list != null)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    if(list[i].Key.Equals(key))
                    {
                        list.RemoveAt(i);
                        Count--;
                        break;
                    }
                }
            }
         }

        public TValue this[TKey key]
        {
            get
            {
                int hash = getHash(key);

                var list = items[hash];

                if (list != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Key.Equals(key))
                            return list[i].Value;
                    }
                }
                return default(TValue);           
            }
            set
            {
                if (!ContainsKey(key))
                    Add(key, value);
                else
                    update(key, value);
            }
        }

        public void Clear()
        {
            items = items = new ArrayList<Pair<TKey, TValue>>[items.Length];
            Count = 0;
        }

        public bool Contains(TKey key)
        {
            return ContainsKey(key);
        }

        public bool ContainsKey(TKey key)
        {
            int hash = getHash(key);

            var list = items[hash];

            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Key.Equals(key))
                        return true;
                }
            }
            return false;
        }

        public IEnumerable Values()
        {
            foreach (var list in items)
            {
                if (list != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        yield return list[i].Value;
                    }
                }
            }
        }

        public IEnumerable Keys()
        {
            foreach (var list in items)
            {
                if (list != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        yield return list[i].Key;
                    }
                }
            }
        }

        public override string ToString()
        {
            string s = "";

            for(int i=0; i < items.Length; i++)
            {
                var list = items[i];

                foreach(var pair in list)
                    s += pair.Key.ToString() + "|" + pair.Value.ToString() + " -> ";
            }
            return  s + "Count: " + Count.ToString();
        }

        private void update(TKey key, TValue value)
        {
            int hash = getHash(key);

            var list = items[hash];

            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Key.Equals(key))
                    {
                        list[i].Value = value;
                        break;
                    }
                }
            }
        }

        private int calcPrimeLength(int length)
        {
            while(!isPrime(++length))
                ;

            return length;
        }

        private bool isPrime(int number)
        {
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                    return false; 

            return true;
        }

        private int getHash(TKey key)
        {
            return Math.Abs(key.GetHashCode()) % items.Length;
        }
    }
}
