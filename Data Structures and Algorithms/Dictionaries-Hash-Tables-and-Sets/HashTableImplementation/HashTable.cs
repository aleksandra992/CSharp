using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HashTableImplementation
{
    public class HashTable<K, T> : IEnumerable
    {
        private LinkedList<KeyValuePair<K, T>>[] data;
        private int initialCapacity = 16;
        private float loadRuns = 0.75f;
        private int count;
        private ICollection<K> keys;

        public HashTable()
        {
            this.data = new LinkedList<KeyValuePair<K, T>>[this.initialCapacity];
            this.Count = 0;
            this.Capacity = initialCapacity;
            this.keys = new HashSet<K>();
        }

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }

        public ICollection<K> Keys
        {
            get
            {
                return this.keys;
            }
        }

        public void Add(K key, T value)
        {
            bool keyAlreadyExist = false;
            if (this.Count >= this.Capacity * loadRuns)
            {
                var newArray = new LinkedList<KeyValuePair<K, T>>[this.Capacity * 2];
                for (int i = 0; i < data.Length; i++)
                {
                    newArray[i] = data[i];
                }

                data = newArray;
                this.Capacity = this.Capacity * 2;
            }

            var position = this.GetPosition(key);
            T findedValue;
            if (data[position] == null)
            {
                data[position] = new LinkedList<KeyValuePair<K, T>>();
            }

            if (!this.Find(key, out findedValue))
            {
                data[position].AddLast(new KeyValuePair<K, T>(key, value));
                this.Keys.Add(key);
            }


            this.Count++;
        }

        public bool Find(K key, out T value)
        {
            value = default(T);

            int hashPosition = this.GetPosition(key);
            var list = this.data[hashPosition];

            foreach (var pair in list)
            {
                if (key.Equals(pair.Key))
                {
                    value = pair.Value;
                    return true;
                }
            }

            return false;
        }


        public void Remove(K key)
        {
            var position = this.GetPosition(key);
            T findedValue;
            if (this.Find(key, out findedValue))
            {
                var pair = this.data[position].First(x => x.Key.Equals(key));
                this.data[position].Remove(pair);
                if (this.data[position].Count == 0)
                {
                    this.Count--;
                }

                this.Keys.Remove(key);
            }
        }

        public void Clear()
        {
            this.data = new LinkedList<KeyValuePair<K, T>>[this.initialCapacity];
            this.Count = 0;
            this.Capacity = initialCapacity;
        }

        public T this[K key]
        {
            get
            {
                T value = default(T);

                if (!this.Find(key, out value))
                {
                    throw new KeyNotFoundException("The key is not valid");
                }

                return value;
            }

            set
            {
                this.Add(key, value);
            }
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var list in this.data)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                    {
                        yield return pair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        private int GetPosition(K key)
        {
            return key.GetHashCode() % this.data.Length;
        }


    }
}
