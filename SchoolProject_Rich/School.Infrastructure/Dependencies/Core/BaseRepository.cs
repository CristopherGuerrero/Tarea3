namespace School.Infrastructure.Dependencies.Core
{
    public class BaseRepository<T>
    {
        protected readonly List<T> _dataStore = new();

        public void Add(T item) => _dataStore.Add(item);
        public IEnumerable<T> GetAll() => _dataStore;
        public T GetById(int id) => _dataStore.FirstOrDefault();
    }
}
