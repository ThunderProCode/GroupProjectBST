namespace GroupProjectBST
{
    public interface ISortedSet<T> where T: IComparable<T> {
        public T Find();
        public int Size();
        public void Add();
        public T Remove();
    }

    public interface ITraversable<T> {
        IEnumerable<T> PreOrder(List<T>? toReturn = null);
        IEnumerable<T> InOrder(List<T>? toReturn = null);
        IEnumerable<T> PostOrder(List<T>? toReturn = null);
    }
}
