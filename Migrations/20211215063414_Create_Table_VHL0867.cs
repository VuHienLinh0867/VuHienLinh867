using Microsoft.EntityFrameworkCore.Migrations;

namespace VuHienLinh867.Migrations
{
    public partial class Create_Table_VHL0867 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VHL0867",
                columns: table => new
                {
                    VHLId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    VHLName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    VHLGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VHL0867", x => x.VHLId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VHL0867");
        }
    }
}
