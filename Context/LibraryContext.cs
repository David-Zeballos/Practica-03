using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Reserve> Reserves { get; set; }

    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reserve>()
            .HasOne(r => r.User)
            .WithMany(u => u.Reserves)
            .HasForeignKey(r => r.UserId);

        modelBuilder.Entity<Reserve>()
            .HasOne(r => r.Book)
            .WithMany(b => b.Reserves)
            .HasForeignKey(r => r.BookId);
    }
}
