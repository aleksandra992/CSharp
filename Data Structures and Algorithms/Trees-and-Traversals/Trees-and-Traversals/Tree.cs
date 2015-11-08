namespace Trees_and_Traversals
{
    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T rootValue)
        {
            this.Root = new TreeNode<T>(rootValue);
        }

        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
            set
            {
                this.root = value;
            }
        }

        public Tree(T rootValue, params Tree<T>[] children) : this(rootValue)
        {
            foreach (var child in children)
            {
                this.Root.AddChild(child.root);
            }
        }
    }
}
