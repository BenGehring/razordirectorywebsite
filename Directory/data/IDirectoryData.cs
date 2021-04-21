using System.Collections.Generic;
using domain;

namespace data
{
    public interface IDirectoryData
    {
        public double GetBusinessPageCount(int pageSize);

        public IEnumerable<Business> GetBusinesses(int currentPage, int pageSize);

        public IEnumerable<Business> FindBusinesses(string searchTerm);
    }
}