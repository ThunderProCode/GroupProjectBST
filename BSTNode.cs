namespace GroupProjectBST {
    public class BSTNode<T>: ITraversable<T> where T : IComparable<T> {
        public T Value {get; set;}
        public BSTNode<T>? Left {get; set;}
        public BSTNode<T>? Right {get; set;}

        public BSTNode (T value) {
            Value = value;
            Left = null;
            Right = null;
        }

        public IEnumerable<T> PreOrder (List<T>? toReturn = null) 
        {
            toReturn ??= new List<T>();
            toReturn.Add(Value);
            Left?.PreOrder(toReturn);
            Right?.PreOrder(toReturn);
            return toReturn;
        }

        public IEnumerable<T> InOrder (List<T>? toReturn = null) 
        {
            toReturn ??= new List<T>();
            Left?.InOrder(toReturn);
            toReturn.Add(Value);
            Right?.InOrder(toReturn);
            return toReturn;
        }

        public IEnumerable<T> PostOrder(List<T>? toReturn = null) 
        {
            toReturn ??= new List<T>();
            Left?.PostOrder(toReturn);
            Right?.PostOrder(toReturn);
            toReturn.Add(Value);
            return toReturn;
        }
    }  
}