using BookStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public interface IAuthorRepository
    {
        Task<ICollection<Author>> GetAllAsync();

    }
}
