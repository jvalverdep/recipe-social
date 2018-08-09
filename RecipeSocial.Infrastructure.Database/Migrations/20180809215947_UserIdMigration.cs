using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeSocial.Infrastructure.Database.Migrations
{
    public partial class UserIdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_User_UserId1",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_UserId1",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Recipe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Recipe",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_UserId1",
                table: "Recipe",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_User_UserId1",
                table: "Recipe",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
