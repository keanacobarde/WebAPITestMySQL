using Microsoft.EntityFrameworkCore;
using WebAPITestMySQL.Models;

namespace WebAPITestMySQL.Data
{
    public class LibraryContext : DbContext
    {
     public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        { 
            
        }

        public DbSet<Authors> Authors { get; set; }
    }
}
