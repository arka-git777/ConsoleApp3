using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3
{
    public class AppDbContext : DbContext
    {
        private string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Univer;Integrated Security=True;Connect Timeout=30;";
        public DbSet<Student> Students {  get; set; }
        /*public AddDbContext(DbContextOptions<AddDbContext> options) : base(options)
        {
            
        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionStr);
        }
    }
}
