﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrueCoachAPI.Data;

namespace TrueCoachAPI.Migrations
{
    [DbContext(typeof(TrueCoachDbContext))]
    [Migration("20190207231844_initial3")]
    partial class initial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrueCoachAPI.Models.Exercise", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("WorkoutID");

                    b.HasKey("ID");

                    b.HasIndex("WorkoutID");

                    b.ToTable("Exercise");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Options for upper push: Beginner: OH farmers carry, Seated shoulder press, DB Shoulder pressIntermediate: Tall kneeling landmine press, Standing OH press, Single arm DB pressAdvanced: Barbell OH press, Split Jerk, Handstand variation",
                            Name = "A. Upper Push",
                            WorkoutID = 1
                        },
                        new
                        {
                            ID = 2,
                            Description = "Options for upper pull: Beginner: Tall kneeling cable pull down, Seated lat pull down, Straight arm cable pull downIntermediate: Bar hang, Assisted pull up, Free Motion pull down Advanced: Pull up, One arm hangs, Muscle up",
                            Name = "B. Upper Pull",
                            WorkoutID = 1
                        },
                        new
                        {
                            ID = 3,
                            Description = "Options: Aero Bike, Jump Squat, Mountain Climber, Sprint, Battle ropes, KB swing, Jump rope",
                            Name = "C. HIIT of choice for 30 seconds",
                            WorkoutID = 1
                        },
                        new
                        {
                            ID = 4,
                            Description = "Options for Horizontal push: Beginner: Elevated assisted push-up, Kneeling Bilateral cable press, Seated chest pressIntermediate: Push-up, One arm DB bench press, DB flyAdvanced: Barbell Bench Press, Dynamic push up, Weighted Push-Up",
                            Name = "A. Horizontal Push",
                            WorkoutID = 1
                        },
                        new
                        {
                            ID = 5,
                            Description = "Options for Horizontal pull: Beginner: Seated Row, Supported DB Row, Tall Kneeling Horizontal Cable RowIntermediate: One Arm DB Row, Landmine Bent Over Rows, TRX RowAdvanced: Barbell Row, Feet Elevated TRX Row, Weighted Unsupported Ring Rows ",
                            Name = "B. Horizontal pull",
                            WorkoutID = 1
                        },
                        new
                        {
                            ID = 6,
                            Description = "Options: Aero Bike, Jump Squat, Mountain Climber, Sprint, Battle ropes, KB swing, Jump rope",
                            Name = "C. HIIT of choice for 30 seconds",
                            WorkoutID = 1
                        },
                        new
                        {
                            ID = 7,
                            Description = "Options for Tricep: Standing Tricep Pressdown, Close Grip Push up, Close Grip Bench Press, Cable Cross Extensions, DB Skull CrusherEZ-Bar Skull Crusher ",
                            Name = "A. Tricep Variation",
                            WorkoutID = 1
                        },
                        new
                        {
                            ID = 8,
                            Description = "Options for Bicep: Cable Curl, Barbell Curl, DB Hammer Curl, Reverse Curl, ISO-Hold Curl, Supported Incline DB Curl",
                            Name = "B. Bicep Variation",
                            WorkoutID = 1
                        },
                        new
                        {
                            ID = 9,
                            Description = "TABATA-- 8 rounds for 20 seconds on and ONLY 10 seconds off! CHoose one exercise from the cardio list",
                            Name = "A. FINISHER",
                            WorkoutID = 1
                        });
                });

            modelBuilder.Entity("TrueCoachAPI.Models.Meal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("NutritionID");

                    b.Property<int>("NutritionPlanId");

                    b.HasKey("ID");

                    b.HasIndex("NutritionID");

                    b.ToTable("Meal");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "This Meal plan will follow the Precision Nutrition Guidelines to give you a slow and steady lifestyle change that will result in Body Fat reduction.",
                            Name = "Meal 1",
                            NutritionPlanId = 1
                        },
                        new
                        {
                            ID = 2,
                            Description = "This Meal plan will follow the Precision Nutrition Guidelines to give you a slow and steady lifestyle change that will result in Body Fat reduction.",
                            Name = "Meal 2",
                            NutritionPlanId = 1
                        },
                        new
                        {
                            ID = 3,
                            Description = "This Meal plan will follow the Precision Nutrition Guidelines to give you a slow and steady lifestyle change that will result in Building more muscle.",
                            Name = "Meal 3",
                            NutritionPlanId = 1
                        },
                        new
                        {
                            ID = 4,
                            Description = "This Meal plan will follow the Precision Nutrition Guidelines to give you a slow and steady lifestyle change that will result in Maintaining current weight.",
                            Name = "Meal 4",
                            NutritionPlanId = 1
                        });
                });

            modelBuilder.Entity("TrueCoachAPI.Models.Nutrition", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NutritionGoals");

                    b.HasKey("ID");

                    b.ToTable("Nutrition");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            NutritionGoals = 1
                        },
                        new
                        {
                            ID = 2,
                            NutritionGoals = 2
                        },
                        new
                        {
                            ID = 3,
                            NutritionGoals = 3
                        });
                });

            modelBuilder.Entity("TrueCoachAPI.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TrueCoachAPI.Models.Workout", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("WorkoutGoals");

                    b.Property<int>("WorkoutTypeID");

                    b.HasKey("ID");

                    b.HasIndex("WorkoutTypeID");

                    b.ToTable("Workout");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            WorkoutGoals = 2,
                            WorkoutTypeID = 1
                        },
                        new
                        {
                            ID = 2,
                            WorkoutGoals = 2,
                            WorkoutTypeID = 2
                        },
                        new
                        {
                            ID = 3,
                            WorkoutGoals = 2,
                            WorkoutTypeID = 3
                        },
                        new
                        {
                            ID = 4,
                            WorkoutGoals = 2,
                            WorkoutTypeID = 4
                        });
                });

            modelBuilder.Entity("TrueCoachAPI.Models.WorkoutType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExerciseID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("ExerciseID");

                    b.ToTable("WorkoutType");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Upper Body"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Lower Body"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Full Body"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Core"
                        });
                });

            modelBuilder.Entity("TrueCoachAPI.Models.Exercise", b =>
                {
                    b.HasOne("TrueCoachAPI.Models.Workout", "Workout")
                        .WithMany()
                        .HasForeignKey("WorkoutID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrueCoachAPI.Models.Meal", b =>
                {
                    b.HasOne("TrueCoachAPI.Models.Nutrition", "Nutrition")
                        .WithMany("Meals")
                        .HasForeignKey("NutritionID");
                });

            modelBuilder.Entity("TrueCoachAPI.Models.Workout", b =>
                {
                    b.HasOne("TrueCoachAPI.Models.WorkoutType", "WorkoutType")
                        .WithMany()
                        .HasForeignKey("WorkoutTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrueCoachAPI.Models.WorkoutType", b =>
                {
                    b.HasOne("TrueCoachAPI.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseID");
                });
#pragma warning restore 612, 618
        }
    }
}
