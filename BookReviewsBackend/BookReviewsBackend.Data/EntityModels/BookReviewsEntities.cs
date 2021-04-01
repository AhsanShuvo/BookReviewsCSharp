using Microsoft.EntityFrameworkCore;

namespace BookReviewsBackend.Data.EntityModels
{
    class BookReviewsEntities : DbContext
    {
        public BookReviewsEntities(DbContextOptions<BookReviewsEntities> options) : base(options) { }
        public DbSet<Book>Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<LibraryBook> LibraryBooks { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<UserFavouriteBook> UserFavouriteBooks { get; set; }
        public DbSet<UserEntityModel> Users { get; set; }
    }
}
