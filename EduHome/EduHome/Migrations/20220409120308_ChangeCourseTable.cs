using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class ChangeCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseFutures_Courses_CourseId",
                table: "CourseFutures");

            migrationBuilder.DropIndex(
                name: "IX_CourseFutures_CourseId",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "CourseFutures");

            migrationBuilder.AddColumn<int>(
                name: "CourseFutureId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseFutureId",
                table: "Courses",
                column: "CourseFutureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseFutures_CourseFutureId",
                table: "Courses",
                column: "CourseFutureId",
                principalTable: "CourseFutures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseFutures_CourseFutureId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseFutureId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseFutureId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "CourseFutures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourseFutures_CourseId",
                table: "CourseFutures",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFutures_Courses_CourseId",
                table: "CourseFutures",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
