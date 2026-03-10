using BookstoreSystemEF01Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace BookstoreSystemEF01Assignment.DbContexts
{
    internal class BookstoreDbContext : DbContext
    {
        private string _ConnectionString = "Server=.;Database=BookstoreDB;Trusted_Connection=True;TrustServerCertificate=True;";


        // DBSETS
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookstoreDbContext).Assembly); //Apply All Classes Implment IEntityTypeConfig..
        }
    }
}
