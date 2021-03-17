using Microsoft.EntityFrameworkCore.Migrations;

namespace ChekingSys.Migrations
{
    public partial class AddWorkersToDatabase : Migration
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
                    March1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    March31 = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
