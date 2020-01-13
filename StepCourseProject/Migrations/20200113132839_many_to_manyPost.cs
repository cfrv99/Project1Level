using Microsoft.EntityFrameworkCore.Migrations;

namespace StepCourseProject.Migrations
{
    public partial class many_to_manyPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FreelancerPosts",
                columns: table => new
                {
                    FeelancerId = table.Column<string>(nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    FreelancerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerPosts", x => new { x.PostId, x.FeelancerId });
                    table.ForeignKey(
                        name: "FK_FreelancerPosts_AspNetUsers_FeelancerId",
                        column: x => x.FeelancerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FreelancerPosts_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerPosts_FeelancerId",
                table: "FreelancerPosts",
                column: "FeelancerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FreelancerPosts");
        }
    }
}
