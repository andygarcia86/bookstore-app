using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private static readonly string[] Books = new[]
        {
            "Design Patterns: Elements of Reusable Object-Oriented Software", 
            "Getting MEAN", 
            "El alquimista"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public BookController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return Enumerable.Range(0, 3).Select(index => new Book
            {
                Title = Books[index]
            })
            .ToArray();
        }
    }
}
