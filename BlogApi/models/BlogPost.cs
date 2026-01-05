using System.ComponentModel.DataAnnotations;

namespace BlogApi.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}