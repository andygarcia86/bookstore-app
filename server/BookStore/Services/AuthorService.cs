using BookStore.Models;
using BookStore.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<ICollection<Author>> GetAllAsync()
        {
            return await _authorRepository.GetAllAsync();
        }
        
    }
}
