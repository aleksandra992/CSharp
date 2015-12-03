namespace MyDjikstra
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PriorityQueue<T> where T : IComparable
    {
        private T[] heap;
        private int index;

        public PriorityQueue()
        {
            this.heap = new T[16];
            this.index = 1;
        }

        public int Count
        {
            get
            {
                return this.index - 1;
            }
        }

        public void Enqueue(T element)
        {
            if (this.index >= this.heap.Length)
            {
                this.IncreaseArray();
            }

            this.heap[this.index] = element;

            int childIndex = this.index;
            int parentIndex = childIndex / 2;
            this.index++;

            while (parentIndex >= 1 && this.heap[childIndex].CompareTo(this.heap[parentIndex]) < 0)
            {
                T swapValue = this.heap[parentIndex];
                this.heap[parentIndex] = this.heap[childIndex];
                this.heap[childIndex] = swapValue;

                childIndex = parentIndex;
                parentIndex = childIndex / 2;
            }
        }

        public T Dequeue()
        {
            T result = this.heap[1];

            this.heap[1] = this.heap[this.Count];
            this.index--;

            int rootIndex = 1;

            while (true)
            {
                int leftChildIndex = rootIndex * 2;
                int rightChildIndex = (rootIndex * 2) + 1;

                if (leftChildIndex > this.index)
                {
                    break;
                }

                int minChild;
                if (rightChildIndex > this.index)
                {
                    minChild = leftChildIndex;
                }
                else
                {
                    if (this.heap[leftChildIndex].CompareTo(this.heap[rightChildIndex]) < 0)
                    {
                        minChild = leftChildIndex;
                    }
                    else
                    {
                        minChild = rightChildIndex;
                    }
                }

                if (this.heap[minChild].CompareTo(this.heap[rootIndex]) < 0)
                {
                    T swapValue = this.heap[rootIndex];
                    this.heap[rootIndex] = this.heap[minChild];
                    this.heap[minChild] = swapValue;

                    rootIndex = minChild;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public T Peek()
        {
            return this.heap[1];
        }

        private void IncreaseArray()
        {
            var copiedHeap = new T[this.heap.Length * 2];

            for (int i = 0; i < this.heap.Length; i++)
            {
                copiedHeap[i] = this.heap[i];
            }

            this.heap = copiedHeap;
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {

            Dictionary<KeyValuePair<int, int>, int> graph = new Dictionary<KeyValuePair<int, int>, int>();
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numOfNodes = firstLine[0];
            var numOfStreets = firstLine[1];
            var numOfHospitals = firstLine[2];
            int[] distances = new int[numOfNodes + 1];

            var hospitals = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (var i = 0; i < numOfStreets; i++)
            {
                var conn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var keyValue = new KeyValuePair<int, int>(conn[0], conn[1]);
                graph[keyValue] = conn[2];
                keyValue = new KeyValuePair<int, int>(conn[1], conn[0]);
                graph[keyValue] = conn[2];
            }

            for (var i = 0; i < distances.Length; i++)
            {
                distances[i] = int.MaxValue;
            }

            int min = int.MaxValue;
            int current = 0;
            foreach (var hospital in hospitals)
            {
                distances = Djikstra(graph, hospital, numOfNodes);
                for (var i = 1; i < distances.Length; i++)
                {
                    if (hospitals.Contains(i)) continue;

                    current += distances[i];
                }

                if (current < min)
                {
                    min = current;
                }

                current = 0;
            }
            Console.WriteLine(min);
        }

        public static int[] Djikstra(Dictionary<KeyValuePair<int, int>, int> graph, int source, int numOfNodes)
        {
            int[] distances = new int[numOfNodes + 1];
            for (var i = 0; i < distances.Length; i++)
            {
                distances[i] = int.MaxValue;
            }
            var queue = new PriorityQueue<int>();
            distances[source] = 0;
            queue.Enqueue(distances[source]);

            while (queue.Count != 0)
            {
                var currentDistance = queue.Dequeue();

                if (int.MaxValue == currentDistance)
                {
                    break;
                }

                foreach (var key in graph)
                {
                    var currentNode = Array.IndexOf(distances, currentDistance);
                    if (key.Key.Key == currentNode)
                    {
                        var neighbor = key.Key.Value;
                        var potDistance = distances[currentNode] + key.Value;
                        if (potDistance < distances[neighbor])
                        {
                            distances[neighbor] = potDistance;
                            queue.Enqueue(distances[neighbor]);
                        }
                    }
                }

            }

            return distances;
        }
    }
}
