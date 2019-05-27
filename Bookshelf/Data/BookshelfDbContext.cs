using Bookshelf.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.Data
{
    public class BookshelfDbContext : DbContext
    {
        public BookshelfDbContext(DbContextOptions options) : base(options) { }

        DbSet<Book> Books { get; set; }
    }
}
