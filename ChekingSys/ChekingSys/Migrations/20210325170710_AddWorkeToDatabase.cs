using Microsoft.EntityFrameworkCore.Migrations;

namespace ChekingSys.Migrations
{
    public partial class AddWorkeToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HolidaysВeekends",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Illness",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M1",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M10",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M11",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M12",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M13",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M14",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M15",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M16",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M17",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M18",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M19",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M2",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M20",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M21",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M22",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M23",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M24",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M25",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M26",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M27",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M28",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M29",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M3",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M30",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M31",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M4",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M5",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M6",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M7",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M8",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "M9",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "MonthlyRate",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Motherhood",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Overtime",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "RegularLeave",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Shift1",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Shift2",
                table: "Workers");

            migrationBuilder.RenameColumn(
                name: "workedays",
                table: "Workers",
                newName: "Workedays");

            migrationBuilder.RenameColumn(
                name: "UnpaidLeave",
                table: "Workers",
                newName: "Shift");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Workedays",
                table: "Workers",
                newName: "workedays");

            migrationBuilder.RenameColumn(
                name: "Shift",
                table: "Workers",
                newName: "UnpaidLeave");

            migrationBuilder.AddColumn<int>(
                name: "HolidaysВeekends",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Illness",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "M1",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M10",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M11",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M12",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M13",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M14",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M15",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M16",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M17",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M18",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M19",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M2",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M20",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M21",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M22",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M23",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M24",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M25",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M26",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M27",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M28",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M29",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M3",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M30",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M31",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M4",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M5",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M6",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M7",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M8",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M9",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonthlyRate",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Motherhood",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Overtime",
                table: "Workers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "RegularLeave",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Shift1",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Shift2",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
