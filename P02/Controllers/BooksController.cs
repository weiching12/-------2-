using P02.Service;
using Microsoft.AspNetCore.Mvc;

namespace P02.Controllers
{
    [Route("LibrarySystem/[controller]")]
    public class BooksController : Controller
    {
        private readonly BooksService _service;

        public BooksController(BooksService service)
        {
            _service = service;
        }

        // 取得全部書籍
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var rs = await _service.GetAllBooksAsync();
            return View(rs);
        }
    }
}
