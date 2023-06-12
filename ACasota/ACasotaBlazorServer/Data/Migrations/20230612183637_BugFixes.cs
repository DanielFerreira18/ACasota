using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class BugFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_UserId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserId",
                table: "Events");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "845d2a5c-b5fd-4e48-9a7d-3b3ccb54aa4f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5895f482-8ed1-4f32-aad8-f12689cebd27", "1237ed08-6a44-4e20-8cf8-09ec5b3238cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2c49958-a598-4f84-9017-13025be9df0e", "29999d65-e585-47ff-b57d-69647ee65b54" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5895f482-8ed1-4f32-aad8-f12689cebd27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2c49958-a598-4f84-9017-13025be9df0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1237ed08-6a44-4e20-8cf8-09ec5b3238cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29999d65-e585-47ff-b57d-69647ee65b54");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Events");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01c9f29c-8117-4ea0-b25a-b98f6fdeb50b", null, "Admin", "ADMIN" },
                    { "5f5cefe1-5ec6-44e1-a594-c9026df21ed7", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "dd0ec52e-507e-4870-8bb8-a829d6420580", 0, null, null, null, "6647a337-4f52-4b37-8860-7ff24cc7257f", null, new DateTime(2023, 6, 12, 19, 36, 36, 822, DateTimeKind.Local).AddTicks(475), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEOes42SxFNjnfkgMmA/cQedQDKTgTG+vZMEK/Ra0ICVNtnYUgPNXZouBC82cA2oXWg==", null, false, null, "4746b574-24aa-43c4-bb79-44b46361ee85", "Masculino", null, false, "admin@admin.com", null },
                    { "f173ed6d-3156-4127-bb5f-07b1b48f0dca", 0, null, null, null, "ff4e7c5b-5312-4706-95f3-fe2c99fac0a9", null, new DateTime(2023, 6, 12, 19, 36, 36, 762, DateTimeKind.Local).AddTicks(1993), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEAKClEwAxteNLLezblHWICiKrQg63IwYh+YGzc/x0tpEE1nG4BjIQUevKwuqrYzp+A==", null, false, null, "dcd44332-febc-4b18-96c6-921af370a72a", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "1588c3b0-6217-48f1-942c-3d0d0235fd3f", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "f173ed6d-3156-4127-bb5f-07b1b48f0dca" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "01c9f29c-8117-4ea0-b25a-b98f6fdeb50b", "dd0ec52e-507e-4870-8bb8-a829d6420580" },
                    { "5f5cefe1-5ec6-44e1-a594-c9026df21ed7", "f173ed6d-3156-4127-bb5f-07b1b48f0dca" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "1588c3b0-6217-48f1-942c-3d0d0235fd3f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "01c9f29c-8117-4ea0-b25a-b98f6fdeb50b", "dd0ec52e-507e-4870-8bb8-a829d6420580" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5f5cefe1-5ec6-44e1-a594-c9026df21ed7", "f173ed6d-3156-4127-bb5f-07b1b48f0dca" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01c9f29c-8117-4ea0-b25a-b98f6fdeb50b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f5cefe1-5ec6-44e1-a594-c9026df21ed7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd0ec52e-507e-4870-8bb8-a829d6420580");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f173ed6d-3156-4127-bb5f-07b1b48f0dca");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Events",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5895f482-8ed1-4f32-aad8-f12689cebd27", null, "Admin", "ADMIN" },
                    { "f2c49958-a598-4f84-9017-13025be9df0e", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "1237ed08-6a44-4e20-8cf8-09ec5b3238cf", 0, null, null, null, "44d37776-1474-490a-82cc-45490ce189c0", null, new DateTime(2023, 6, 12, 18, 6, 23, 159, DateTimeKind.Local).AddTicks(8560), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJ9I3D0MRUEUhk9ajKsNYjlI2glYb/M2Nn63IEvEufFpNv568xkgDbI6j5BhX99W2g==", null, false, null, "741eb14d-7d1c-4bc8-9206-e8593f80a96f", "Masculino", null, false, "admin@admin.com", null },
                    { "29999d65-e585-47ff-b57d-69647ee65b54", 0, null, null, null, "a6dd3f74-1009-45f6-8c94-47491fc48d94", null, new DateTime(2023, 6, 12, 18, 6, 23, 100, DateTimeKind.Local).AddTicks(7037), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEBJTIn8N2pCwf6Ts9CoVtrNmgS8lxCria78IfsHBZnQwVTgwJL9VkiCzjPIieO1NJg==", null, false, null, "2e6582cd-db3b-4bea-b69f-5acf0fe4d2db", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "845d2a5c-b5fd-4e48-9a7d-3b3ccb54aa4f", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "29999d65-e585-47ff-b57d-69647ee65b54" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5895f482-8ed1-4f32-aad8-f12689cebd27", "1237ed08-6a44-4e20-8cf8-09ec5b3238cf" },
                    { "f2c49958-a598-4f84-9017-13025be9df0e", "29999d65-e585-47ff-b57d-69647ee65b54" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_UserId",
                table: "Events",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
