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
            //modelBuilder.Entity<Workout>().HasKey(ce => new
            //{
            //    ce.WorkoutTypeID,
                
            //});

            modelBuilder.Entity<WorkoutType>().HasData(
              new WorkoutType
                {
                    ID = 1,
                    Name = "Upper Body"
                },
              new WorkoutType
                 {
                     ID = 2,
                     Name = "Lower Body"
                 },
              new WorkoutType
                  {
                      ID = 3,
                      Name = "Full Body"
                  },
              new WorkoutType
                   {
                       ID = 4,
                       Name = "Core"
                   });
            modelBuilder.Entity<Workout>().HasData(
              new Workout
               {
                   ID = 1,
                   WorkoutTypeID = 1,
                   WorkoutGoals = Goals.FatLoss
               },
              new Workout
               {
                   ID = 2,
                   WorkoutTypeID = 2,
                   WorkoutGoals = Goals.FatLoss
               },
              new Workout
               {
                   ID = 3,
                   WorkoutTypeID = 3,
                   WorkoutGoals = Goals.FatLoss
               },
              new Workout
               {
                   ID = 4,
                   WorkoutTypeID = 4,
                   WorkoutGoals = Goals.FatLoss
               
               });
            modelBuilder.Entity<Exercise>().HasData(
              new Exercise
              {
                  ID = 1,
                  WorkoutID = 1,
                  Name = "A. Upper Push",
                  Description = "Options for upper push will go here from the API side"
                
              },
              new Exercise
               {
                   ID = 2,
                   WorkoutID = 1,
                   Name = "B. Upper Pull",
                   Description = "Options for upper pull will go here from the API side"

               },
              new Exercise
               {
                   ID = 3,
                   WorkoutID = 1,
                   Name = "C. HIIT of choice for 30 seconds",
                   Description = "Options for hiit will go here from the API side"

               },
              new Exercise
               {
                   ID = 4,
                   WorkoutID = 1,
                   Name = "A. Horizontal Push",
                   Description = "Options for Horizontal push will go here from the API side"
               },               
              new Exercise
               {
                   ID = 5,
                   WorkoutID = 1,
                   Name = "B. Horizontal pull",
                   Description = "Options for Horizontal pull will go here from the API side"

               },
              new Exercise
                {
                    ID = 6,
                    WorkoutID = 1,
                    Name = "A. Tricep Variation",
                    Description = "Options for Tricep will go here from the API side"
                },
              new Exercise
                 {
                     ID = 7,
                     WorkoutID = 1,
                     Name = "B. Bicep Variation",
                     Description = "Options for Bicep will go here from the API side"

                 });
        }     

        public DbSet<TrueCoachAPI.Models.User> Users { get; set; }
        public DbSet<TrueCoachAPI.Models.Exercise> Exercise { get; set; }
        public DbSet<TrueCoachAPI.Models.Workout> Workout { get; set; }
        public DbSet<TrueCoachAPI.Models.WorkoutType> WorkoutType { get; set; }
    }
}
