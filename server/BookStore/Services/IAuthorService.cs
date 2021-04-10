using BookStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public interface IAuthorService
    {
        Task<ICollection<Author>> GetAllAsync();
    }
}
