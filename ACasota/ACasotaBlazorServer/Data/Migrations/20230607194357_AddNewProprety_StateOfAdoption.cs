using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewProprety_StateOfAdoption : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "b4aad935-6702-4f40-a939-e11c943e0d76");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60fef3ef-cad6-46cc-aab9-0a2835399573", "05d87726-71ee-4e38-a077-bae15b3845fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "90bdd9a0-8cf8-4916-8db0-261361dd2eef", "5f84a4d0-378d-4112-a52f-f292f7617573" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60fef3ef-cad6-46cc-aab9-0a2835399573");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90bdd9a0-8cf8-4916-8db0-261361dd2eef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05d87726-71ee-4e38-a077-bae15b3845fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f84a4d0-378d-4112-a52f-f292f7617573");

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Adoptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "State",
                table: "Adoptions");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60fef3ef-cad6-46cc-aab9-0a2835399573", null, "Admin", "ADMIN" },
                    { "90bdd9a0-8cf8-4916-8db0-261361dd2eef", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "05d87726-71ee-4e38-a077-bae15b3845fc", 0, null, null, null, "181f2de8-48b5-47bf-8f61-4b41889f6261", null, new DateTime(2023, 6, 7, 14, 34, 5, 214, DateTimeKind.Local).AddTicks(3451), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGDvwU92XKIAKpkERmsxA+pq0El2oDwjG+tpn7bSxDiJNxAQYu6/zi6YEnh5hb65xA==", null, false, null, "84e76262-2287-494a-b1e9-0627863ec4e8", "Masculino", null, false, "admin@admin.com", null },
                    { "5f84a4d0-378d-4112-a52f-f292f7617573", 0, null, null, null, "b08b3495-ef47-436a-a50d-3b20290165b2", null, new DateTime(2023, 6, 7, 14, 34, 5, 152, DateTimeKind.Local).AddTicks(2660), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEL5qXP7wnrgZ1aFcTOWNvwVYFosGUhcJ6T9QW5COMTc6AUHa5W2D+tfJUouVaKiwuA==", null, false, null, "7c629c33-e5e9-44e2-a190-8644a4092e62", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "b4aad935-6702-4f40-a939-e11c943e0d76", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "5f84a4d0-378d-4112-a52f-f292f7617573" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "60fef3ef-cad6-46cc-aab9-0a2835399573", "05d87726-71ee-4e38-a077-bae15b3845fc" },
                    { "90bdd9a0-8cf8-4916-8db0-261361dd2eef", "5f84a4d0-378d-4112-a52f-f292f7617573" }
                });
        }
    }
}
