using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("books")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _bookService;

        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [Produces("application/json")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogDebug("Started.");

            var books = await _bookService.GetAllAsync();

            _logger.LogDebug("Completed.");

            return Ok(books);
        }
    }
}
