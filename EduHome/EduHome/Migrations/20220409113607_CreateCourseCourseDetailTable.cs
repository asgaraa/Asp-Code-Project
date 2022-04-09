using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class CreateCourseCourseDetailTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseFutures_Courses_CourseId",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "FeatureId",
                table: "CourseFutures");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CourseFutures",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFutures_Courses_CourseId",
                table: "CourseFutures",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseFutures_Courses_CourseId",
                table: "CourseFutures");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CourseFutures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "FeatureId",
                table: "CourseFutures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFutures_Courses_CourseId",
                table: "CourseFutures",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
