namespace GroupProjectBST
{
    public interface ISortedSet<T> where T: IComparable<T> {
        public T Find();
        public int Size();
        public void Add();
        public T Remove();
    }

    public interface ITraversable<T> {
        IEnumerator<T> PreOrder(List<T>? toReturn = null);
        IEnumerator<T> InOrder(List<T>? toReturn = null);
        IEnumerator<T> PostOrder();
    }
}
