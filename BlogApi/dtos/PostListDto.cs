namespace BlogApi.DTOs
{
    public class PostListDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int CommentCount { get; set; }
    }
}
