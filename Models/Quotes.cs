using System;

namespace test_api.Models
{
    public class Quotes
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AuthorId { get; set; }
        
        public Author Author { get; set; }
    }
}