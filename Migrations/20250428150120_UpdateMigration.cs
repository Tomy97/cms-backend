using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gestor_backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "rolId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Cities",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "provinceId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    provinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.provinceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_provinceId",
                table: "Cities",
                column: "provinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Provincias_provinceId",
                table: "Cities",
                column: "provinceId",
                principalTable: "Provincias",
                principalColumn: "provinceId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Provincias_provinceId",
                table: "Cities");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropIndex(
                name: "IX_Cities_provinceId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "rolId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "provinceId",
                table: "Cities");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
