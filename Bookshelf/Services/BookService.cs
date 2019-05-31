using Bookshelf.Data;
using Bookshelf.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bookshelf.Services
{
    public class BookService : IBookService
    {
        private readonly BookshelfDbContext _context;

        public BookService(BookshelfDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }
    }
}
