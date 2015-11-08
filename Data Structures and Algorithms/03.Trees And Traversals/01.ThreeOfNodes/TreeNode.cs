using System;
using System.Collections.Generic;

namespace _01.TreeOfNodes
{
    public class TreeNode<T>
    {
        private T value;

        private List<TreeNode<T>> children;
        private bool hasParent;

        public TreeNode(T value)
        {
            this.Value = value;
            this.children = new List<TreeNode<T>>();
        }

        public bool HasParent
        {
            get
            {
                return this.hasParent;
            }
        }

        public int GetChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }

        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child.HasParent)
            {
                throw new Exception("Child node alredy has parent!");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
    }
}
