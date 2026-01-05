using BlogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options) { }

        public DbSet<BlogPost> BlogPosts => Set<BlogPost>();
        public DbSet<Comment> Comments => Set<Comment>();
    }
}
