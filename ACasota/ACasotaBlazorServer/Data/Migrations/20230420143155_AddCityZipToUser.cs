using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCityZipToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "518995f0-4104-48b5-96d4-499b5be72ad7", null, "User", "USER" },
                    { "b2f98b06-390e-4f7e-b885-71d4a4ee0529", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "07549a9c-20b6-44a4-8816-9c2e268fd0d6", 0, null, null, null, "f4ff91ed-3ed1-4d0f-b2cd-9c65cc412196", null, new DateTime(2023, 4, 20, 15, 31, 54, 843, DateTimeKind.Local).AddTicks(4421), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEFtDRe/XHi4NaOHCl6kwsvKhgBlSkEvgdU7GnQMYfyM5VkVgMVrrKj0uMC7MpVpndA==", null, false, null, "d0246307-4f88-47ea-8715-194dd868a184", false, "user@user.com", null },
                    { "769eef3f-11b4-4d7b-96a5-c88630fc5f37", 0, null, null, null, "07e4287c-6513-4153-9c62-09bcb468d91a", null, new DateTime(2023, 4, 20, 15, 31, 54, 908, DateTimeKind.Local).AddTicks(42), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAECsq3hp5w+MSWzQsRv3+dnRwXRuAOHxSHQJcU+yyc5w2TAfQy8nL+LUnByx9m9mStg==", null, false, null, "2e8100fc-4dd3-45d2-af3f-18621cbe4e92", false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Colour", "Name", "Race", "UserId" },
                values: new object[] { "c7bf80b1-0b48-490a-a7dc-dcf180484668", "2 Months", "Ginger", "Lucas", "Cat", "07549a9c-20b6-44a4-8816-9c2e268fd0d6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "518995f0-4104-48b5-96d4-499b5be72ad7", "07549a9c-20b6-44a4-8816-9c2e268fd0d6" },
                    { "b2f98b06-390e-4f7e-b885-71d4a4ee0529", "769eef3f-11b4-4d7b-96a5-c88630fc5f37" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "c7bf80b1-0b48-490a-a7dc-dcf180484668");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "518995f0-4104-48b5-96d4-499b5be72ad7", "07549a9c-20b6-44a4-8816-9c2e268fd0d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2f98b06-390e-4f7e-b885-71d4a4ee0529", "769eef3f-11b4-4d7b-96a5-c88630fc5f37" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "518995f0-4104-48b5-96d4-499b5be72ad7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2f98b06-390e-4f7e-b885-71d4a4ee0529");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07549a9c-20b6-44a4-8816-9c2e268fd0d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "769eef3f-11b4-4d7b-96a5-c88630fc5f37");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "AspNetUsers");

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
    }
}
