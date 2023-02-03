using EFCOREHW1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCOREHW1.Contexts
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory() + "../../../../").AddJsonFile("appsettings.json").Build().GetConnectionString("System.Data.SqlClient"));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>()
             .HasMany(e => e.Book)
             .WithMany(e => e.Student);

            modelBuilder.Entity<Books>()
              .HasMany(e => e.Student)
              .WithMany(e => e.Book);
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Books> Books { get; set; }

    }
}
