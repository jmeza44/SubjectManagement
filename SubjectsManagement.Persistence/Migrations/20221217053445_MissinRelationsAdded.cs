using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SubjectsManagement.Persistence.Migrations
{
    public partial class MissinRelationsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourtId",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourtId",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CourtId",
                table: "Topics",
                column: "CourtId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CourtId",
                table: "Activities",
                column: "CourtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Courts_CourtId",
                table: "Activities",
                column: "CourtId",
                principalTable: "Courts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Courts_CourtId",
                table: "Topics",
                column: "CourtId",
                principalTable: "Courts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Courts_CourtId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Courts_CourtId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_CourtId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Activities_CourtId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "CourtId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "CourtId",
                table: "Activities");
        }
    }
}
