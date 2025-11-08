using Microsoft.EntityFrameworkCore;
namespace P02.Data
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
        }

        public DbSet<Models.Book> Books { get; set; }
    }
}