using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrBust.Data
{
    public class OrBustDbContext : DbContext
    {
        public DbSet<OrBustFirstProgress> orBustFirstProgresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DefaultConnection");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrBustFirstProgress>().ToTable("FirstProgress");
        }
    }
}