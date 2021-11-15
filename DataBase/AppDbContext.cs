using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}