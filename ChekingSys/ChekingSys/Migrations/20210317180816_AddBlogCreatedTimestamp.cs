using Microsoft.EntityFrameworkCore.Migrations;

namespace ChekingSys.Migrations
{
    public partial class AddBlogCreatedTimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Illness",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<int>(
                name: "UnpaidLeave",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "workedays",
                table: "Workers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ХolidaysВeekends",
                table: "Workers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Illness",
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

            migrationBuilder.DropColumn(
                name: "UnpaidLeave",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "workedays",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "ХolidaysВeekends",
                table: "Workers");
        }
    }
}
