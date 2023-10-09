using Microsoft.EntityFrameworkCore;
using pizzaApp.Model;

namespace pizzaApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> MyProperty { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
    }
}
