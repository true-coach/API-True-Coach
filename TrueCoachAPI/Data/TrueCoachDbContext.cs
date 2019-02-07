using Microsoft.EntityFrameworkCore;
using TrueCoachAPI.Models;

namespace TrueCoachAPI.Data
{
    public class TrueCoachDbContext : DbContext
    {
        public TrueCoachDbContext(DbContextOptions<TrueCoachDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                    Description = "Options for upper push: Beginner: OH farmers carry, Seated shoulder press, DB Shoulder press" +
                    "Intermediate: Tall kneeling landmine press, Standing OH press, Single arm DB press" +
                    "Advanced: Barbell OH press, Split Jerk, Handstand variation"

                },
                new Exercise
                {
                    ID = 2,
                    WorkoutID = 1,
                    Name = "B. Upper Pull",
                    Description = "Options for upper pull: Beginner: Tall kneeling cable pull down, Seated lat pull down, Straight arm cable pull down" +
                    "Intermediate: Bar hang, Assisted pull up, Free Motion pull down " +
                    "Advanced: Pull up, One arm hangs, Muscle up"
                },
                new Exercise
                {
                    ID = 3,
                    WorkoutID = 1,
                    Name = "C. HIIT of choice for 30 seconds",
                    Description = "Options: Aero Bike, Jump Squat, Mountain Climber, Sprint, Battle ropes, KB swing, Jump rope"

                },
                new Exercise
                {
                    ID = 4,
                    WorkoutID = 1,
                    Name = "A. Horizontal Push",
                    Description = "Options for Horizontal push: Beginner: Elevated assisted push-up, Kneeling Bilateral cable press, Seated chest press" +
                    "Intermediate: Push-up, One arm DB bench press, DB fly" +
                    "Advanced: Barbell Bench Press, Dynamic push up, Weighted Push-Up"
                },
                new Exercise
                {
                    ID = 5,
                    WorkoutID = 1,
                    Name = "B. Horizontal pull",
                    Description = "Options for Horizontal pull: Beginner: Seated Row, Supported DB Row, Tall Kneeling Horizontal Cable Row" +
                    "Intermediate: One Arm DB Row, Landmine Bent Over Rows, TRX Row" +
                    "Advanced: Barbell Row, Feet Elevated TRX Row, Weighted Unsupported Ring Rows "

                },
                new Exercise
                {
                    ID = 6,
                    WorkoutID = 1,
                    Name = "C. HIIT of choice for 30 seconds",
                    Description = "Options: Aero Bike, Jump Squat, Mountain Climber, Sprint, Battle ropes, KB swing, Jump rope"

                },
                new Exercise
                {
                    ID = 7,
                    WorkoutID = 1,
                    Name = "A. Tricep Variation",
                    Description = "Options for Tricep: Standing Tricep Pressdown, Close Grip Push up, Close Grip Bench Press, Cable Cross Extensions, DB Skull Crusher" +
                    "EZ-Bar Skull Crusher "
                },
                new Exercise
                {
                    ID = 8,
                    WorkoutID = 1,
                    Name = "B. Bicep Variation",
                    Description = "Options for Bicep: Cable Curl, Barbell Curl, DB Hammer Curl, Reverse Curl, ISO-Hold Curl, Supported Incline DB Curl"

                },
                new Exercise
                {
                    ID = 9,
                    WorkoutID = 1,
                    Name = "A. FINISHER",
                    Description = "TABATA-- 8 rounds for 20 seconds on and ONLY 10 seconds off! CHoose one exercise from the cardio list"
                });

            modelBuilder.Entity<Nutrition>().HasData(
                new Nutrition
                {
                    ID = 1,
                    NutritionGoals = FoodGoal.LoseFat
                },
                new Nutrition
                {
                    ID = 2,
                    NutritionGoals = FoodGoal.BuildMuscle
                },
                new Nutrition
                {
                    ID = 3,
                    NutritionGoals = FoodGoal.Maintain
                });

            modelBuilder.Entity<Meal>().HasData(
                new Meal
                {
                    ID = 1,
                    Name = "Meal 1",
                    Description = "This Meal plan will follow the Precision Nutrition Guidelines to give you a slow and steady lifestyle change that will result in Body Fat reduction.",
                    NutritionPlanId = 1
                },
                new Meal
                {
                    ID = 2,
                    Name = "Meal 2",
                    Description = "This Meal plan will follow the Precision Nutrition Guidelines to give you a slow and steady lifestyle change that will result in Body Fat reduction.",
                    NutritionPlanId = 1
                },
                new Meal
                {
                    ID = 3,
                    Name = "Meal 3",
                    Description = "This Meal plan will follow the Precision Nutrition Guidelines to give you a slow and steady lifestyle change that will result in Building more muscle.",
                    NutritionPlanId = 1
                },
                new Meal
                {
                    ID = 4,
                    Name = "Meal 4",
                    Description = "This Meal plan will follow the Precision Nutrition Guidelines to give you a slow and steady lifestyle change that will result in Maintaining current weight.",
                    NutritionPlanId = 1
                });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Workout> Workout { get; set; }
        public DbSet<WorkoutType> WorkoutType { get; set; }
        public DbSet<Nutrition> Nutrition { get; set; }
        public DbSet<Meal> Meal { get; set; }
    }
}