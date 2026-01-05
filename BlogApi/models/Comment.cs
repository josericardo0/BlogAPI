using System.ComponentModel.DataAnnotations;

namespace BlogApi.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; } = string.Empty;

        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; } = null!;
    }
}
