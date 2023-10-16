using System.Numerics;

namespace GroupProjectBST
{
    public class Tree<T>: ISortedSet<T> where T : IComparable<T> {
        BSTNode<T>? root = null;

        public ref BSTNode<T>? Find(T value) {
            if(root is null || root.GetValue().CompareTo(value) == 0){
                return ref root;
            } else if(value.CompareTo(root.GetValue()) < 0) {
                // return
            }
            return ref root;
        }

        public int Size() {
            return 0;
        }

        public void Add(){

        }

        public T Remove(T value) {
            if(root is null || root.GetValue().CompareTo(value) == 0) {
                
            } else if(value.CompareTo(root.GetValue()) < 0){
                
            }
        }
    }

    public class BSTNode<T>: ITraversable<T> where T : IComparable<T> {
        T value;
        BSTNode<T> left;
        BSTNode<T> right;

        public BSTNode (T value, BSTNode<T> left, BSTNode<T> right) {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public T GetValue() {
            return this.value;
        }

        public IEnumerable<T> PreOrder (List<T>? toReturn = null) 
        {
            if(toReturn is null){
                toReturn = new List<T>();
            }
            toReturn.Add(value);
            if(left is not null){
                left.PreOrder(toReturn);
            }
            if(right is not null)
            {
                right.PreOrder(toReturn);
            }
            return toReturn;
        }

        public IEnumerable<T> InOrder (List<T>? toReturn = null) 
        {
            if(toReturn is null){
                toReturn = new List<T>();
            }
            if(left is not null)
            {
                left.InOrder(toReturn);
            }
            toReturn.Add(value);
            if(right is not null) 
            {
                right.InOrder(toReturn);
            }
            return toReturn;
        }

        public IEnumerable<T> PostOrder(List<T>? toReturn = null) 
        {
            if(toReturn is null){
                toReturn = new List<T>();
            }
            if(left is not null)
            {
                left.PostOrder(toReturn);
            }
            if(right is not null) 
            {
                right.PostOrder(toReturn);
            }
            toReturn.Add(value);
            return toReturn;
        }
    }   
}
