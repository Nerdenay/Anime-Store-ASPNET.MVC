using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Staj_Projesi_1.Migrations
{
    public partial class updateoncurrents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentPassword",
                table: "Currentss",
                type: "Varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentPassword",
                table: "Currentss");
        }
    }
}
