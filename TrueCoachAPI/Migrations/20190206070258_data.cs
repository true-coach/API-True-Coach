using Microsoft.EntityFrameworkCore.Migrations;

namespace TrueCoachAPI.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: "Options for upper push: Beginner: OH farmers carry, Seated shoulder press, DB Shoulder pressIntermediate: Tall kneeling landmine press, Standing OH press, Single arm DB pressAdvanced: Barbell OH press, Split Jerk, Handstand variation");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 2,
                column: "Description",
                value: "Options for upper pull: Beginner: Tall kneeling cable pull down, Seated lat pull down, Straight arm cable pull downIntermediate: Bar hang, Assisted pull up, Free Motion pull down Advanced: Pull up, One arm hangs, Muscle up");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 3,
                column: "Description",
                value: "Options: Aero Bike, Jump Squat, Mountain Climber, Sprint, Battle ropes, KB swing, Jump rope");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 4,
                column: "Description",
                value: "Options for Horizontal push: Beginner: Elevated assisted push-up, Kneeling Bilateral cable press, Seated chest pressIntermediate: Push-up, One arm DB bench press, DB flyAdvanced: Barbell Bench Press, Dynamic push up, Weighted Push-Up");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 5,
                column: "Description",
                value: "Options for Horizontal pull: Beginner: Seated Row, Supported DB Row, Tall Kneeling Horizontal Cable RowIntermediate: One Arm DB Row, Landmine Bent Over Rows, TRX RowAdvanced: Barbell Row, Feet Elevated TRX Row, Weighted Unsupported Ring Rows ");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Options: Aero Bike, Jump Squat, Mountain Climber, Sprint, Battle ropes, KB swing, Jump rope", "C. HIIT of choice for 30 seconds" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Options for Tricep: Standing Tricep Pressdown, Close Grip Push up, Close Grip Bench Press, Cable Cross Extensions, DB Skull CrusherEZ-Bar Skull Crusher ", "A. Tricep Variation" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "ID", "Description", "Name", "WorkoutID" },
                values: new object[,]
                {
                    { 8, "Options for Bicep: Cable Curl, Barbell Curl, DB Hammer Curl, Reverse Curl, ISO-Hold Curl, Supported Incline DB Curl", "B. Bicep Variation", 1 },
                    { 9, "TABATA-- 8 rounds for 20 seconds on and ONLY 10 seconds off! CHoose one exercise from the cardio list", "A. FINISHER", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workout_WorkoutTypeID",
                table: "Workout",
                column: "WorkoutTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_WorkoutType_WorkoutTypeID",
                table: "Workout",
                column: "WorkoutTypeID",
                principalTable: "WorkoutType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workout_WorkoutType_WorkoutTypeID",
                table: "Workout");

            migrationBuilder.DropIndex(
                name: "IX_Workout_WorkoutTypeID",
                table: "Workout");

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: "Options for upper push will go here from the API side");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 2,
                column: "Description",
                value: "Options for upper pull will go here from the API side");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 3,
                column: "Description",
                value: "Options for hiit will go here from the API side");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 4,
                column: "Description",
                value: "Options for Horizontal push will go here from the API side");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 5,
                column: "Description",
                value: "Options for Horizontal pull will go here from the API side");

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Options for Tricep will go here from the API side", "A. Tricep Variation" });

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Options for Bicep will go here from the API side", "B. Bicep Variation" });
        }
    }
}
