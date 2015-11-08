namespace Advanced_Data_Structures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BinaryHeap<T>
    {
        protected T[] data;

        protected int size = 0;

        protected Comparison<T> comparison;

        public BinaryHeap()
        {
            Constructor(4, null);
        }

        public BinaryHeap(Comparison<T> comparison)
        {
            Constructor(4, comparison);
        }

        public BinaryHeap(int capacity)
        {
            Constructor(capacity, null);
        }

        public BinaryHeap(int capacity, Comparison<T> comparison)
        {
            Constructor(capacity, comparison);
        }

        private void Constructor(int capacity, Comparison<T> comparison)
        {
            data = new T[capacity];
            this.comparison = comparison;
            if (this.comparison == null)
                this.comparison = Comparer<T>.Default.Compare;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        ///
        /// Add an item to the heap
        ///
        public void Insert(T item)
        {
            if (this.size == this.data.Length)
                this.Resize();
            this.data[size] = item;
            this.HeapifyUp(this.size);
            this.size++;
        }

        ///
        /// Get the item of the root
        ///
        public T Peak()
        {
            return this.data[0];
        }

        ///
        /// Extract the item of the root
        ///
        public T Pop()
        {
            T item = this.data[0];
            this.size--;
            this.data[0] = this.data[size];
            this.HeapifyDown(0);
            return item;
        }

        private void Resize()
        {
            T[] resizedData = new T[data.Length * 2];
            Array.Copy(this.data, 0, resizedData, 0, this.data.Length);
            this.data = resizedData;
        }

        private void HeapifyUp(int childIdx)
        {
            if (childIdx > 0)
            {
                int parentIdx = (childIdx - 1) / 2;
                if (this.comparison.Invoke(this.data[childIdx], this.data[parentIdx]) > 0)
                {
                    // swap parent and child
                    T t = data[parentIdx];
                    this.data[parentIdx] = this.data[childIdx];
                    this.data[childIdx] = t;
                    this.HeapifyUp(parentIdx);
                }
            }
        }

        private void HeapifyDown(int parentIdx)
        {
            int leftChildIdx = 2 * parentIdx + 1;
            int rightChildIdx = leftChildIdx + 1;
            int largestChildIdx = parentIdx;
            if (leftChildIdx < this.size && comparison.Invoke(this.data[leftChildIdx],this.data[largestChildIdx]) > 0)
            {
                largestChildIdx = leftChildIdx;
            }
            if (rightChildIdx < this.size && comparison.Invoke(this.data[rightChildIdx], this.data[largestChildIdx]) > 0)
            {
                largestChildIdx = rightChildIdx;
            }
            if (largestChildIdx != parentIdx)
            {
                T t = this.data[parentIdx];
                this.data[parentIdx] = this.data[largestChildIdx];
                this.data[largestChildIdx] = t;
                this.HeapifyDown(largestChildIdx);
            }
        }
    }
}
