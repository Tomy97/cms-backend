using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gestor_backend.Migrations
{
    /// <inheritdoc />
    public partial class AgregadoRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "Roles",
            columns: table => new
            {
                rolId = table.Column<int>(nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                name = table.Column<string>(type: "nvarchar(100)", nullable: false),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Roles", x => x.rolId);
            });

            migrationBuilder.InsertData(
            table: "Roles",
            columns: new[] { "rolId", "name" },
            values: new object[,]
            {
                { 1, "Admin" },
                { 2, "User"  }
            });
            }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Roles");
            migrationBuilder.DeleteData(table: "Roles", keyColumn: "rolId", keyValue: 1);
            migrationBuilder.DeleteData(table: "Roles", keyColumn: "rolId", keyValue: 2);
        }
    }
}
