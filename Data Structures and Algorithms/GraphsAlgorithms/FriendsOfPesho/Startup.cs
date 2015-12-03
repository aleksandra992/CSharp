namespace GraphsAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Node : IComparable
    {
        public Node(int id)
        {
            this.Id = id;
        }

        public int Id { get; private set; }

        public double DijkstraDistance { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is Node))
            {
                return -1;
            }

            return this.DijkstraDistance.CompareTo((obj as Node).DijkstraDistance);
        }
    }

    public class Connection
    {
        public Connection(Node node, double distance)
        {
            this.Node = node;
            this.Distance = distance;
        }

        public Node Node { get; set; }

        public double Distance { get; set; }
    }

    public class Dijkstra
    {
        public static void DijkstraAlgorithm(Dictionary<Node, List<Connection>> graph, Node source)
        {
            var queue = new Queue<Node>();

            foreach (var node in graph)
            {
                node.Key.DijkstraDistance = double.PositiveInfinity;
            }

            source.DijkstraDistance = 0.0d;
            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();

                if (double.IsPositiveInfinity(currentNode.DijkstraDistance))
                {
                    break;
                }

                foreach (var neighbor in graph[currentNode])
                {
                    var potDistance = currentNode.DijkstraDistance + neighbor.Distance;
                    if (potDistance < neighbor.Node.DijkstraDistance)
                    {
                        neighbor.Node.DijkstraDistance = potDistance;
                        queue.Enqueue(neighbor.Node);
                    }
                }
            }
        }
    }

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
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numOfNodes = firstLine[0];
            var numOfStreets = firstLine[1];
            var numOfHospitals = firstLine[2];
            var hospitals = new Dictionary<int, Node>();
            var nodes = new Dictionary<int, Node>();
            var graph = new Dictionary<Node, List<Connection>>();
            var hospitalsInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (var i = 0; i < hospitalsInput.Length; i++)
            {
                var node = new Node(hospitalsInput[i]);
                hospitals[node.Id] = node;
                nodes[node.Id] = node;
                graph[node] = new List<Connection>();
            }
            for (var i = 1; i <= numOfNodes; i++)
            {
                if (hospitals.ContainsKey(i)) continue;
                else
                {
                    var node = new Node(i);
                    nodes[node.Id] = node;
                    graph[node] = new List<Connection>();
                }
            }

            for (var i = 0; i < numOfStreets; i++)
            {
                var street = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var firstPoint = street[0];
                var secondPoint = street[1];
                var distance = street[2];

                var firstConnection = new Connection(nodes[firstPoint], distance);
                var secondConnection = new Connection(nodes[secondPoint], distance);
                graph[nodes[firstPoint]].Add(secondConnection);
                graph[nodes[secondPoint]].Add(firstConnection);



            }

            double minDistance = int.MaxValue;
            double currentdistance = 0;
            foreach (var hospital in hospitals)
            {

                Node node = hospital.Value;
                Dijkstra.DijkstraAlgorithm(graph, node);
                foreach (var n in graph)
                {
                    if (hospitals.ContainsKey(n.Key.Id)) continue;
                    currentdistance += (int)n.Key.DijkstraDistance;
                }
                if (currentdistance < minDistance)
                {
                    minDistance = currentdistance;
                }
                currentdistance = 0;
            }

            Console.WriteLine(minDistance);
        }
    }
}
