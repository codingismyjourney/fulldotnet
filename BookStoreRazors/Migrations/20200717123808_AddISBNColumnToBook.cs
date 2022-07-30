using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreRazors.Migrations
{
    public partial class AddISBNColumnToBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ISBN",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Books");
        }
    }
}
