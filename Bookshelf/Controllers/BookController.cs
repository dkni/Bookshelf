using Bookshelf.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
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
