using System.Collections.Generic;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly ILogger<AuthorController> _logger;

        public AuthorController(ILogger<AuthorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            var authors = new List<Author>();
            authors.Add(new Author() { Name = "Andrew" });
            authors.Add(new Author() { Name = "Robert C. Martin" });
            authors.Add(new Author() { Name = "Paulo Coelho" });

            return authors;
        }
    }
}
