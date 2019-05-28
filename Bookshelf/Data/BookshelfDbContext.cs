using Bookshelf.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.Data
{
    public class BookshelfDbContext : DbContext
    {
        // A ctor for context registration in IServiceCollection in Startup.cs.
        public BookshelfDbContext(DbContextOptions options) : base(options) { }
        public BookshelfDbContext() { }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book {
                    Isbn = "978-0684801223",
                    Title = "The Old Man and the Sea",
                    Description = "The Old Man and the Sea is one of Hemingway's most enduring works." +
                        " Told in language of great simplicity and power, it is the story of an old Cuban fisherman," +
                        " down on his luck, and his supreme ordeal -- a relentless, agonizing battle with a giant marlin" +
                        " far out in the Gulf Stream." +
                        " Here Hemingway recasts, in strikingly contemporary style, the classic theme of courage in the face of defeat," +
                        " of personal triumph won from loss.Written in 1952, this hugely successful novella confirmed his power and presence" +
                        " in the literary world and played a large part in his winning the 1954 Nobel Prize for Literature." });
        }
    }
}
