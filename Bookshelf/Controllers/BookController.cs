using Bookshelf.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _service;

        public BookController(BookService service)
        {
            _service = service;
        }

        [Route("books")]
        public IActionResult GetBooks()
        {
            return Ok(_service.GetBooks());
        }
    }
}
