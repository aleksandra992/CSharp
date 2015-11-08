using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_and_Traversals
{
    public class Startup
    {
        static int numberOfNodes;

        static TreeNode<int> FindRoot(TreeNode<int>[] nodes)
        {
            TreeNode<int> root = null;

            foreach (var node in nodes)
            {
                if (!node.HasParent)
                {
                    root = node;
                    break;
                }
            }
            return root;
        }

        static List<TreeNode<int>> FindLeafs(TreeNode<int>[] nodes)
        {
            var leafs = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.ChildrenCount == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }

        static List<TreeNode<int>> FindMiddleNodes(TreeNode<int>[] nodes)
        {
            var middleNodes = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.ChildrenCount != 0 && node.HasParent)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        public static int LongestPath(TreeNode<int> node)
        {
            if (node.ChildrenCount == 0)
            {
                return 0;
            }
            int maxPath = 0;
            foreach (var children in node.Children)
            {
                var currentPath = LongestPath(children);
                if (maxPath < currentPath)
                {
                    maxPath = currentPath;
                }
            }

            return maxPath + 1;
        }

        public static int br = 0;

        public static int FindAllPathsWithGivenSum(TreeNode<int> node, int sum)
        {
            if (node.ChildrenCount == 0)
            {
                return node.Value;
            }

            int currentSum = 0;
            foreach (var child in node.Children)
            {
                currentSum = node.Value + FindAllPathsWithGivenSum(child, sum);
                if (currentSum == sum || node.Value + currentSum == sum)
                {
                    br++;
                }
            }

            return currentSum;
        }

        public static void Main(string[] args)
        {
            var reader = new StringReader(
@"7
2 4
3 2
5 0
3 5
5 6
5 1");
            Console.SetIn(reader);
            Console.WriteLine("Enteer the number of nodes for the tree");
            numberOfNodes = int.Parse(Console.ReadLine());
            var nodes = new TreeNode<int>[numberOfNodes];
            for (var i = 0; i < numberOfNodes; i++)
            {
                nodes[i] = new TreeNode<int>(i);
            }



            Console.WriteLine("Enter pairs of parent and child separated by space and each pair on separate line");

            for (var i = 0; i < numberOfNodes - 1; i++)
            {
                var edgeParts = Console.ReadLine().Split(' ');
                nodes[int.Parse(edgeParts[0])].AddChild(nodes[int.Parse(edgeParts[1])]);
            }

            Console.WriteLine("The root of the tree is {0} ", FindRoot(nodes).Value);

            Console.WriteLine("The leafs of the tree are {0} ", string.Join(",", FindLeafs(nodes).Select(x => x.Value)));

            Console.WriteLine("The middle nodes of the tree are {0} ", string.Join(",", FindMiddleNodes(nodes).Select(x => x.Value)));

            Console.WriteLine("The longest path is {0} ", LongestPath(FindRoot(nodes)));

            FindAllPathsWithGivenSum(FindRoot(nodes), 6);
            Console.WriteLine(br);

        }
    }
}
