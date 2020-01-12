using Microsoft.EntityFrameworkCore.Migrations;

namespace StepCourseProject.Migrations
{
    public partial class init_post : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HaveIsDoneBid",
                table: "Posts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HaveIsDoneBid",
                table: "Posts");
        }
    }
}
