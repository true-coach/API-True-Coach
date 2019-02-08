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
                    Name = "Upper Push",
                    Description = "<span><strong>Beginner:</strong> OH farmers carry, Seated shoulder press, DB Shoulder press" +
                    "</br><strong>Intermediate:</strong> Tall kneeling landmine press, Standing OH press, Single arm DB press" +
                    "</br><strong>Advanced:</strong> Barbell OH press, Split Jerk, Handstand variation</span>"

                },
                new Exercise
                {
                    ID = 2,
                    WorkoutID = 1,
                    Name = "Upper Pull",
                    Description = "<span><strong>Beginner:</strong> Tall kneeling cable pull down, Seated lat pull down, Straight arm cable pull down" +
                    "</br><strong>Intermediate:</strong> Bar hang, Assisted pull up, Free Motion pull down " +
                    "</br><strong>Advanced:</strong> Pull up, One arm hangs, Muscle up</span>"
                },
                new Exercise
                {
                    ID = 3,
                    WorkoutID = 1,
                    Name = "HIIT of choice for 30 seconds",
                    Description = "<span><strong>Options:</strong>" +
                    "</br>Aero Bike" +
                    "</br>Jump Squat" + 
                    "</br>Mountain Climber" +
                    "</br>Sprint" +
                    "</br>Battle ropes" +
                    "</br>KB swing" +
                    "</br>Jump rope</span>"
                },
                new Exercise
                {
                    ID = 4,
                    WorkoutID = 1,
                    Name = "Horizontal Push",
                    Description = "<span><strong>Beginner:</strong> Elevated assisted push-up, Kneeling Bilateral cable press, Seated chest press" +
                    "</br><strong>Intermediate:</strong> Push-up, One arm DB bench press, DB fly" +
                    "</br><strong>Advanced:</strong> Barbell Bench Press, Dynamic push up, Weighted Push-Up</span>"
                },
                new Exercise
                {
                    ID = 5,
                    WorkoutID = 1,
                    Name = "Horizontal pull",
                    Description = "<span><strong>Options for Horizontal pull: Beginner:</strong> Seated Row, Supported DB Row, Tall Kneeling Horizontal Cable Row" +
                    "</br><strong>Intermediate:</strong> One Arm DB Row, Landmine Bent Over Rows, TRX Row" +
                    "</br><strong>Advanced:</strong> Barbell Row, Feet Elevated TRX Row, Weighted Unsupported Ring Rows</span>"

                },
                new Exercise
                {
                    ID = 6,
                    WorkoutID = 1,
                    Name = "HIIT of choice for 30 seconds",
                    Description = "<span><strong>Options:</strong>" +
                    "</br>Aero Bike" +
                    "</br>Jump Squat" +
                    "</br>Mountain Climber" +
                    "</br>Sprint" +
                    "</br>Battle ropes" +
                    "</br>KB swing" +
                    "</br>Jump rope</span>"

                },
                new Exercise
                {
                    ID = 7,
                    WorkoutID = 1,
                    Name = "Tricep Variation",
                    Description = "<span><strong>Options:</strong>" +
                    "</br>Standing Tricep Pressdown" +
                    "</br>Close Grip Push Up" +
                    "</br>Close Grip Bench Press" +
                    "</br>Cable Cross Extensions" +
                    "</br>DB Skull Crusher" +
                    "</br>EZ-Bar Skull Crusher</span>"
                },
                new Exercise
                {
                    ID = 8,
                    WorkoutID = 1,
                    Name = "Bicep Variation",
                    Description = "<span><strong>Options:</strong>" +
                    "</br>Cable Curl" +
                    "</br>Barbell Curl" +
                    "</br>DB Hammer Curl" +
                    "</br>Reverse Curl" +
                    "</br>ISO-Hold Curl" +
                    "</br>Supported Incline DB Curl</span>"
                },                
                new Exercise
                {
                    ID = 10,
                    WorkoutID = 1,
                    Name = "FINISHER",
                    Description = "<span><strong>TABATA</strong>" +
                    "</br>8 rounds for 20 seconds on and ONLY 10 seconds off!" +
                    "</br>CHoose one exercise from the cardio list</span>"
                },
                 new Exercise
                 {
                     ID = 11,
                     WorkoutID = 2,
                     Name = "Lower Push",
                     Description = "Beginner: Goblet Squat, BW Squat, Leg Press" +
                     "Intermediate: KB Front Squat, Barbell Box Squat" +
                     "Advanced: Barbell Back Squat, Barbell Front Squat, OH quat "
                    
                 },
                new Exercise
                {
                    ID = 12,
                    WorkoutID = 2,
                    Name = "Lower Pull",
                    Description = "Beginner: KB Deadlift, Cable RDL, Hip Bridge" +
                    "Intermediate: Elevated Bar Deadlift, RDL, Hip Thrust" +
                    "Advanced: Power Clean, Barbell Deadlift, Barbell Hip Thrust "

                },
                new Exercise
                {
                    ID = 13,
                    WorkoutID = 2,
                    Name = "Lower Plyo",
                    Description = "Box Jump, Squat Jump, BW Squat, Russian Hop, Sprint, Hill Climb"
                },
                new Exercise
                {
                    ID = 14,
                    WorkoutID = 2,
                    Name = "Split/Step",
                    Description = "Beginner: Static Lunge Hold, BW Walking Lunge" +
                    "Intermediate: DB Lunge, Lateral Lunge, Lateral Step Up" +
                    "Advanced: Barbell Lunge, OH Lunge, Single Leg Squat"

                },
                new Exercise
                {
                    ID = 15,
                    WorkoutID = 2,
                    Name = "HyperExtension",
                    Description = "Options: Lower Back Extension, Hypers, Bridge, Good Mornings"

                },
                new Exercise
                {
                    ID = 16,
                    WorkoutID = 2,
                    Name = "Lower Plyo",
                    Description = "Options: Box Jump, Squat Jump, BW Squat, Russian Hop, Sprint, Hill Climb "
                },
                new Exercise
                {
                    ID = 17,
                    WorkoutID = 2,
                    Name = "Hamstring Variation",
                    Description = "Options: TRX hamstring curl, Machine Leg Curl, Bosu Ball Leg Curl"

                },
                new Exercise
                {
                    ID = 18,
                    WorkoutID = 2,
                    Name = "FINISHER",
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