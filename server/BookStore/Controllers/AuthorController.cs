using System.Threading.Tasks;
using BookStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("authors")]
    public class AuthorController : ControllerBase
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IAuthorService _authorService;

        public AuthorController(ILogger<AuthorController> logger, IAuthorService authorService)
        {
            _logger = logger;
            _authorService = authorService;
        }

        /// <summary>Returns all authors.</summary>
        /// <returns>Returns all authors.</returns>
        /// <remarks>List of authors.</remarks>
        [Produces("application/json")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogDebug("Started.");

            var authors = await _authorService.GetAllAsync();

            _logger.LogDebug("Completed.");

            return Ok(authors);
        }
    }
}
