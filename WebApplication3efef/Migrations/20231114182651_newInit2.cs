using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3efef.Migrations
{
    public partial class newInit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HumanId",
                table: "Humans",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HumanId",
                table: "Humans");
        }
    }
}
