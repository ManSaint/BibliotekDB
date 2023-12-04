using BibliotekDB.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotekDB.Data;

internal class Context : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Author { get; set; }
    public DbSet<LoanCard> LoanCards { get; set; }
    public DbSet<LoanDetail> LoanDetails { get; set; }
    public DbSet<BookDetail> BookDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"
                    Server=localhost; 
                    Database=BibliotekDB; 
                    Trusted_Connection=True; 
                    Trust Server Certificate=Yes; 
                    User Id=BibliotekDbUser; 
                    password=BibliotekDbUser");
    }
}
