using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdateSliderDetailTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_SlidersDetails_SliderDetailId",
                table: "Sliders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SlidersDetails",
                table: "SlidersDetails");

            migrationBuilder.RenameTable(
                name: "SlidersDetails",
                newName: "SliderDetails");

            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "SliderDetails",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SliderDetails",
                table: "SliderDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_SliderDetails_SliderDetailId",
                table: "Sliders",
                column: "SliderDetailId",
                principalTable: "SliderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_SliderDetails_SliderDetailId",
                table: "Sliders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SliderDetails",
                table: "SliderDetails");

            migrationBuilder.RenameTable(
                name: "SliderDetails",
                newName: "SlidersDetails");

            migrationBuilder.AlterColumn<int>(
                name: "Desc",
                table: "SlidersDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SlidersDetails",
                table: "SlidersDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_SlidersDetails_SliderDetailId",
                table: "Sliders",
                column: "SliderDetailId",
                principalTable: "SlidersDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
