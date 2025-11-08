using Microsoft.EntityFrameworkCore;
using P02.Data;
using P02.Models;
namespace P02.Repository
{
    public class BooksRepository
    {
        private readonly BooksContext _context;

        public BooksRepository(BooksContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book?> GetBookByIdAsync(string id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task AddBookAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
            }
        }
    }
}