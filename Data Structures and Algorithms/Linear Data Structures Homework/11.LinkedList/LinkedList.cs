using System;
using System.Collections;
using System.Collections.Generic;

namespace _11.LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public ListItem<T> FirstElement { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            var current = this.FirstElement;
            while (current != null)
            {
                yield return current.Value;
                current = current.NextItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
