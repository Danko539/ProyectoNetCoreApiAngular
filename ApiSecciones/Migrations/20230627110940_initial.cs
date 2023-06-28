using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSecciones.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "seccions",
                columns: table => new
                {
                    seccionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seccionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seccionCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seccions", x => x.seccionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "seccions");
        }
    }
}
