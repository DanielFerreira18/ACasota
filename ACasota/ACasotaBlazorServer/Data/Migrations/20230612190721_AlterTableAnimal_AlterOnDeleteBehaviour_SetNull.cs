using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableAnimal_AlterOnDeleteBehaviour_SetNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "28b42a5b-bf80-41dd-9d45-c0325fea2bc3", null, "User", "USER" },
                    { "ce9519fe-e5bd-4c51-a972-b30958fde7b9", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "222a852c-5481-46c7-8044-523c66bff3c1", 0, null, null, null, "3db24790-9455-42a8-9cd3-cfa396b2d66b", null, new DateTime(2023, 6, 12, 20, 7, 21, 5, DateTimeKind.Local).AddTicks(2035), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEEqxFam5pHUaMaNwSIkDah00erwMmoT11GyazrXQEQ9N0+R1iIkq4XcygBlH07e8Mg==", null, false, null, "7735431a-1c4c-40b9-88c3-4c72924cb756", "Masculino", null, false, "user@user.com", null },
                    { "3876115c-24c7-4786-83fc-28a9a6fcd21b", 0, null, null, null, "137f409f-831b-4aa1-a8b9-d0adbc32f484", null, new DateTime(2023, 6, 12, 20, 7, 21, 64, DateTimeKind.Local).AddTicks(973), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJl9/ZWlNOBzGATLs39BlSVrkFseKjQZgMQUvvpS5lOeQc4iqaLThAGleP/b+/TXLw==", null, false, null, "d31cb3fe-6176-4cfb-ab01-6f483957a75a", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "f2f5cffb-15e4-4854-94ca-27c61454d450", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "222a852c-5481-46c7-8044-523c66bff3c1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "28b42a5b-bf80-41dd-9d45-c0325fea2bc3", "222a852c-5481-46c7-8044-523c66bff3c1" },
                    { "ce9519fe-e5bd-4c51-a972-b30958fde7b9", "3876115c-24c7-4786-83fc-28a9a6fcd21b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "f2f5cffb-15e4-4854-94ca-27c61454d450");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28b42a5b-bf80-41dd-9d45-c0325fea2bc3", "222a852c-5481-46c7-8044-523c66bff3c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce9519fe-e5bd-4c51-a972-b30958fde7b9", "3876115c-24c7-4786-83fc-28a9a6fcd21b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28b42a5b-bf80-41dd-9d45-c0325fea2bc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce9519fe-e5bd-4c51-a972-b30958fde7b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "222a852c-5481-46c7-8044-523c66bff3c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3876115c-24c7-4786-83fc-28a9a6fcd21b");

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
        }
    }
}
