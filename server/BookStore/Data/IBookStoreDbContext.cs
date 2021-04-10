using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public interface IBookStoreDbContext
    {

        DbSet<Book> Books { get; }

        DbSet<Author> Authors { get; }

        DbSet<BookAuthor> BookAuthors { get; }


    }
}
