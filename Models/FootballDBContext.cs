using Microsoft.EntityFrameworkCore;

namespace FootballLeague.Models
{
    public class FootballDBContext : DbContext
    {
        public FootballDBContext(DbContextOptions<FootballDBContext> options) : base(options)
        {

        }
        public DbSet<Football_League> FootballLeagues { get; set; }
    }
}