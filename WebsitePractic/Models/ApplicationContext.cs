using Microsoft.EntityFrameworkCore;

namespace WebsitePractic.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Records> Records { get; set; }
    }
}
