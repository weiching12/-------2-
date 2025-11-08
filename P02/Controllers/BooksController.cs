using P02.Service;
using Microsoft.AspNetCore.Mvc;

namespace P02.Controllers
{
    public class BooksController : Controller
    {
        private readonly BooksService _service;

        public BooksController(BooksService service)
        {
            _service = service;
        }
        // 取得全部書籍
        [HttpGet("/books")]
        public async Task<IActionResult> Books()
        {
            return View(await _service.GetAllBooksAsync());
        }
    }
}
