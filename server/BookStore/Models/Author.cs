using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class Author
    {
        public Author() 
        {
            BookAuthors = new HashSet<BookAuthor>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Summary { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
