using System.Numerics;

namespace GroupProjectBST
{
    public class Tree<T>: ISortedSet<T> where T : IComparable<T> {
        BSTNode<T>? root = null;

        private ref BSTNode<T>? FindNode(T value) {
            if(root is null || root.GetValue().CompareTo(value) == 0){
                return ref root;
            } else if(value.CompareTo(root.GetValue()) < 0) {
                // return
            }
            return ref root;
        }

        public T Find() {

        }

        public int Size() {
            return 0;
        }

        public void Add(){

        }

        public T Remove() {
            
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

        public List<T> PreOrder (List<T>? toReturn = null) 
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

        public List<T> InOrder (List<T>? toReturn = null) 
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

        public List<T> PostOrder() {
            
        }
    }   
}
