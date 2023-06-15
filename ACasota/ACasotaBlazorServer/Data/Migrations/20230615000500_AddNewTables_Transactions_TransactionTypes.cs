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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    TypeId = table.Column<int>(type: "int", nullable: false),
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
                values: new object[] { "3e50815d-6761-416b-8bea-156c276ef21f", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9eec9bd7-1160-4a2b-b163-be7247077bb1", null, "User", "USER" },
                    { "b13c41f8-dd3d-4329-9dca-ce8544272a19", null, "Partner", "PARTNER" },
                    { "c3c93b7c-eb08-4037-8449-197277098eac", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "0f0df311-a368-4353-803d-e39c80d3b9de", 0, null, null, null, "c3235f43-ae9d-4c7f-86fb-ee793b40a67a", null, new DateTime(2023, 6, 15, 1, 5, 0, 286, DateTimeKind.Local).AddTicks(7218), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAELJcfegKuslv0DdhDNb3Qi0pwhNux8+/iV6dnLsveR0goay+sAg4Bua5Xyyzu9XW7w==", null, false, null, "f2deb7a1-20ea-4c8e-8e4b-3e7e7eca9c5c", "Masculino", null, false, "user@user.com", null },
                    { "1f016672-c1d4-4abf-a754-699e22bfe652", 0, null, null, null, "97c32893-2741-469f-a795-e592e961e693", null, new DateTime(2023, 6, 15, 1, 5, 0, 469, DateTimeKind.Local).AddTicks(9750), "partner@partner.com", false, "Partner", true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEEOe2IcSYB7c3rvYONpIN8Hz8D/HDzOf0+peUAu58WhGuNg86vlff26HdwihcCl6Rw==", null, false, null, "a93aa1c8-63d1-4269-8f64-a30a367f9b2b", "Feminino", null, false, "partner@partner.com", null },
                    { "b4d09491-e8bc-485e-99dc-690561de63b9", 0, null, null, null, "17940042-e9c3-43df-9ac2-6a098114ed31", null, new DateTime(2023, 6, 15, 1, 5, 0, 383, DateTimeKind.Local).AddTicks(1841), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAECAI/ZMd2ucAV1FBFFGAvZKx103ABvh+SJLnwZwQgCt9ILlT9tuSKjsdizCa2cMw3g==", null, false, null, "d98a9e25-ff81-4d1b-afeb-a98da04e7b4c", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { 1, "Share Payment for the Partners of the association.", "Share" },
                    { 2, "Donation that all users can make to help the association financially.", "Donation" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "d0344c97-bf95-4886-bf7d-45cb35989fa0", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "0f0df311-a368-4353-803d-e39c80d3b9de" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9eec9bd7-1160-4a2b-b163-be7247077bb1", "0f0df311-a368-4353-803d-e39c80d3b9de" },
                    { "b13c41f8-dd3d-4329-9dca-ce8544272a19", "1f016672-c1d4-4abf-a754-699e22bfe652" },
                    { "c3c93b7c-eb08-4037-8449-197277098eac", "b4d09491-e8bc-485e-99dc-690561de63b9" }
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
                keyValue: "3e50815d-6761-416b-8bea-156c276ef21f");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "d0344c97-bf95-4886-bf7d-45cb35989fa0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9eec9bd7-1160-4a2b-b163-be7247077bb1", "0f0df311-a368-4353-803d-e39c80d3b9de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b13c41f8-dd3d-4329-9dca-ce8544272a19", "1f016672-c1d4-4abf-a754-699e22bfe652" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3c93b7c-eb08-4037-8449-197277098eac", "b4d09491-e8bc-485e-99dc-690561de63b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eec9bd7-1160-4a2b-b163-be7247077bb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b13c41f8-dd3d-4329-9dca-ce8544272a19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3c93b7c-eb08-4037-8449-197277098eac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f0df311-a368-4353-803d-e39c80d3b9de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f016672-c1d4-4abf-a754-699e22bfe652");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4d09491-e8bc-485e-99dc-690561de63b9");

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
