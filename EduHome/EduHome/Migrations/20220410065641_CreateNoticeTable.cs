using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class CreateNoticeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(nullable: true),
                    NoticeDate = table.Column<string>(nullable: true),
                    NoticeDesc = table.Column<string>(nullable: true),
                    NoticeDateSecond = table.Column<string>(nullable: true),
                    NoticeDescSecond = table.Column<string>(nullable: true),
                    NoticeDateThird = table.Column<string>(nullable: true),
                    NoticeDescThird = table.Column<string>(nullable: true),
                    NoticeDateFour = table.Column<string>(nullable: true),
                    NoticeDescFour = table.Column<string>(nullable: true),
                    NoticeDateFive = table.Column<string>(nullable: true),
                    NoticeDescFive = table.Column<string>(nullable: true),
                    NoticeDateSix = table.Column<string>(nullable: true),
                    NoticeDescSix = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notices");
        }
    }
}
