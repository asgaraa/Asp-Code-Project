using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class ChangeNoticeTableEnd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Notices");

            migrationBuilder.AddColumn<string>(
                name: "DateTime",
                table: "Notices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Notices",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Notices");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
