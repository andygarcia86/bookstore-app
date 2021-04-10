using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IBookStoreDbContext _dbContext;

        public AuthorRepository(IBookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<Author>> GetAllAsync()
        {
            return await _dbContext.Authors.ToListAsync();
        }
        
    }
}
