using BookStore.Models;
using BookStore.Repositories;
using BookStore.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<ICollection<Book>> GetAllAsync()
        {
            return await _bookRepository.GetAllAsync();
        }
        
    }
}
