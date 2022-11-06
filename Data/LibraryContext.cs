using Herbet_Ioana_Claudia_Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace Herbet_Ioana_Claudia_Lab2.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) :
       base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Author>().ToTable("Author");
        }

        public DbSet<Author> Authors { get; set; }
    }
}
