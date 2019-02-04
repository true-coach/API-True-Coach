using Microsoft.EntityFrameworkCore;
using TrueCoachAPI.Models;

namespace TrueCoachAPI.Data
{
    public class TrueCoachDbContext: DbContext
    {
        public TrueCoachDbContext(DbContextOptions<TrueCoachDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: seed dtata here after models are set up


        }
        public DbSet<TrueCoachAPI.Models.User> Users { get; set; }
        public DbSet<TrueCoachAPI.Models.Exercise> Exercise { get; set; }

        public DbSet<TrueCoachAPI.Models.Workout> Workout { get; set; }
    }
}
