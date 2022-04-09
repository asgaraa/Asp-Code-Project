using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class ChangeCourseTableNow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "Apply",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "Certification",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "CourseFutures");

            migrationBuilder.AddColumn<string>(
                name: "AboutDesc",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplyDesc",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CertificationDesc",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assestmens",
                table: "CourseFutures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassDuration",
                table: "CourseFutures",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Datatime",
                table: "CourseFutures",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "CourseFutures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "CourseFutures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillsLevel",
                table: "CourseFutures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Students",
                table: "CourseFutures",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutDesc",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ApplyDesc",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CertificationDesc",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Assestmens",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "ClassDuration",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "Datatime",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "SkillsLevel",
                table: "CourseFutures");

            migrationBuilder.DropColumn(
                name: "Students",
                table: "CourseFutures");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "CourseFutures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apply",
                table: "CourseFutures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Certification",
                table: "CourseFutures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "CourseFutures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "CourseFutures",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
