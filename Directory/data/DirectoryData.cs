using domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace data
{
    public class DirectoryData : IDirectoryData<Business>
    {
        private DbContext _context;
        private readonly DbSet<Business> _dbSet;

        public DirectoryData(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Business>();
        }

        public IEnumerable<Business> GetBusinesses()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<Business> FindBusinesses(string searchTerm)
        {
            return _dbSet.Where(b =>
                b.BusinessName.Contains(searchTerm) | b.City.Contains(searchTerm) | b.State.Contains(searchTerm) |
                b.BusinessType.BusinessTypeName.Contains(searchTerm));
        }
    }
}