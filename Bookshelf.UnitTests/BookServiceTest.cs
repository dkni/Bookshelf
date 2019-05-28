using Bookshelf.Data;
using Bookshelf.Data.Entities;
using Bookshelf.Services;
using Moq;
using Moq.EntityFrameworkCore;
using System.Collections.Generic;
using Xunit;

namespace Bookshelf.UnitTests
{
    public class BookServiceTest
    {
        [Fact]
        public void AllBooks_ReturnsListOfBook()
        {
            IList<Book> expectedBooks = new List<Book> { new Book(), new Book(), new Book() };

            var dbContextStub = new Mock<BookshelfDbContext>();
            dbContextStub.Setup(m => m.Books).ReturnsDbSet(expectedBooks);

            var bookService = new BookService(dbContextStub.Object);
            var books = bookService.GetBooks();

            Assert.Equal(expectedBooks, books);
        }
    }
}
