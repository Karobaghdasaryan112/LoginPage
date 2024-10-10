using LoginAndRegistrationPage.Models;
using Microsoft.EntityFrameworkCore;


namespace LoginAndRegistrationPage.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
