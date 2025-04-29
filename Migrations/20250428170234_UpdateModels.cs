using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gestor_backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Provincias_provinceId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Cities_cityId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_States_stateId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Users_userId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_clientId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentMethods_paymentMethodId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_productId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_States_stateId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_userId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_userId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Users",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Users",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_email",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "States",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "stateId",
                table: "States",
                newName: "StateId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Roles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "rolId",
                table: "Roles",
                newName: "RolId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Provincias",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "provinceId",
                table: "Provincias",
                newName: "ProvinceId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Products",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Products",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Products",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "stock",
                table: "Products",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "Products",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Products",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_userId",
                table: "Products",
                newName: "IX_Products_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "PaymentMethods",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "paymentMethodId",
                table: "PaymentMethods",
                newName: "PaymentMethodId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Orders",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "stateId",
                table: "Orders",
                newName: "StateId");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "Orders",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "paymentMethodId",
                table: "Orders",
                newName: "PaymentMethodId");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Orders",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "deliveryDate",
                table: "Orders",
                newName: "DeliveryDate");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Orders",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "clientId",
                table: "Orders",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_userId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_stateId",
                table: "Orders",
                newName: "IX_Orders_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_productId",
                table: "Orders",
                newName: "IX_Orders_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_paymentMethodId",
                table: "Orders",
                newName: "IX_Orders_PaymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_clientId",
                table: "Orders",
                newName: "IX_Orders_ClientId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Clients",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "rolId",
                table: "Clients",
                newName: "RolId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "cityId",
                table: "Clients",
                newName: "CityId");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Clients",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "clientId",
                table: "Clients",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "stateId",
                table: "Clients",
                newName: "ProvinciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_userId",
                table: "Clients",
                newName: "IX_Clients_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_cityId",
                table: "Clients",
                newName: "IX_Clients_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_stateId",
                table: "Clients",
                newName: "IX_Clients_ProvinciaId");

            migrationBuilder.RenameColumn(
                name: "provinceId",
                table: "Cities",
                newName: "ProvinceId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Cities",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "cityId",
                table: "Cities",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_provinceId",
                table: "Cities",
                newName: "IX_Cities_ProvinceId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Categories",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Categories",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Categories",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "Categories",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Categories",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_RolId",
                table: "Clients",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Provincias_ProvinceId",
                table: "Cities",
                column: "ProvinceId",
                principalTable: "Provincias",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Cities_CityId",
                table: "Clients",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Provincias_ProvinciaId",
                table: "Clients",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Roles_RolId",
                table: "Clients",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Users_UserId",
                table: "Clients",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodId",
                table: "Orders",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "PaymentMethodId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_States_StateId",
                table: "Orders",
                column: "StateId",
                principalTable: "States",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_UserId",
                table: "Products",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Provincias_ProvinceId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Cities_CityId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Provincias_ProvinciaId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Roles_RolId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Users_UserId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_States_StateId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_UserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Clients_RolId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Users",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Users",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "Users",
                newName: "IX_Users_email");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "States",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "States",
                newName: "stateId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Roles",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "Roles",
                newName: "rolId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Provincias",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ProvinceId",
                table: "Provincias",
                newName: "provinceId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Products",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Products",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Products",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Products",
                newName: "stock");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "image");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Products",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "categoryId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "productId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_UserId",
                table: "Products",
                newName: "IX_Products_userId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                newName: "IX_Products_categoryId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PaymentMethods",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "PaymentMethodId",
                table: "PaymentMethods",
                newName: "paymentMethodId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Orders",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "Orders",
                newName: "stateId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Orders",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "PaymentMethodId",
                table: "Orders",
                newName: "paymentMethodId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Orders",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "DeliveryDate",
                table: "Orders",
                newName: "deliveryDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Orders",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Orders",
                newName: "clientId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "orderId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                newName: "IX_Orders_userId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_StateId",
                table: "Orders",
                newName: "IX_Orders_stateId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                newName: "IX_Orders_productId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PaymentMethodId",
                table: "Orders",
                newName: "IX_Orders_paymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                newName: "IX_Orders_clientId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Clients",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "Clients",
                newName: "rolId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Clients",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Clients",
                newName: "cityId");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Clients",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Clients",
                newName: "clientId");

            migrationBuilder.RenameColumn(
                name: "ProvinciaId",
                table: "Clients",
                newName: "stateId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                newName: "IX_Clients_userId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_CityId",
                table: "Clients",
                newName: "IX_Clients_cityId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_ProvinciaId",
                table: "Clients",
                newName: "IX_Clients_stateId");

            migrationBuilder.RenameColumn(
                name: "ProvinceId",
                table: "Cities",
                newName: "provinceId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cities",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Cities",
                newName: "cityId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_ProvinceId",
                table: "Cities",
                newName: "IX_Cities_provinceId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Categories",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Categories",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Categories",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Categories",
                newName: "image");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Categories",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Provincias_provinceId",
                table: "Cities",
                column: "provinceId",
                principalTable: "Provincias",
                principalColumn: "provinceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Cities_cityId",
                table: "Clients",
                column: "cityId",
                principalTable: "Cities",
                principalColumn: "cityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_States_stateId",
                table: "Clients",
                column: "stateId",
                principalTable: "States",
                principalColumn: "stateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Users_userId",
                table: "Clients",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_clientId",
                table: "Orders",
                column: "clientId",
                principalTable: "Clients",
                principalColumn: "clientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentMethods_paymentMethodId",
                table: "Orders",
                column: "paymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "paymentMethodId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_productId",
                table: "Orders",
                column: "productId",
                principalTable: "Products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_States_stateId",
                table: "Orders",
                column: "stateId",
                principalTable: "States",
                principalColumn: "stateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_userId",
                table: "Orders",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_userId",
                table: "Products",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
