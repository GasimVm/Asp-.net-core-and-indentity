using Microsoft.EntityFrameworkCore.Migrations;

namespace MebelShop.Migrations
{
    public partial class ChangeFavoriteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Favorites",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Favorites",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
