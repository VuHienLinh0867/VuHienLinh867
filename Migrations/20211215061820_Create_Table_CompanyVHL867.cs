using Microsoft.EntityFrameworkCore.Migrations;

namespace VuHienLinh867.Migrations
{
    public partial class Create_Table_CompanyVHL867 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyVHL867",
                columns: table => new
                {
                    CompanyId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyVHL867", x => x.CompanyId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyVHL867");
        }
    }
}
