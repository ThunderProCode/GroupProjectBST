using System.Numerics;

namespace GroupProjectBST
{
    public class Tree<T>: ISortedSet<T> where T : IComparable<T> {
        BSTNode<T>? root = null;

        public int Size() {
            return 0;
        }

        public bool Add(T item)
        {
            if (root == null)
            {
                root = new BSTNode<T>(item);
            }
            else
            {
                AddRecursive(root, item);
            }
            return true;
        }

        private void AddRecursive(BSTNode<T> current, T item)
        {
            if (item.CompareTo(current.Value) < 0)
            {
                if (current.Left == null)
                {
                    current.Left = new BSTNode<T>(item);
                }
                else
                {
                    AddRecursive(current.Left, item);
                }
            }
            else if (item.CompareTo(current.Value) > 0)
            {
                if (current.Right == null)
                {
                    current.Right = new BSTNode<T>(item);
                }
                else
                {
                    AddRecursive(current.Right, item);
                }
            }
        }

        public T Find(T item)
        {
            return FindRecursive(root, item);
        }

        private T FindRecursive(BSTNode<T> current, T item)
        {
            if (current == null)
            {
                throw new KeyNotFoundException($"Item '{item}' not found.");
            }

            if (item.CompareTo(current.Value) == 0)
            {
                return current.Value;
            }
            else if (item.CompareTo(current.Value) < 0)
            {
                return FindRecursive(current.Left, item);
            }
            else
            {
                return FindRecursive(current.Right, item);
            }
        }

        public T Remove(T item)
        {
            var result = default(T);
            root = RemoveRecursive(root, item, ref result);
            return result;
        }

        private BSTNode<T> RemoveRecursive(BSTNode<T> current, T item, ref T result)
        {
            if (current == null)
            {
                throw new KeyNotFoundException($"Item '{item}' not found.");
            }

            if (item.CompareTo(current.Value) < 0)
            {
                current.Left = RemoveRecursive(current.Left, item, ref result);
            }
            else if (item.CompareTo(current.Value) > 0)
            {
                current.Right = RemoveRecursive(current.Right, item, ref result);
            }
            else
            {
                result = current.Value;
                if (current.Left == null)
                {
                    return current.Right;
                }
                else if (current.Right == null)
                {
                    return current.Left;
                }
                current.Value = FindMin(current.Right).Value;
                current.Right = RemoveRecursive(current.Right, current.Value, ref result);
            }
            return current;
        }
        private BSTNode<T> FindMin(BSTNode<T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node; // Return the minimum value.
        }


        public T FindSuccessor(T item)
        {
            var successor = FindSuccessorRecursive(root, item, null);
            return successor != null ? successor.Value : default(T);
        }

        private BSTNode<T> FindSuccessorRecursive(BSTNode<T> current, T item, BSTNode<T> successor)
        {
            if (current == null)
            {
                return successor;
            }

            if (item.CompareTo(current.Value) < 0)
            {
                // If the item is smaller, the successor could be in the left subtree.
                return FindSuccessorRecursive(current.Left, item, current);
            }
            else if (item.CompareTo(current.Value) > 0)
            {
                // If the item is larger, the successor could be in the right subtree.
                return FindSuccessorRecursive(current.Right, item, successor);
            }
            else
            {
                // If the item matches, look for the smallest value in the right subtree.
                if (current.Right != null)
                {
                    return FindMin(current.Right);
                }
                else
                {
                    return successor; // No successor found in the right subtree.
                }
            }
        }

    }
}
