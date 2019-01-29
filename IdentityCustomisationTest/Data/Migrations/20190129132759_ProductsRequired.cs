using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityCustomisationTest.Data.Migrations
{
    public partial class ProductsRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
