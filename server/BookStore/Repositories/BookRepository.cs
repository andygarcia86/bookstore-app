using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IBookStoreDbContext _dbContext;

        public BookRepository(IBookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<Book>> GetAllAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }
        
    }
}
