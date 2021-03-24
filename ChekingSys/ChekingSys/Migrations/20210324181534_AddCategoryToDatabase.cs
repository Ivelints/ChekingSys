using Microsoft.EntityFrameworkCore.Migrations;

namespace ChekingSys.Migrations
{
    public partial class AddCategoryToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamеSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M31 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shift1 = table.Column<int>(type: "int", nullable: false),
                    Shift2 = table.Column<int>(type: "int", nullable: false),
                    workedays = table.Column<double>(type: "float", nullable: false),
                    MonthlyRate = table.Column<int>(type: "int", nullable: false),
                    RegularLeave = table.Column<int>(type: "int", nullable: false),
                    UnpaidLeave = table.Column<int>(type: "int", nullable: false),
                    Motherhood = table.Column<int>(type: "int", nullable: false),
                    Illness = table.Column<int>(type: "int", nullable: false),
                    HolidaysВeekends = table.Column<int>(type: "int", nullable: false),
                    Overtime = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}
