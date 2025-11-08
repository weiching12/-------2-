
using P02.Models;
using P02.Repository;
namespace P02.Service
{
    public class BooksService
    {
        private readonly BooksRepository _repository;

        public BooksService(BooksRepository repository)
        {
            _repository = repository;
        }

        // 取得全部書籍
        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _repository.GetAllBooksAsync();
        }

        // 依id取得單一書籍
        public async Task<Book?> GetBookByIdAsync(int id)
        {
            return await _repository.GetBookByIdAsync(id);
        }

        // 新增書籍
        public async Task AddBookAsync(Book book)
        {
            var existingBook = await _repository.GetBookByIdAsync(book.Id);
            if (existingBook != null)
            {
                throw new Exception("已存在書籍，無法新增相同ID的書籍。");
            }
            await _repository.AddBookAsync(book);
        }

        // 更新書籍
        public async Task UpdateBookAsync(Book book)
        {
            await _repository.UpdateBookAsync(book);
        }

        // 刪除書籍
        public async Task DeleteBookAsync(int id)
        {
            await _repository.DeleteBookAsync(id);
        }
    }
}