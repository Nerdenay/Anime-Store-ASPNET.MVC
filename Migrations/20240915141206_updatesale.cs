using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Staj_Projesi_1.Migrations
{
    public partial class updatesale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentID",
                table: "SalesActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "SalesActions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentID",
                table: "SalesActions");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "SalesActions");
        }
    }
}
