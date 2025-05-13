
using generics.Interfaces;
namespace generics.Repositories
{
    class InMemoryRepository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : class, new()
        where TKey : struct
    {
        private Dictionary<TKey, TEntity> _storage = new();

        public void Add(TKey id, TEntity entity)
        {
            _storage[id] = entity;
        }

        public TEntity Get(TKey id)
        {
            _storage.TryGetValue(id, out var entity);
            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _storage.Values;
        }

        public void Remove(TKey id)
        {
            _storage.Remove(id);
        }
    }
}
