using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using P02.Models;
using P02.Service;


namespace P02.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Books([FromServices] BooksService service)
    {
        var books = await service.GetAllBooksAsync();
        return View(books);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
