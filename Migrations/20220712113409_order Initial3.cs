using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnCodeFirstApproach.Migrations
{
    public partial class orderInitial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "JoinedTable",
                newName: "JoinTables");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "JoinTables",
                newName: "JoinedTable");
        }
    }
}
