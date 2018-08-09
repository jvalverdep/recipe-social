using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeSocial.Infrastructure.Database.Migrations
{
    public partial class TagString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tag",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Tag",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
