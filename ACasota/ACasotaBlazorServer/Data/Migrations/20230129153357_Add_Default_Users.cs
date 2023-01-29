using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ca28e4b0-3a51-420c-80a4-d4b2c24970f5", null, "User", "USER" },
                    { "d05c0bbc-8853-492f-8094-ab3e2a34a281", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "ConcurrencyStamp", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "14af6764-b0b3-46eb-bcb3-2041e445de9f", 0, null, null, "fe73bc0c-7db5-4d5a-aaef-48bf74d4e1e2", new DateTime(2023, 1, 29, 15, 33, 57, 93, DateTimeKind.Local).AddTicks(3699), "admin@admin.com", false, "Admin", "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", null, null, false, "5e6d0d45-9d19-4e20-86e5-263ffd3cec05", false, "admin@admin.com" },
                    { "a151b6e5-0097-481d-9360-c3f174a2e80e", 0, null, null, "afebebc0-b2e3-4610-967b-6d00ab8fed6d", new DateTime(2023, 1, 29, 15, 33, 57, 93, DateTimeKind.Local).AddTicks(3643), "user@user.com", false, "User", "User", false, null, null, "USER@USER.COM", "USER@USER.COM", null, null, false, "c7148291-8527-4999-a665-e256bfd3bd3e", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d05c0bbc-8853-492f-8094-ab3e2a34a281", "14af6764-b0b3-46eb-bcb3-2041e445de9f" },
                    { "ca28e4b0-3a51-420c-80a4-d4b2c24970f5", "a151b6e5-0097-481d-9360-c3f174a2e80e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d05c0bbc-8853-492f-8094-ab3e2a34a281", "14af6764-b0b3-46eb-bcb3-2041e445de9f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca28e4b0-3a51-420c-80a4-d4b2c24970f5", "a151b6e5-0097-481d-9360-c3f174a2e80e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca28e4b0-3a51-420c-80a4-d4b2c24970f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d05c0bbc-8853-492f-8094-ab3e2a34a281");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14af6764-b0b3-46eb-bcb3-2041e445de9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a151b6e5-0097-481d-9360-c3f174a2e80e");
        }
    }
}
