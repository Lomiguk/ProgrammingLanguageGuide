using Microsoft.EntityFrameworkCore;
using ProgrammingLanguageGuide.Context.Entities;

namespace ProgrammingLanguageGuide.Context
{
    public class MainDbContext: DbContext
    {
        public DbSet<Article> Articles { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Profile> Profiles { get; set; }
        //public DbSet<Tag> Tags { get; set; }

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
