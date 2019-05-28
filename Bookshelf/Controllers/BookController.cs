using Bookshelf.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.Controllers
{
    [Authorize]
    [AutoValidateAntiforgeryToken]
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
