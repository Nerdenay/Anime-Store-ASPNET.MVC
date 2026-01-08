using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Staj_Projesi_1.Migrations
{
    public partial class updatecurretns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.AddColumn<bool>(
                name: "Condition",
                table: "Currentss",
                type: "bit",
                nullable: false,
                defaultValue: false);

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {         

             migrationBuilder.DropColumn(
                name: "Condition",
                table: "Currentss");

           
        }
    }
}
