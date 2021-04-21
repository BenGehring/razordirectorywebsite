using System;
using System.Collections.Generic;
using System.Text;
using domain;
using Microsoft.EntityFrameworkCore;

namespace data
{
    public sealed class DirectoryContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }
        public DbSet<BusinessType> BusinessTypes { get; set; }

        public DirectoryContext(DbContextOptions<DirectoryContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Business>(entity =>
            {
                entity.HasKey(b => b.Id);
            });

            modelBuilder.Entity<BusinessType>(entity =>
            {
                entity.HasKey(b => b.Id);
            });
        }
    }
}
