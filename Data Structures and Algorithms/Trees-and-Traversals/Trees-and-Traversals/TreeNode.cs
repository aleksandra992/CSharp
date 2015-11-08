namespace Trees_and_Traversals
{
    using System;
    using System.Collections.Generic;

    public class TreeNode<T>
    {
        private T value;
        private List<TreeNode<T>> children;
        private bool hasParent;

        public TreeNode(T value)
        {
            this.value = value;
            this.children = new List<TreeNode<T>>();
        }

        public bool HasParent
        {
            get
            {
                return this.hasParent;
            }
        }

        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
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

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("The child cannot be null");
            }

            if (child.hasParent)
            {
                throw new ArgumentException(
                    "The node already has a parent!");
            }

            child.hasParent = true;
            children.Add(child);
        }

        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }

        public List<TreeNode<T>> Children
        {
            get
            {
                return this.children;
            }
        }
    }
}
