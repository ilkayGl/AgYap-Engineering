using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_newmignwe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detail2",
                table: "MyProjects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail3",
                table: "MyProjects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail4",
                table: "MyProjects",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detail2",
                table: "MyProjects");

            migrationBuilder.DropColumn(
                name: "Detail3",
                table: "MyProjects");

            migrationBuilder.DropColumn(
                name: "Detail4",
                table: "MyProjects");
        }
    }
}
