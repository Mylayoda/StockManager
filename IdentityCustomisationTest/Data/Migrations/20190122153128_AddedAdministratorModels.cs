using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityCustomisationTest.Data.Migrations
{
    public partial class AddedAdministratorModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShelfNo",
                table: "ProductLocation",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Product",
                newName: "ProductID");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "ProductLocation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductLocation_LocationID",
                table: "ProductLocation",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLocation_ProductID",
                table: "ProductLocation",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLocation_Location_LocationID",
                table: "ProductLocation",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLocation_Product_ProductID",
                table: "ProductLocation",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLocation_Location_LocationID",
                table: "ProductLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLocation_Product_ProductID",
                table: "ProductLocation");

            migrationBuilder.DropIndex(
                name: "IX_ProductLocation_LocationID",
                table: "ProductLocation");

            migrationBuilder.DropIndex(
                name: "IX_ProductLocation_ProductID",
                table: "ProductLocation");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "ProductLocation");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "ProductLocation",
                newName: "ShelfNo");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Product",
                newName: "ID");
        }
    }
}
