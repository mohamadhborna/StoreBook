using Microsoft.EntityFrameworkCore;
using udemyproject.models;
namespace udemyproject.services
{
    public class BookDbContext:DbContext
    {
        public virtual DbSet<Book> Books{ get; set; }
        public virtual DbSet<Auther> Authers{ get; set; }
        public virtual DbSet<Country> Countries{ get; set; }
        public virtual DbSet<Review> Reviews{ get; set; }

        public virtual DbSet<Reviewer> Reviewers{ get; set; }
        public virtual DbSet<Category> Categories{ get; set; }
        public virtual DbSet<BookAuther> BookAuthers{ get; set; }
        public virtual DbSet<BookCategory> BookCategories{ get; set; }
        
        public BookDbContext(DbContextOptions<BookDbContext> options):base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
        }        
    }
}