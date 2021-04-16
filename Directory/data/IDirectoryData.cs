using System.Collections.Generic;

namespace data
{
    public interface IDirectoryData<out TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> GetBusinesses();

        public IEnumerable<TEntity> FindBusinesses(string searchTerm);
    }
}