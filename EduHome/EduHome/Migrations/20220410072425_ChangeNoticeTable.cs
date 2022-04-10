using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class ChangeNoticeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoticeDate",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "NoticeDateFive",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "NoticeDateFour",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "NoticeDateSecond",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "NoticeDateSix",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "NoticeDateThird",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "NoticeDesc",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "NoticeDescFive",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "NoticeDescFour",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "NoticeDescSecond",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "NoticeDescSix",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "NoticeDescThird",
                table: "Notices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NoticeDate",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoticeDateFive",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoticeDateFour",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoticeDateSecond",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoticeDateSix",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoticeDateThird",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoticeDesc",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoticeDescFive",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoticeDescFour",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoticeDescSecond",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoticeDescSix",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoticeDescThird",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
