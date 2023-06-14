using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTables_Transactions_TransactionTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "25a3eff2-e19e-4193-b942-1f310ac748a1");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "d46eb452-dcae-4fd4-8e3e-e87928d73f83");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12c79e2e-3b3f-4010-862f-20fd287c3deb", "482d381d-deef-43ee-8c32-1131d508468c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40ca0164-ab60-420c-aa36-47a2a5cd4bf9", "b7084a3c-c594-440f-8f53-70d1dd11c4a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d58ed447-9716-4244-a09f-bd45c45c3cbd", "bcf2c623-f098-40c8-b3b9-75b36f6cf613" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12c79e2e-3b3f-4010-862f-20fd287c3deb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40ca0164-ab60-420c-aa36-47a2a5cd4bf9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d58ed447-9716-4244-a09f-bd45c45c3cbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "482d381d-deef-43ee-8c32-1131d508468c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7084a3c-c594-440f-8f53-70d1dd11c4a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcf2c623-f098-40c8-b3b9-75b36f6cf613");

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProofPicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTransaction = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatePayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    TypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_TransactionTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "3bae6cb5-766c-4c8c-9e8c-f5110983b8e1", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "185d0372-aa33-4d11-8223-a88b196d6ec5", null, "User", "USER" },
                    { "291642c1-14ed-4380-9929-19e450eecf87", null, "Admin", "ADMIN" },
                    { "d63181d4-6424-47e6-90ba-5cef6e57399b", null, "Partner", "PARTNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "0fcfed8e-5158-4229-967a-cf643f9bd39e", 0, null, null, null, "3ce7ea4f-5d0b-49be-b7ed-ab1426adfb87", null, new DateTime(2023, 6, 14, 20, 42, 20, 175, DateTimeKind.Local).AddTicks(5278), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEA6saqucMbYTtj6SdR8CaowxOK1Sd5Q3nT6ZfgLy/Ztc5jRqWliqiMyvJfCn4b0LTg==", null, false, null, "58854dfd-35f8-4afc-a031-424a1d7944cd", "Masculino", null, false, "admin@admin.com", null },
                    { "61bebc33-64b5-40a7-a384-c406e25db265", 0, null, null, null, "7359b394-2598-446f-97a6-f85611b6ebdc", null, new DateTime(2023, 6, 14, 20, 42, 20, 260, DateTimeKind.Local).AddTicks(6374), "partner@partner.com", false, "Partner", true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEJRCJfqHEjy3URLACvoG2Zs+G1Y2GANCHXVDOPhVaVqsPakShgiCNDxPgIV1zB6CAA==", null, false, null, "b116f6a4-8b54-4b69-94d3-4c1a52ec2d85", "Feminino", null, false, "partner@partner.com", null },
                    { "f18e14ce-5605-46b4-a3ec-a239984057d7", 0, null, null, null, "f1fe0fa0-c865-4d71-99e0-66d23576baa9", null, new DateTime(2023, 6, 14, 20, 42, 20, 59, DateTimeKind.Local).AddTicks(9414), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEEb7+pn7RHrgo+QUkJZTtBLI2NsXGgm8lFN3ATpT7KPCa+U6PPOENqLNGJQUy1XiPg==", null, false, null, "0af0f07e-8368-4bd6-a03d-f9fd6c807d75", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "0220dcee-ac73-4a8a-aea9-a764c04beea7", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "f18e14ce-5605-46b4-a3ec-a239984057d7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "291642c1-14ed-4380-9929-19e450eecf87", "0fcfed8e-5158-4229-967a-cf643f9bd39e" },
                    { "d63181d4-6424-47e6-90ba-5cef6e57399b", "61bebc33-64b5-40a7-a384-c406e25db265" },
                    { "185d0372-aa33-4d11-8223-a88b196d6ec5", "f18e14ce-5605-46b4-a3ec-a239984057d7" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TypeId",
                table: "Transactions",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "0220dcee-ac73-4a8a-aea9-a764c04beea7");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "3bae6cb5-766c-4c8c-9e8c-f5110983b8e1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "291642c1-14ed-4380-9929-19e450eecf87", "0fcfed8e-5158-4229-967a-cf643f9bd39e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d63181d4-6424-47e6-90ba-5cef6e57399b", "61bebc33-64b5-40a7-a384-c406e25db265" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "185d0372-aa33-4d11-8223-a88b196d6ec5", "f18e14ce-5605-46b4-a3ec-a239984057d7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "185d0372-aa33-4d11-8223-a88b196d6ec5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "291642c1-14ed-4380-9929-19e450eecf87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d63181d4-6424-47e6-90ba-5cef6e57399b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fcfed8e-5158-4229-967a-cf643f9bd39e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61bebc33-64b5-40a7-a384-c406e25db265");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f18e14ce-5605-46b4-a3ec-a239984057d7");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "d46eb452-dcae-4fd4-8e3e-e87928d73f83", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12c79e2e-3b3f-4010-862f-20fd287c3deb", null, "Partner", "PARTNER" },
                    { "40ca0164-ab60-420c-aa36-47a2a5cd4bf9", null, "Admin", "ADMIN" },
                    { "d58ed447-9716-4244-a09f-bd45c45c3cbd", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "482d381d-deef-43ee-8c32-1131d508468c", 0, null, null, null, "59886b4f-b1db-4173-841b-b6ffa38e8300", null, new DateTime(2023, 6, 14, 19, 42, 16, 716, DateTimeKind.Local).AddTicks(8353), "partner@partner.com", false, "Partner", true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEH4sqre2TcoWHpqdPa2rGtGZ/dYzcy4/AkwTZci0j1WzVK+VTgJicaPxbX8d+zdYpg==", null, false, null, "e5ce30e4-e6f4-498a-b8e1-8b47f32dd490", "Feminino", null, false, "partner@partner.com", null },
                    { "b7084a3c-c594-440f-8f53-70d1dd11c4a0", 0, null, null, null, "946e138f-7455-4cfe-9ffa-59829693d60b", null, new DateTime(2023, 6, 14, 19, 42, 16, 615, DateTimeKind.Local).AddTicks(5800), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAELTGPq8VxxXQCKJEKPR1IMbkvPs4YKasWz7w6Chr2kFWkklXXLN8ifCBrXIX/Xtt0g==", null, false, null, "956e452c-81fb-4857-97d6-4b8912c5012d", "Masculino", null, false, "admin@admin.com", null },
                    { "bcf2c623-f098-40c8-b3b9-75b36f6cf613", 0, null, null, null, "e720c394-1ff8-47bf-a72d-d5da1d9aced2", null, new DateTime(2023, 6, 14, 19, 42, 16, 505, DateTimeKind.Local).AddTicks(1844), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAECymn8N5HpSCrAItYILCpTfKiGgj3m12pKtuHdT6V5d9Tw2+R/m5RLn2c7S+CSgtNQ==", null, false, null, "10e834af-436a-4c17-a226-32a1df890b7c", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "25a3eff2-e19e-4193-b942-1f310ac748a1", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "bcf2c623-f098-40c8-b3b9-75b36f6cf613" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "12c79e2e-3b3f-4010-862f-20fd287c3deb", "482d381d-deef-43ee-8c32-1131d508468c" },
                    { "40ca0164-ab60-420c-aa36-47a2a5cd4bf9", "b7084a3c-c594-440f-8f53-70d1dd11c4a0" },
                    { "d58ed447-9716-4244-a09f-bd45c45c3cbd", "bcf2c623-f098-40c8-b3b9-75b36f6cf613" }
                });
        }
    }
}
