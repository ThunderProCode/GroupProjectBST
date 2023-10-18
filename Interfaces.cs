namespace GroupProjectBST
{
    public interface ISortedSet<T> where T: IComparable<T> {
        public T Find(T value);
        public int Size();
        public bool Add(T item);
        public T Remove(T Remove);
    }

    public interface ITraversable<T> {
        IEnumerable<T> PreOrder(List<T>? toReturn = null);
        IEnumerable<T> InOrder(List<T>? toReturn = null);
        IEnumerable<T> PostOrder(List<T>? toReturn = null);
    }
}
