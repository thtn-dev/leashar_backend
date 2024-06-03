using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leashar.Infrastructure.Data.Migrations.App
{
    /// <inheritdoc />
    public partial class InitialAppMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(50)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    HashedPassword = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
