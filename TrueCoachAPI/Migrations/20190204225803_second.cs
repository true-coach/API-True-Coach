using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrueCoachAPI.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workout_Goal_GoalID",
                table: "Workout");

            migrationBuilder.DropTable(
                name: "Goal");

            migrationBuilder.DropIndex(
                name: "IX_Workout_GoalID",
                table: "Workout");

            migrationBuilder.DropColumn(
                name: "GoalID",
                table: "Workout");

            migrationBuilder.AddColumn<int>(
                name: "WorkoutGoals",
                table: "Workout",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "WorkoutType",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Upper Body" },
                    { 2, "Lower Body" },
                    { 3, "Full Body" },
                    { 4, "Core" }
                });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "ID", "WorkoutGoals", "WorkoutTypeID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "ID", "Description", "Name", "WorkoutID" },
                values: new object[,]
                {
                    { 1, "Options for upper push will go here from the API side", "A. Upper Push", 1 },
                    { 2, "Options for upper pull will go here from the API side", "B. Upper Pull", 1 },
                    { 3, "Options for hiit will go here from the API side", "C. HIIT of choice for 30 seconds", 1 },
                    { 4, "Options for Horizontal push will go here from the API side", "A. Horizontal Push", 1 },
                    { 5, "Options for Horizontal pull will go here from the API side", "B. Horizontal pull", 1 },
                    { 6, "Options for Tricep will go here from the API side", "A. Tricep Variation", 1 },
                    { 7, "Options for Bicep will go here from the API side", "B. Bicep Variation", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkoutType",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkoutType",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkoutType",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkoutType",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "WorkoutGoals",
                table: "Workout");

            migrationBuilder.AddColumn<int>(
                name: "GoalID",
                table: "Workout",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Goal",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goal", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workout_GoalID",
                table: "Workout",
                column: "GoalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_Goal_GoalID",
                table: "Workout",
                column: "GoalID",
                principalTable: "Goal",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
