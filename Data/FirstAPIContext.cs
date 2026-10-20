using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Data
{
    public class FirstAPIContext : DbContext
    {
        public FirstAPIContext(DbContextOptions<FirstAPIContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Gone With The Wind",
                    Author = "Margaret Mitchell",
                    YearPublished = 1936
                },
                new Book
                {
                    Id = 2,
                    Title = "Jane Eyre",
                    Author = "Charlotte Bronte",
                    YearPublished = 1847
                },
                new Book
                {
                    Id = 3,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    YearPublished = 1813
                },
                new Book
                {
                    Id = 4,
                    Title = "To Kill A Mockingbird",
                    Author = "Harper Lee",
                    YearPublished = 1960
                },
                new Book
                {
                    Id = 5,
                    Title = "The Hobbit",
                    Author = "J.R.R Tolkien",
                    YearPublished = 1937
                }
            );
        }

        public DbSet<Book> Books { get; set; }
    }
}
