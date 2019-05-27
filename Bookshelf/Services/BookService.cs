using Bookshelf.Data;
using Bookshelf.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bookshelf.Services
{
    public class BookService
    {
        private readonly BookshelfDbContext _context;

        public BookService(BookshelfDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Set<Book>().ToList();
        }
    }
}
