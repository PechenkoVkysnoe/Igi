using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB_053505_HRIGORCHUK.Migrations
{
    public partial class EntitiesAdded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categories1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories1",
                table: "Categories1",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories1_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Categories1",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories1_CategoryId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories1",
                table: "Categories1");

            migrationBuilder.RenameTable(
                name: "Categories1",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
