using DemoDb.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DemoDb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected ApplicationDbContext()
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
