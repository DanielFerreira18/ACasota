using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableEvent_DeleteFKUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "112efed4-b3e6-433e-8757-2617da09ae79", null, "Admin", "ADMIN" },
                    { "9dc56f2c-a6b3-424e-9157-ee4e0c1e54c5", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "4da56699-ab14-495b-8265-b2eb6b3332f5", 0, null, null, null, "7de92d2f-2899-4284-8bad-bca51891d688", null, new DateTime(2023, 6, 12, 20, 2, 34, 897, DateTimeKind.Local).AddTicks(5990), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEI8mluiPhe+CLvPCbuHh5zZE+TGQB9rFj8MvxZ6sP8EgetgZQ46Ekt4bz984TTcbyQ==", null, false, null, "4313ac1d-b6c5-4604-9334-671d9c6b8dd7", "Masculino", null, false, "admin@admin.com", null },
                    { "894b87ab-58dd-43d9-ba6c-17e0908d620b", 0, null, null, null, "fa0d2871-6838-447d-941e-68ba8d03b91d", null, new DateTime(2023, 6, 12, 20, 2, 34, 836, DateTimeKind.Local).AddTicks(6728), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEMEo8d4EoCjdEMNPyQ7hS0ggFsIv/45WQMhSA0QAvZyEVL0W+KP73lwu6lULQc1BUg==", null, false, null, "7d2936f4-55a7-47e9-b388-e214a6c003fa", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "55945f8d-189a-4844-afbc-133055922023", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "894b87ab-58dd-43d9-ba6c-17e0908d620b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "112efed4-b3e6-433e-8757-2617da09ae79", "4da56699-ab14-495b-8265-b2eb6b3332f5" },
                    { "9dc56f2c-a6b3-424e-9157-ee4e0c1e54c5", "894b87ab-58dd-43d9-ba6c-17e0908d620b" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "55945f8d-189a-4844-afbc-133055922023");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "112efed4-b3e6-433e-8757-2617da09ae79", "4da56699-ab14-495b-8265-b2eb6b3332f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9dc56f2c-a6b3-424e-9157-ee4e0c1e54c5", "894b87ab-58dd-43d9-ba6c-17e0908d620b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "112efed4-b3e6-433e-8757-2617da09ae79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dc56f2c-a6b3-424e-9157-ee4e0c1e54c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4da56699-ab14-495b-8265-b2eb6b3332f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "894b87ab-58dd-43d9-ba6c-17e0908d620b");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
