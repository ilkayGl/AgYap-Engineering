using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DataAccessLayer.Migrations
{
    public partial class mig_addprojectentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyProjects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProjectTitle = table.Column<string>(type: "text", nullable: true),
                    ProjectTitle2 = table.Column<string>(type: "text", nullable: true),
                    ProjectKategori = table.Column<string>(type: "text", nullable: true),
                    ProjectImage = table.Column<string>(type: "text", nullable: true),
                    ProjectDetails = table.Column<string>(type: "text", nullable: true),
                    ProjectStatus = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProjects", x => x.ProjectId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyProjects");
        }
    }
}
