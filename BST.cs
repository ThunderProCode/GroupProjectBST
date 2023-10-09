namespace GroupProjectBST
{
    public class BSTNode<T> where T : IComparable<T> {
        T value;
        BSTNode<T> left;
        BSTNode<T> right;

        public BSTNode (T value, BSTNode<T> left, BSTNode<T> right) {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public List<T> TraversePreOrder (List<T>? toReturn = null) 
        {
            if(toReturn is null){
                toReturn = new List<T>();
            }
            toReturn.Add(value);
            if(left is not null){
                left.TraversePreOrder(toReturn);
            }
            if(right is not null)
            {
                right.TraversePreOrder(toReturn);
            }
            return toReturn;
        }

        public List<T> TraverseInOrder (List<T>? toReturn = null) 
        {
            if(toReturn is null){
                toReturn = new List<T>();
            }

            if(left is not null)
            {
                left.TraverseInOrder(toReturn);
            }
            toReturn.Add(value);
            if(right is not null) 
            {
                right.TraverseInOrder(toReturn);
            }

            return toReturn;
        }

        
    }
}
