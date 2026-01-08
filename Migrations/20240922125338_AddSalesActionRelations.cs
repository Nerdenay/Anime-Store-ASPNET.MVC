using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Staj_Projesi_1.Migrations
{
    public partial class AddSalesActionRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
        
            migrationBuilder.CreateIndex(
                name: "IX_SalesActions_CurrentID",
                table: "SalesActions",
                column: "CurrentID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesActions_ProductID",
                table: "SalesActions",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesActions_Currentss_CurrentID",
                table: "SalesActions",
                column: "CurrentID",
                principalTable: "Currentss",
                principalColumn: "CurrentID",
				onDelete: ReferentialAction.Restrict); // Değişiklik burada

			migrationBuilder.AddForeignKey(
                name: "FK_SalesActions_Productss_ProductID",
                table: "SalesActions",
                column: "ProductID",
                principalTable: "Productss",
                principalColumn: "ProductID",
			    onDelete: ReferentialAction.Restrict); // Değişiklik burada

		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesActions_Currentss_CurrentID",
                table: "SalesActions");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesActions_Productss_ProductID",
                table: "SalesActions");

            migrationBuilder.DropIndex(
                name: "IX_SalesActions_CurrentID",
                table: "SalesActions");

            migrationBuilder.DropIndex(
                name: "IX_SalesActions_ProductID",
                table: "SalesActions");

      
        }
    }
}
