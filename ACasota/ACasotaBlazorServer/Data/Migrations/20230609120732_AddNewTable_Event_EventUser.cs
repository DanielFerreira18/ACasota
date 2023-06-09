using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_Event_EventUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "26405b99-050f-4c6d-9b38-c60766e4130f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e3625aea-1484-4ee0-91bf-83a1f42a26c2", "dc2770ee-a49c-46f8-b130-14eeb7e717f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b06cf169-041b-4b58-b4da-47058ecc6de6", "dffa4360-8ba9-4639-a5d5-edeba0aa11b7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b06cf169-041b-4b58-b4da-47058ecc6de6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3625aea-1484-4ee0-91bf-83a1f42a26c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc2770ee-a49c-46f8-b130-14eeb7e717f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dffa4360-8ba9-4639-a5d5-edeba0aa11b7");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InitialDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventUsers",
                columns: table => new
                {
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventUsers", x => new { x.UserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_EventUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventUsers_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8215409f-4373-40ab-b252-2d81a40d1fad", null, "Admin", "ADMIN" },
                    { "bcce4b9e-8c1a-4543-a8dd-93d066278bc8", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "2f5dd026-07ae-4907-b7dc-e3f49b48563f", 0, null, null, null, "643c990b-0c5b-483c-a9e3-59a16b774531", null, new DateTime(2023, 6, 9, 13, 7, 32, 339, DateTimeKind.Local).AddTicks(8697), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAELRK13EE+Zp5ssgVJTtpPfbuleTjRGcmIizyDQTZh/3VlnPRw83Vr4pRU05z9UrBUQ==", null, false, null, "6995c7d8-8ea4-4a9c-9422-66c00d83265a", "Masculino", null, false, "admin@admin.com", null },
                    { "f95eb94a-6783-4144-9914-6b454bb97188", 0, null, null, null, "2fc5a97f-4b66-4230-b1a6-30eac4f0c634", null, new DateTime(2023, 6, 9, 13, 7, 32, 278, DateTimeKind.Local).AddTicks(5134), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEFKRm0OJL33cJw5UVgtPD3KQ/K4wiAiVNqhafOz3a0W2WVdioAOY/LoNbCf9QNtDgw==", null, false, null, "c1ce1852-4e7c-416f-b102-0c2dabf0ee17", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "7babda73-efa8-4f44-89d8-b0c62d73a463", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "f95eb94a-6783-4144-9914-6b454bb97188" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8215409f-4373-40ab-b252-2d81a40d1fad", "2f5dd026-07ae-4907-b7dc-e3f49b48563f" },
                    { "bcce4b9e-8c1a-4543-a8dd-93d066278bc8", "f95eb94a-6783-4144-9914-6b454bb97188" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventUsers_EventId",
                table: "EventUsers",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventUsers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "7babda73-efa8-4f44-89d8-b0c62d73a463");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8215409f-4373-40ab-b252-2d81a40d1fad", "2f5dd026-07ae-4907-b7dc-e3f49b48563f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bcce4b9e-8c1a-4543-a8dd-93d066278bc8", "f95eb94a-6783-4144-9914-6b454bb97188" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8215409f-4373-40ab-b252-2d81a40d1fad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcce4b9e-8c1a-4543-a8dd-93d066278bc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f5dd026-07ae-4907-b7dc-e3f49b48563f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f95eb94a-6783-4144-9914-6b454bb97188");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b06cf169-041b-4b58-b4da-47058ecc6de6", null, "Admin", "ADMIN" },
                    { "e3625aea-1484-4ee0-91bf-83a1f42a26c2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "dc2770ee-a49c-46f8-b130-14eeb7e717f2", 0, null, null, null, "1ebb072f-7a6c-4b31-a000-acc27b794bb5", null, new DateTime(2023, 6, 7, 21, 3, 32, 63, DateTimeKind.Local).AddTicks(1307), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAECKNWPTTAp2a2Hs9IE0YUVvLz5FwNpAMRbKKMBmiFB/yxpdMPTcPH7FoDuPg0MLXog==", null, false, null, "9c81fb6c-2c3a-4a8d-bd4d-946fc7b5ca4e", "Masculino", null, false, "user@user.com", null },
                    { "dffa4360-8ba9-4639-a5d5-edeba0aa11b7", 0, null, null, null, "a488859e-e364-4928-8c9c-d5538bf2a10f", null, new DateTime(2023, 6, 7, 21, 3, 32, 123, DateTimeKind.Local).AddTicks(5375), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEPBgEPz4Fbce9kuX3Q3FdRpjGu56vFkCIYiV6dk/PgXe4CXzmPDtWtu3WRwpHP5Y5A==", null, false, null, "9c9d99ae-18ed-46c9-913a-cf88409215f5", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "26405b99-050f-4c6d-9b38-c60766e4130f", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "dc2770ee-a49c-46f8-b130-14eeb7e717f2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e3625aea-1484-4ee0-91bf-83a1f42a26c2", "dc2770ee-a49c-46f8-b130-14eeb7e717f2" },
                    { "b06cf169-041b-4b58-b4da-47058ecc6de6", "dffa4360-8ba9-4639-a5d5-edeba0aa11b7" }
                });
        }
    }
}
