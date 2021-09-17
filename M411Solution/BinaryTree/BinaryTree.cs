namespace My.Collections
{
    using System;

    public enum TraverseModeEnum { PreOrder, PostOrder, InOrder, ReverseInOrder }

    public class BinaryTree<T> where T : IComparable<T>
    {

        private sealed class Node<TNode> where TNode : IComparable<TNode> // TNode muss IComparable implementieren
        {
            public TNode Item { get; set; }
            public Node<TNode> Left { get; set; }
            public Node<TNode> Right { get; set; }

            public int CompareTo(TNode other)
            {
                return Item.CompareTo(other);
            }
        }

        private Node<T> root;

        public int Count { get; private set; }
        public TraverseModeEnum TraverseMode { get; set; }

        public BinaryTree()
        {
            TraverseMode = TraverseModeEnum.PreOrder;
        }

        public void Add(T item)
        {
            if (root == null)
                root = new Node<T>() { Item = item };
            else
                addTo(root, item);

            Count++;
        }

        public void AddRange(T[] items)
        {
            foreach (var item in items)
                Add(item);
        }

        private void addTo(Node<T> node, T item)
        {
            if (item.CompareTo(node.Item) < 0)
            {
                if (node.Left == null)
                    node.Left = new Node<T>() { Item = item };
                else
                    addTo(node.Left, item);
            }
            else
            {
                if (node.Right == null)
                    node.Right = new Node<T>() { Item = item };
                else
                    addTo(node.Right, item);
            }
        }

        public bool Contains(T item)
        {
            Node<T> node = root;

            while (node != null)
            {
                int c = node.Item.CompareTo(item);

                if (c == 0)
                    return true;

                if (c > 0)
                    node = node.Left;
                else
                    node = node.Right;
            }

            return false;
        }

        public T Search(T item)
        {
            Node<T> node = root;

            while (node != null)
            {
                int c = node.Item.CompareTo(item);

                if (c == 0)
                    return node.Item;

                if (c > 0)
                    node = node.Left;
                else
                    node = node.Right;
            }
            return default(T);
        }

        public void Clear()
        {
            root = null;
            Count = 0;
        }

        public override string ToString()
        {
            string s = "";
            int level = 0;

            traverse(root, level, ref s);

            return s;
        }

        private void traverse(Node<T> node, int level, ref string s)
        {
            if (node == null)
                return;

            bool reverse = TraverseMode == TraverseModeEnum.ReverseInOrder;

            if (TraverseMode == TraverseModeEnum.PreOrder)
                s += "".PadLeft(level, ' ') + node.Item.ToString() + "\n";

            traverse(reverse ? node.Right : node.Left, level + 2, ref s);

            if (TraverseMode == TraverseModeEnum.InOrder || TraverseMode == TraverseModeEnum.ReverseInOrder)
                s += "".PadLeft(level, ' ') + node.Item.ToString() + "\n";

            traverse(reverse ? node.Left : node.Right, level + 2, ref s);

            if (TraverseMode == TraverseModeEnum.PostOrder)
                s += "".PadLeft(level, ' ') + node.Item.ToString() + "\n";
        }
    }
}