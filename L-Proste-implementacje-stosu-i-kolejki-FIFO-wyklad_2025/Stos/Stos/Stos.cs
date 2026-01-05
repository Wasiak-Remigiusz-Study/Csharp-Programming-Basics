


namespace StosLib
{
    public class Stos<T> : IStos<T>
    {
        private List<T> _lista;

        public Stos(int size = 10)
        {
            _lista = new List<T>(size);
        }
        public T Peek
        {   
            get
            {
                if (IsEmpty)
                    throw new StosEmptyException();
                return _lista[_lista.Count - 1];
            }

        }

        public int Count => _lista.Count();

        public bool IsEmpty => (Count == 0);

        public void Clear() => _lista.Clear();


        public T Pop()
        {
            var i = _lista.Count() - 1;
            if (i < 0)
                throw new StosEmptyException();

            
            var vaule = _lista[i];
            _lista.RemoveAt(i);
            return vaule;
        }

        public void Push(T value) => _lista.Add(value);


        public T[] ToArray() => _lista.ToArray(); // zamieniamy liste na tablice

    }
}
