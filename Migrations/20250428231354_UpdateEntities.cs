using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gestor_backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            DateTime now = new DateTime(2025, 4, 26, 2, 36, 9, 746, DateTimeKind.Utc);
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Provincias_ProvinciaId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "ProvinciaId",
                table: "Clients",
                newName: "ProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_ProvinciaId",
                table: "Clients",
                newName: "IX_Clients_ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Provincias_ProvinceId",
                table: "Clients",
                column: "ProvinceId",
                principalTable: "Provincias",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.InsertData(
            table: "Users",
               columns: new[] { "UserId", "Email", "Password", "CreatedAt", "UpdatedAt" },
               values: new object[,]
               {
                        { 1, "admin@admin.com", "6c04bf3d6c349471eaaa55df0cc85107", now, now },
               });

            migrationBuilder.InsertData(
            table: "Clients",
               columns: new[] { "ClientId", "UserId", "ProvinceId", "CityId", "RolId", "Name", "Address", "CreatedAt", "UpdatedAt" },
               values: new object[,]
               {
                 { 1, 1, 1, 1, 1, "Admin", "", now, now},
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Provincias_ProvinceId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "ProvinceId",
                table: "Clients",
                newName: "ProvinciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_ProvinceId",
                table: "Clients",
                newName: "IX_Clients_ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Provincias_ProvinciaId",
                table: "Clients",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
