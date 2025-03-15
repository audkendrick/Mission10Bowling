using Microsoft.EntityFrameworkCore;

namespace BowlingFun.Data
{
    public class BowlerDbContext : DbContext
    {
        public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
        {
        }
        public DbSet<BowlingLeague> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
