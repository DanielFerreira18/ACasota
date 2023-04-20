using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserProfilePics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "041d2ff5-c1fc-4414-9732-2dae308de11b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "150e4fbd-9266-43c6-ab39-547d75c1af8e", "6714c7d5-8175-4c92-bf93-3cd6382a361f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "360a0369-8123-449c-bbd8-c7f644f52f9f", "d3bf8588-da58-45c7-b69f-106ec9a72a2f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "150e4fbd-9266-43c6-ab39-547d75c1af8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "360a0369-8123-449c-bbd8-c7f644f52f9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6714c7d5-8175-4c92-bf93-3cd6382a361f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3bf8588-da58-45c7-b69f-106ec9a72a2f");

            migrationBuilder.AddColumn<string>(
                name: "CoverPic",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePic",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "35ed8eaa-54e4-42ef-b373-2e1c61cc1b8e", null, "Admin", "ADMIN" },
                    { "427e409b-a7b6-478c-8e05-ab8019464187", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b5e2c5c8-9167-4931-b404-ac1943e74d7a", 0, null, null, "0a9e2128-cd0e-4257-af9f-faf42c001e33", null, new DateTime(2023, 4, 19, 23, 47, 6, 174, DateTimeKind.Local).AddTicks(7115), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEBNv94J+0KiE4qiXfTYA1kRiQjwnmOdRfbQJ1aWofop3lDI8HSNdzRaqM8x3znAFxw==", null, false, null, "3899a9ba-e9ed-49a6-a6b4-ff4f5fcfc4d6", false, "admin@admin.com" },
                    { "d8684e41-bb6c-4946-a409-3c911ac8b942", 0, null, null, "65388393-3515-4b0f-9deb-bc1eed695942", null, new DateTime(2023, 4, 19, 23, 47, 6, 114, DateTimeKind.Local).AddTicks(9048), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEIFz1ErZLnklwr0vmL7wdtRjqk0HffyOweAUE3aS2EwCt6wkk4g+Sg04RJPkvZv/mg==", null, false, null, "e615c14e-c7e4-4ef5-90d8-fd4939fccab5", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Colour", "Name", "Race", "UserId" },
                values: new object[] { "6ceca81b-09be-4870-980b-c94f6c708a20", "2 Months", "Ginger", "Lucas", "Cat", "d8684e41-bb6c-4946-a409-3c911ac8b942" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "35ed8eaa-54e4-42ef-b373-2e1c61cc1b8e", "b5e2c5c8-9167-4931-b404-ac1943e74d7a" },
                    { "427e409b-a7b6-478c-8e05-ab8019464187", "d8684e41-bb6c-4946-a409-3c911ac8b942" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "6ceca81b-09be-4870-980b-c94f6c708a20");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "35ed8eaa-54e4-42ef-b373-2e1c61cc1b8e", "b5e2c5c8-9167-4931-b404-ac1943e74d7a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "427e409b-a7b6-478c-8e05-ab8019464187", "d8684e41-bb6c-4946-a409-3c911ac8b942" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35ed8eaa-54e4-42ef-b373-2e1c61cc1b8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "427e409b-a7b6-478c-8e05-ab8019464187");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5e2c5c8-9167-4931-b404-ac1943e74d7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8684e41-bb6c-4946-a409-3c911ac8b942");

            migrationBuilder.DropColumn(
                name: "CoverPic",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "150e4fbd-9266-43c6-ab39-547d75c1af8e", null, "User", "USER" },
                    { "360a0369-8123-449c-bbd8-c7f644f52f9f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "ConcurrencyStamp", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6714c7d5-8175-4c92-bf93-3cd6382a361f", 0, null, null, "366fb889-5288-4ffe-885e-30a7cafd1e52", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEJlfpGEtIHqeMx0JNNngRgZrWQd06ILqOIq1IlPX0ty2aPhzK3d+qcEuuWRezTxBUQ==", null, false, "9f5dea03-362e-4aeb-8103-821f0694bb44", false, "user@user.com" },
                    { "d3bf8588-da58-45c7-b69f-106ec9a72a2f", 0, null, null, "b8a1ffe6-5df8-4581-8fe4-90e39b954db3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENqidqvBmDFhn6Z+lpvSDmg/vozzUEgzPIQy+rm+ZRrG61dScQSEgLinfWGUWpR9Mg==", null, false, "c2c63498-a85d-4842-80ba-4dd10f20666d", false, "admin@admin.com" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Colour", "Name", "Race", "UserId" },
                values: new object[] { "041d2ff5-c1fc-4414-9732-2dae308de11b", "2 Months", "Ginger", "Lucas", "Cat", "6714c7d5-8175-4c92-bf93-3cd6382a361f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "150e4fbd-9266-43c6-ab39-547d75c1af8e", "6714c7d5-8175-4c92-bf93-3cd6382a361f" },
                    { "360a0369-8123-449c-bbd8-c7f644f52f9f", "d3bf8588-da58-45c7-b69f-106ec9a72a2f" }
                });
        }
    }
}
