using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01.TreeOfNodes
{
    public static class ThreeReader
    {
        public static void Main()
        {

            StringReader input = new StringReader(
@"7
2 4
3 2
5 0
3 5
5 6
5 1"
                );

            Console.SetIn(input);

            int numberOfNodes = int.Parse(Console.ReadLine());
            int numberOfPairs = numberOfNodes - 1;

            var nodes = new TreeNode<int>[numberOfNodes];

            for (var i = 0; i < nodes.Length; i++)
            {
                nodes[i] = new TreeNode<int>(i);
            }

            while (numberOfPairs != 0)
            {
                var k = Console.ReadLine().Split(' ');
                int parentId = int.Parse(k[0]);
                int childId = int.Parse(k[1]);

                nodes[parentId].AddChild(nodes[childId]);

                numberOfPairs--;
            }

            var root = FindRoot(nodes);
            Console.WriteLine("Root is:");
            if (root != null)
            {
                Console.WriteLine(root.Value);
            }

            var leafs = FindAllLeafs(nodes);
            Console.WriteLine("Leaf nodes:");
            foreach (var leaf in leafs)
            {
                Console.WriteLine(leaf.Value);
            }

            var midleNodes = FindAllMidleNodes(nodes);
            Console.WriteLine("Midle nodes:");
            foreach (var node in midleNodes)
            {
                Console.WriteLine(node.Value);
            }

            var longestPath = FindLongestPath(root);
            Console.WriteLine("Longest path:");
            Console.WriteLine(longestPath);

            Console.WriteLine("Paths with given sum:");
            CountOfPathsWithGivenSum(root, 6);

        }

        public static TreeNode<int> FindRoot(TreeNode<int>[] nodes)
        {
            foreach (var node in nodes)
            {
                if (!node.HasParent)
                {
                    return node;
                }
            }
            return null;
        }

        public static List<TreeNode<int>> FindAllLeafs(TreeNode<int>[] nodes)
        {
            var leafs = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.GetChildrenCount == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }

        public static List<TreeNode<int>> FindAllMidleNodes(TreeNode<int>[] nodes)
        {
            var midleNodes = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && (node.GetChildrenCount != 0))
                {
                    midleNodes.Add(node);
                }
            }

            return midleNodes;
        }

        public static int FindLongestPath(TreeNode<int> root)
        {
            if (root.GetChildrenCount == 0)
            {
                return 0;
            }

            var maxPathLen = 0;

            for (var i = 0; i < root.GetChildrenCount; i++)
            {
                var child = root.GetChild(i);
                var p = FindLongestPath(child);
                if (maxPathLen < p)
                {
                    maxPathLen = p;
                }
            }

            return maxPathLen + 1;
        }

        public static void CountOfPathsWithGivenSum(TreeNode<int> node, int sum)
        {
            List<int> path = new List<int>();
            var uniquePathsWithGivenSum = new HashSet<List<int>>(new SequenceComparer<int>());
            FindPathsWithGivenSum(node, path, sum, uniquePathsWithGivenSum);
            printPaths(uniquePathsWithGivenSum);
        }

        public static void FindPathsWithGivenSum(TreeNode<int> node, List<int> path, int sum, HashSet<List<int>> uniquePathsWithGivenSum)
        {
            if (node == null) return;

            path.Add(node.Value);

            if (path.Sum() == sum)
            {
                uniquePathsWithGivenSum.Add(path);
            }

            for (var i = 0; i < node.GetChildrenCount; i++)
            {
                var child = node.GetChild(i);
                FindPathsWithGivenSum(child, new List<int>(path), sum, uniquePathsWithGivenSum);

                FindPathsWithGivenSum(child, new List<int>(), sum, uniquePathsWithGivenSum);
            }
        }

        public static void printPaths(HashSet<List<int>> paths)
        {
            foreach (var k in paths)
            {
                k.ForEach(x => Console.Write(x + " -> "));
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
