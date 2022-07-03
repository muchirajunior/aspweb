using helloweb.Models;
using Microsoft.EntityFrameworkCore;

namespace programming.Models {
    public class DatabaseContext : DbContext {
        public DatabaseContext (DbContextOptions<DatabaseContext> options) : base (options) { }
        public DbSet<Book> books { get; set; }
    }
}