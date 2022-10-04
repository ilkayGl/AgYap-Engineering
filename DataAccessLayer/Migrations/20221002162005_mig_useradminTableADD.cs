using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DataAccessLayer.Migrations
{
    public partial class mig_useradminTableADD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAdmins",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    UserMail = table.Column<string>(type: "text", nullable: true),
                    UserPassword = table.Column<string>(type: "text", nullable: true),
                    UserPasswordConfirm = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdmins", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAdmins");
        }
    }
}
