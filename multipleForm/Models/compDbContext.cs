using Microsoft.EntityFrameworkCore;

namespace multipleForm.Models
{
    public class compDbContext : DbContext
    {
        public compDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<empDetail> empDetails { get; set; }
        public DbSet<userDetails> userDetails { get; set; }
    }
}
