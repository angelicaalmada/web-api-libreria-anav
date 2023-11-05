using Libreria_anav.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Libreria_anav.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Book> Books { get; set; }
        public object Book { get; internal set; }
    }
}
