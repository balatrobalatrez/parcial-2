using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using discografiaparcial.Models;
namespace discografiaparcial.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<cancion> Canciones { get; set; }
        public DbSet<cantante> Cantantes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=discografia.db");
        }
    }
}
