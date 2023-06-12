using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableAnimal_AlterSizeNotNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "73806e48-4a16-423a-b97f-9c116045c21f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "047a6e1d-4aef-45b9-b363-283d30384aba", "bf7e1ff2-f538-4384-a9a9-9ed8738ab28e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e05d37f8-ba69-4def-847c-c2a5d6a0a751", "c0d1c3f6-669f-49a0-8002-3971bd21aa8c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "047a6e1d-4aef-45b9-b363-283d30384aba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e05d37f8-ba69-4def-847c-c2a5d6a0a751");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf7e1ff2-f538-4384-a9a9-9ed8738ab28e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0d1c3f6-669f-49a0-8002-3971bd21aa8c");

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "139f9613-34d7-4587-a3bd-eb6776c5c1fa", null, "Admin", "ADMIN" },
                    { "a611995a-f756-4d58-bde3-01fd6135b168", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "426a6ee1-efdd-467c-9675-3f2b723d66aa", 0, null, null, null, "01203614-fea1-4abc-b63e-a36bc0236422", null, new DateTime(2023, 6, 12, 14, 52, 53, 587, DateTimeKind.Local).AddTicks(8897), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEBt6H0FVjMsKCn9VySBV1vDX0ScqqbcMmeAgJOQHa3axzNmt1gLda/Rf8OY6j+a5Iw==", null, false, null, "4dbb4b2f-0193-4f1c-9dc8-a264e1cbe7f9", "Masculino", null, false, "user@user.com", null },
                    { "58bbf575-7f90-4986-bbed-1853098a5495", 0, null, null, null, "7383820b-a978-4c8c-8da5-cf1f88913f19", null, new DateTime(2023, 6, 12, 14, 52, 53, 647, DateTimeKind.Local).AddTicks(4732), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEKDpGGudkxMPgMZ3mFhKhiKWLH8Xllm8la/1uS+obzjwCKQKYDEf3NSGbjqELGojHA==", null, false, null, "25acd99a-99b5-4040-9d28-4b025c4b4212", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "336e1618-44ad-4621-8118-e7f1b523067a", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "426a6ee1-efdd-467c-9675-3f2b723d66aa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a611995a-f756-4d58-bde3-01fd6135b168", "426a6ee1-efdd-467c-9675-3f2b723d66aa" },
                    { "139f9613-34d7-4587-a3bd-eb6776c5c1fa", "58bbf575-7f90-4986-bbed-1853098a5495" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "336e1618-44ad-4621-8118-e7f1b523067a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a611995a-f756-4d58-bde3-01fd6135b168", "426a6ee1-efdd-467c-9675-3f2b723d66aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "139f9613-34d7-4587-a3bd-eb6776c5c1fa", "58bbf575-7f90-4986-bbed-1853098a5495" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "139f9613-34d7-4587-a3bd-eb6776c5c1fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a611995a-f756-4d58-bde3-01fd6135b168");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "426a6ee1-efdd-467c-9675-3f2b723d66aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58bbf575-7f90-4986-bbed-1853098a5495");

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "047a6e1d-4aef-45b9-b363-283d30384aba", null, "User", "USER" },
                    { "e05d37f8-ba69-4def-847c-c2a5d6a0a751", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "bf7e1ff2-f538-4384-a9a9-9ed8738ab28e", 0, null, null, null, "a4c46c62-0c11-4448-b739-19243503c4e7", null, new DateTime(2023, 6, 11, 18, 36, 54, 329, DateTimeKind.Local).AddTicks(7093), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEB4Z4pGBafQxFYNI0QQXoOci03o2VoycKaw1rB8rkC3JroK376AN3vlS3oAbjULtAg==", null, false, null, "ed941a85-f3c9-4014-8a9b-da03a8892710", "Masculino", null, false, "user@user.com", null },
                    { "c0d1c3f6-669f-49a0-8002-3971bd21aa8c", 0, null, null, null, "652e3c56-8ed2-4f2b-bf05-b6ccf8f9907e", null, new DateTime(2023, 6, 11, 18, 36, 54, 393, DateTimeKind.Local).AddTicks(1430), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEEyZsmhk+E7cy6GcUPv6hNmG/qt4i7YkQjvFnZq+B2deOAzeRP52XAgKdwEPcxzuig==", null, false, null, "eeb2852a-aea4-4718-9dab-e1966ba6c0bf", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "73806e48-4a16-423a-b97f-9c116045c21f", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "bf7e1ff2-f538-4384-a9a9-9ed8738ab28e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "047a6e1d-4aef-45b9-b363-283d30384aba", "bf7e1ff2-f538-4384-a9a9-9ed8738ab28e" },
                    { "e05d37f8-ba69-4def-847c-c2a5d6a0a751", "c0d1c3f6-669f-49a0-8002-3971bd21aa8c" }
                });
        }
    }
}
