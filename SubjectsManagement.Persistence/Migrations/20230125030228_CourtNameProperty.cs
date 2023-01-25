using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SubjectsManagement.Persistence.Migrations
{
    public partial class CourtNameProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Courts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Courts");
        }
    }
}
