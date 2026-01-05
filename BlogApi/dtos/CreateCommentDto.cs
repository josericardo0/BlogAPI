using System.ComponentModel.DataAnnotations;

namespace BlogApi.DTOs
{
    public class CreateCommentDto
    {
        [Required]
        public string Text { get; set; } = string.Empty;
    }
}
