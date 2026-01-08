using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Staj_Projesi_1.Migrations
{
    public partial class updatesaless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesActions_Currentss_CurrentsCurrentID",
                table: "SalesActions");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesActions_Productss_ProductsProductID",
                table: "SalesActions");

            migrationBuilder.DropIndex(
                name: "IX_SalesActions_CurrentsCurrentID",
                table: "SalesActions");

            migrationBuilder.DropIndex(
                name: "IX_SalesActions_ProductsProductID",
                table: "SalesActions");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "SalesActions",
                newName: "ProductsProductID1");

            migrationBuilder.RenameColumn(
                name: "CurrentID",
                table: "SalesActions",
                newName: "CurrentsCurrentID1");

            migrationBuilder.CreateIndex(
                name: "IX_SalesActions_CurrentsCurrentID1",
                table: "SalesActions",
                column: "CurrentsCurrentID1");

            migrationBuilder.CreateIndex(
                name: "IX_SalesActions_ProductsProductID1",
                table: "SalesActions",
                column: "ProductsProductID1");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesActions_Currentss_CurrentsCurrentID1",
                table: "SalesActions",
                column: "CurrentsCurrentID1",
                principalTable: "Currentss",
                principalColumn: "CurrentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesActions_Productss_ProductsProductID1",
                table: "SalesActions",
                column: "ProductsProductID1",
                principalTable: "Productss",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesActions_Currentss_CurrentsCurrentID1",
                table: "SalesActions");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesActions_Productss_ProductsProductID1",
                table: "SalesActions");

            migrationBuilder.DropIndex(
                name: "IX_SalesActions_CurrentsCurrentID1",
                table: "SalesActions");

            migrationBuilder.DropIndex(
                name: "IX_SalesActions_ProductsProductID1",
                table: "SalesActions");

            migrationBuilder.RenameColumn(
                name: "ProductsProductID1",
                table: "SalesActions",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "CurrentsCurrentID1",
                table: "SalesActions",
                newName: "CurrentID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesActions_CurrentsCurrentID",
                table: "SalesActions",
                column: "CurrentsCurrentID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesActions_ProductsProductID",
                table: "SalesActions",
                column: "ProductsProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesActions_Currentss_CurrentsCurrentID",
                table: "SalesActions",
                column: "CurrentsCurrentID",
                principalTable: "Currentss",
                principalColumn: "CurrentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesActions_Productss_ProductsProductID",
                table: "SalesActions",
                column: "ProductsProductID",
                principalTable: "Productss",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
