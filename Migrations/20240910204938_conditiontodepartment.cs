using Microsoft.EntityFrameworkCore.Migrations;
using Staj_Projesi_1.Models.Classes;

#nullable disable

namespace Staj_Projesi_1.Migrations
{
    public partial class conditiontodepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Departments tablosuna Condition sütunu ekleniyor
            migrationBuilder.AddColumn<bool>(
                name: "Condition",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Eğer migration geri alınırsa, Condition sütunu kaldırılıyor
            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Departments");
        }
    }
}

