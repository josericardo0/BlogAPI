using System.ComponentModel.DataAnnotations;

namespace BlogApi.DTOs
{
    public class CreatePostDto
    {
        [Required, MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;
    }
}
