using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToTable_HouseType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "32f165fa-dccc-4af7-9c16-03f08bdea3bd");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cea7ebc-4eb5-408e-8851-1f3f8871d81a", "24eba529-f6e1-4a09-ba7d-8cc2297847c0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4421b9d-c1d2-478a-b710-e2d43b9b4251", "38fc5544-569a-4f04-9373-6761915e73d5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cea7ebc-4eb5-408e-8851-1f3f8871d81a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4421b9d-c1d2-478a-b710-e2d43b9b4251");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24eba529-f6e1-4a09-ba7d-8cc2297847c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38fc5544-569a-4f04-9373-6761915e73d5");

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
                table: "HouseTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Apartamento" },
                    { 2, "Moradia, sem exterior" },
                    { 3, "Moradia, com exterior" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "HouseTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HouseTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HouseTypes",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6cea7ebc-4eb5-408e-8851-1f3f8871d81a", null, "Admin", "ADMIN" },
                    { "f4421b9d-c1d2-478a-b710-e2d43b9b4251", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "24eba529-f6e1-4a09-ba7d-8cc2297847c0", 0, null, null, null, "f99ec426-ac8a-4206-8500-792a7d6df153", null, new DateTime(2023, 6, 7, 20, 43, 57, 737, DateTimeKind.Local).AddTicks(7648), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEPzI7Y3Ps/HDH3r5HaIXxy/ke08IZVzXiG1fjWpv/+Dw7NCLSEPfYEZ43lnCfT7xLw==", null, false, null, "b24eb5cf-cc3f-4585-8f53-c50e114f293d", "Masculino", null, false, "admin@admin.com", null },
                    { "38fc5544-569a-4f04-9373-6761915e73d5", 0, null, null, null, "4d3f65ec-d9e0-483a-8f30-3e147a46bc0a", null, new DateTime(2023, 6, 7, 20, 43, 57, 678, DateTimeKind.Local).AddTicks(2421), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAELCMqMP3pX5FEQ3WeYitzpDqbbRiEwdKOXziXcdMlQI8sy8stPr6USP7Y9sLm82xxg==", null, false, null, "d74c779e-a763-498a-8e3e-bb96c79f7fdc", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "32f165fa-dccc-4af7-9c16-03f08bdea3bd", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "38fc5544-569a-4f04-9373-6761915e73d5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6cea7ebc-4eb5-408e-8851-1f3f8871d81a", "24eba529-f6e1-4a09-ba7d-8cc2297847c0" },
                    { "f4421b9d-c1d2-478a-b710-e2d43b9b4251", "38fc5544-569a-4f04-9373-6761915e73d5" }
                });
        }
    }
}
