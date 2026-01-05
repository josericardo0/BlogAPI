using BlogApi.Data;
using BlogApi.DTOs;
using BlogApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostsController : ControllerBase
    {
        private readonly BlogContext _context;

        public PostsController(BlogContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostListDto>>> GetPosts()
        {
            var posts = await _context.BlogPosts
                .Select(p => new PostListDto
                {
                    Id = p.Id,
                    Title = p.Title,
                    CommentCount = p.Comments.Count
                })
                .ToListAsync();

            return Ok(posts);
        }

        [HttpPost]
        public async Task<ActionResult> CreatePost(CreatePostDto dto)
        {
            var post = new BlogPost
            {
                Title = dto.Title,
                Content = dto.Content
            };

            _context.BlogPosts.Add(post);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, post);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostDetailDto>> GetPostById(int id)
        {
            var post = await _context.BlogPosts
                .Include(p => p.Comments)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (post == null)
                return NotFound();

            var result = new PostDetailDto
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                Comments = post.Comments.Select(c => c.Text).ToList()
            };

            return Ok(result);
        }

        [HttpPost("{id}/comments")]
        public async Task<ActionResult> AddComment(int id, CreateCommentDto dto)
        {
            var postExists = await _context.BlogPosts.AnyAsync(p => p.Id == id);
            if (!postExists)
                return NotFound();

            var comment = new Comment
            {
                BlogPostId = id,
                Text = dto.Text
            };

            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}