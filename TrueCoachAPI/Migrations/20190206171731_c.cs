using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrueCoachAPI.Migrations
{
    public partial class c : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "WorkoutType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_WorkoutID",
                table: "Exercise",
                column: "WorkoutID");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_WorkoutTypeID",
                table: "Workout",
                column: "WorkoutTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "WorkoutType");
        }
    }
}
