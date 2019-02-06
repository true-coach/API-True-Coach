﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrueCoachAPI.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nutrition",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NutritionGoals = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MealPlan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NutritionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MealPlan_Nutrition_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "Nutrition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ExerciseID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkoutTypeID = table.Column<int>(nullable: false),
                    WorkoutGoals = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Workout_WorkoutType_WorkoutTypeID",
                        column: x => x.WorkoutTypeID,
                        principalTable: "WorkoutType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkoutID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Exercise_Workout_WorkoutID",
                        column: x => x.WorkoutID,
                        principalTable: "Workout",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Nutrition",
                columns: new[] { "ID", "NutritionGoals" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "WorkoutType",
                columns: new[] { "ID", "ExerciseID", "Name" },
                values: new object[,]
                {
                    { 1, null, "Upper Body" },
                    { 2, null, "Lower Body" },
                    { 3, null, "Full Body" },
                    { 4, null, "Core" }
                });

            migrationBuilder.InsertData(
                table: "MealPlan",
                columns: new[] { "ID", "Description", "Name", "NutritionId" },
                values: new object[,]
                {
                    { 1, "This Meal plan will follow the Precision Nutrition Guidelines to give you a slow and steady lifestyle change that will result in Body Fat reduction.", "Lose Body Fat", 1 },
                    { 2, "This Meal plan will follow the Precision Nutrition Guidelines to give you a slow and steady lifestyle change that will result in Building more muscle.", "Build Muscle", 2 },
                    { 3, "This Meal plan will follow the Precision Nutrition Guidelines to give you a slow and steady lifestyle change that will result in Maintaining current weight.", "Maintain", 3 }
                });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "ID", "WorkoutGoals", "WorkoutTypeID" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 2, 2 },
                    { 3, 2, 3 },
                    { 4, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "ID", "Description", "Name", "WorkoutID" },
                values: new object[,]
                {
                    { 1, "Options for upper push: Beginner: OH farmers carry, Seated shoulder press, DB Shoulder pressIntermediate: Tall kneeling landmine press, Standing OH press, Single arm DB pressAdvanced: Barbell OH press, Split Jerk, Handstand variation", "A. Upper Push", 1 },
                    { 2, "Options for upper pull: Beginner: Tall kneeling cable pull down, Seated lat pull down, Straight arm cable pull downIntermediate: Bar hang, Assisted pull up, Free Motion pull down Advanced: Pull up, One arm hangs, Muscle up", "B. Upper Pull", 1 },
                    { 3, "Options: Aero Bike, Jump Squat, Mountain Climber, Sprint, Battle ropes, KB swing, Jump rope", "C. HIIT of choice for 30 seconds", 1 },
                    { 4, "Options for Horizontal push: Beginner: Elevated assisted push-up, Kneeling Bilateral cable press, Seated chest pressIntermediate: Push-up, One arm DB bench press, DB flyAdvanced: Barbell Bench Press, Dynamic push up, Weighted Push-Up", "A. Horizontal Push", 1 },
                    { 5, "Options for Horizontal pull: Beginner: Seated Row, Supported DB Row, Tall Kneeling Horizontal Cable RowIntermediate: One Arm DB Row, Landmine Bent Over Rows, TRX RowAdvanced: Barbell Row, Feet Elevated TRX Row, Weighted Unsupported Ring Rows ", "B. Horizontal pull", 1 },
                    { 6, "Options: Aero Bike, Jump Squat, Mountain Climber, Sprint, Battle ropes, KB swing, Jump rope", "C. HIIT of choice for 30 seconds", 1 },
                    { 7, "Options for Tricep: Standing Tricep Pressdown, Close Grip Push up, Close Grip Bench Press, Cable Cross Extensions, DB Skull CrusherEZ-Bar Skull Crusher ", "A. Tricep Variation", 1 },
                    { 8, "Options for Bicep: Cable Curl, Barbell Curl, DB Hammer Curl, Reverse Curl, ISO-Hold Curl, Supported Incline DB Curl", "B. Bicep Variation", 1 },
                    { 9, "TABATA-- 8 rounds for 20 seconds on and ONLY 10 seconds off! CHoose one exercise from the cardio list", "A. FINISHER", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_WorkoutID",
                table: "Exercise",
                column: "WorkoutID");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlan_NutritionId",
                table: "MealPlan",
                column: "NutritionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workout_WorkoutTypeID",
                table: "Workout",
                column: "WorkoutTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutType_ExerciseID",
                table: "WorkoutType",
                column: "ExerciseID");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutType_Exercise_ExerciseID",
                table: "WorkoutType",
                column: "ExerciseID",
                principalTable: "Exercise",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_Workout_WorkoutID",
                table: "Exercise");

            migrationBuilder.DropTable(
                name: "MealPlan");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Nutrition");

            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "WorkoutType");

            migrationBuilder.DropTable(
                name: "Exercise");
        }
    }
}
