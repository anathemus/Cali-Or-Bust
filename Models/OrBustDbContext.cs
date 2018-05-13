using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrBust.Models
{
    public class OrBustDbContext : DbContext
    {
        public DbSet<OrBustFirstProgress> orBustFirstProgresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DefaultConnection");
        }
    }
}