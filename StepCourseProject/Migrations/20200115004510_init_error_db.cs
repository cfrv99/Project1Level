using Microsoft.EntityFrameworkCore.Migrations;

namespace StepCourseProject.Migrations
{
    public partial class init_error_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FreelancerPosts_AspNetUsers_FeelancerId",
                table: "FreelancerPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FreelancerPosts",
                table: "FreelancerPosts");

            migrationBuilder.DropIndex(
                name: "IX_FreelancerPosts_FeelancerId",
                table: "FreelancerPosts");

            migrationBuilder.DropColumn(
                name: "FeelancerId",
                table: "FreelancerPosts");

            migrationBuilder.AlterColumn<string>(
                name: "FreelancerId",
                table: "FreelancerPosts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FreelancerPosts",
                table: "FreelancerPosts",
                columns: new[] { "PostId", "FreelancerId" });

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerPosts_FreelancerId",
                table: "FreelancerPosts",
                column: "FreelancerId");

            migrationBuilder.AddForeignKey(
                name: "FK_FreelancerPosts_AspNetUsers_FreelancerId",
                table: "FreelancerPosts",
                column: "FreelancerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FreelancerPosts_AspNetUsers_FreelancerId",
                table: "FreelancerPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FreelancerPosts",
                table: "FreelancerPosts");

            migrationBuilder.DropIndex(
                name: "IX_FreelancerPosts_FreelancerId",
                table: "FreelancerPosts");

            migrationBuilder.AlterColumn<string>(
                name: "FreelancerId",
                table: "FreelancerPosts",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "FeelancerId",
                table: "FreelancerPosts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FreelancerPosts",
                table: "FreelancerPosts",
                columns: new[] { "PostId", "FeelancerId" });

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerPosts_FeelancerId",
                table: "FreelancerPosts",
                column: "FeelancerId");

            migrationBuilder.AddForeignKey(
                name: "FK_FreelancerPosts_AspNetUsers_FeelancerId",
                table: "FreelancerPosts",
                column: "FeelancerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
