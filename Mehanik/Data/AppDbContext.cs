using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mehanik.Models;
namespace Mehanik.Data
{
    internal class AppDbContext : DbContext
    {
       // public DbSet<Product> Products { get; set; }
       public DbSet<Clients> Clients { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<mechanics> Mechanics { get; set; }
        public DbSet<Parts> Parts { get; set; }
        public DbSet<Services> Services { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=MehanikDb;Trusted_Connection=true;TrustServerCertificate=true;");
        }
    }
}
