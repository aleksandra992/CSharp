namespace BiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class BiDictionary<K1, K2, T> where T : IEquatable<T>
    {
        private const string ErrorMessage = "Key doesn't exists.";
        private MultiDictionary<K1, T> first;
        private MultiDictionary<K2, T> second;

        public BiDictionary()
        {
            this.first = new MultiDictionary<K1, T>(true);
            this.second = new MultiDictionary<K2, T>(true);
        }

        public void Add(K1 key1, K2 key2, T value)
        {
            this.first.Add(key1, value);
            this.second.Add(key2, value);
        }

        public void Remove(K1 key1, K2 key2)
        {
            this.first.Remove(key1);
            this.second.Remove(key2);
        }

        public ICollection<T> Find(K1 key)
        {
            if (this.first.ContainsKey(key))
            {
                return this.first[key];
            }

            throw new ArgumentException(ErrorMessage);
        }

        public ICollection<T> Find(K2 key)
        {
            if (this.second.ContainsKey(key))
            {
                return this.second[key];
            }

            throw new ArgumentException(ErrorMessage);
        }

        public IEnumerable<T> Find(K1 key1, K2 key2)
        {
            if (this.first.ContainsKey(key1) &&
                this.second.ContainsKey(key2))
            {
                var value1 = this.first[key1];
                var value2 = this.second[key2];

                var set = new Set<T>(value1);
                var set2 = new Set<T>(value2);

                var intersect = set.Intersect(set2);

                return intersect;
            }

            throw new ArgumentException(ErrorMessage);
        }
    }
}
