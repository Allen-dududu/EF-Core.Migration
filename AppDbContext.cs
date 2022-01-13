using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace TestMigration
{
    public class AppDbContext : DbContext
    {
        public const string ConnectionString = "Server=localhost;Database=postgres;username=postgres;password=postgres;";

        public DbSet<Blog> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }
    }
}
