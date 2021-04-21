using System;
using domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace data
{
    public class DirectoryData : IDirectoryData
    {
        private DbContext _context;
        private readonly DbSet<Business> _dbSet;

        public DirectoryData(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Business>();
        }

        public double GetBusinessPageCount(int pageSize)
        {
            return (double)((decimal)_dbSet.Count() / Convert.ToDecimal(pageSize));
        }

        public IEnumerable<Business> GetBusinesses(int currentPage, int pageSize)
        {
            return _dbSet.Skip(currentPage - 1)
                .Take(pageSize).ToList();
        }

        public IEnumerable<Business> FindBusinesses(string searchTerm)
        {
            return _dbSet.Where(b =>
                b.BusinessName.Contains(searchTerm) | b.City.Contains(searchTerm) | b.State.Contains(searchTerm) |
                b.BusinessType.BusinessTypeName.Contains(searchTerm));
        }
    }
}