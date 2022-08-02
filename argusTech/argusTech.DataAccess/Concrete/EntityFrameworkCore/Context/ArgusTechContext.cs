using argusTech.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using argusTech.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace argusTech.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class ArgusTechContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =.; database = ArgusTech; user id = sa; password = 123; "); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public DbSet<User> Users { get; set; }
    }
}
