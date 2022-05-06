using System;

namespace test_api.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public string CoverPage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AuthorId { get; set; }
        
        public Author Author { get; set; }
    }
}