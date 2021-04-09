﻿using System;
using System.Collections.Generic;
using System.Text;
using domain;
using Microsoft.EntityFrameworkCore;

namespace data
{
    public class DirectoryContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\directorylocaldb; Initial Catalog=ListingsDb;Integrated Security=true;AttachDbFilename='C:\Users\Ben\source\repos\razordirectorywebsite\Directory\ui\Data\ListingsDb.mdf';");
        }
    }
}
