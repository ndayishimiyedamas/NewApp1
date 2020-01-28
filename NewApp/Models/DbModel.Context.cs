using Microsoft.EntityFrameworkCore;
using NewApp.Models;

namespace NewApp.Models
{
    public class NewAppDbContext : DbContext
    {
        public NewAppDbContext(DbContextOptions<NewAppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Employee> Restaurants { get; set; }
        public object Employee { get; set; }
        public object Name { get; set; }
    }
}