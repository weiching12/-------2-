using Microsoft.EntityFrameworkCore;
namespace BooksModel
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
        }

        public DbSet<BooksModel> Books { get; set; }
    }
}