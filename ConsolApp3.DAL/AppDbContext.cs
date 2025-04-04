using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp3
{
    public class AppDbContext : DbContext
    {
        //private string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Univer;Integrated Security=True;Connect Timeout=30;";
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionStr = connection.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionStr);
        }
        /*public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId)
                .OneDelete(DeleteBehavior.Cascade);
        }*/
    }
}
