using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class GenericList<T> where T : IComparable
    {
        private T[] elements;
       private int capacity;
       // private int count;
        private int initialCapacity;

        public GenericList(int capacity)
        {

            this.initialCapacity = capacity;
            this.Capacity = capacity;
            this.Count = 0;
            this.elements = new T[capacity];

        }
        public int Count { get; private set; }
        public int Capacity { get; private set; }
        public T this[int index]
        {
            get
            {
                if (index > this.Count - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Index {0} is invalid", index));
                }
                return this.elements[index];

            }
            set
            {
                if (index > this.Count - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Index {0} is invalid", index));

                }
                this.elements[index] = value;
            }
        }
        public void AddElement(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.Capacity = this.Capacity * 2;
                T[] newElements = new T[this.Capacity];
                elements.CopyTo(newElements, 0);
                elements = new T[this.Capacity];
                newElements.CopyTo(elements, 0);
            }
           this.elements[this.Count] = element;
            this.Count++;
        }
        public void RemoveAt(int index)
        {
            if (index > this.Count - 1)
                throw new ArgumentOutOfRangeException("That index is invalid");

            else
            {
                for (int i = index; i < this.Count - 1; i++)
                {
                    this.elements[i] = this.elements[i + 1];
                }
                this.Count--;
            }
        }
        public void DeleteList()
        {
            this.Count = 0;
            this.Capacity = this.initialCapacity;
            this.elements = new T[capacity];
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                result.Append(this.elements[i].ToString() + " ");

            }
            return result.ToString();
        }
        public int FindByValue(T value)
        {
            int index = -1;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(value) == 0)
                {
                    index = i;
                    break;
                }
            }
            return index;


        }
        public T Max()
        {
            T result=default(T);
            if (this.Count > 0)
            {
                 result = this.elements[0];
                for (int i = 0; i < this.Count; i++)
                {
                    if (result.CompareTo(this.elements[i]) < 0)
                    {
                        result =this. elements[i];
                    }
                    
                }

            }
            return result;

        }

        public T Min()
        {
            T result = default(T);
            if (this.Count > 0)
            {
                result = this.elements[0];
                for (int i = 0; i < this.Count; i++)
                {
                    if (result.CompareTo(this.elements[i]) > 0)
                    {
                        result = this.elements[i];
                    }

                }

            }
            return result;

        }
    }
}
