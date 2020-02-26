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
            //handle many to many ralations
            modelBuilder.Entity<BookCategory>().HasKey(bc => new{bc.BookId,bc.CategoryId});
            modelBuilder.Entity<BookCategory>().HasOne(bc =>bc.Book).WithMany(bc => bc.BookCategories).HasForeignKey(bc => bc.BookId);
            modelBuilder.Entity<BookCategory>().HasOne(bc => bc.Category).WithMany(bc => bc.BookCategories).HasForeignKey(bc => bc.CategoryId);
            modelBuilder.Entity<BookAuther>().HasKey(ba =>new {ba.BookId,ba.AutherId});
            modelBuilder.Entity<BookAuther>().HasOne(ba => ba.Book).WithMany(ba =>ba.BookAuthers).HasForeignKey(ba => ba.BookId);
            modelBuilder.Entity<BookAuther>().HasOne(ba => ba.Auther).WithMany(ba => ba.BookAuthers).HasForeignKey(ba => ba.AutherId);
            
            base.OnModelCreating(modelBuilder);


           
        }        
    }
}