using System.Collections.Generic;
using Bookshelf.Data.Entities;

namespace Bookshelf.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
    }
}
