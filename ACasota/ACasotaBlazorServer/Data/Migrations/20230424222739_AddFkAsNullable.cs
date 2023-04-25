using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFkAsNullable : Migration
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
                keyValue: "5b2f58ae-dedd-4f00-a213-ae19a370b335");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e263b78-66af-431c-a3ca-4d625449ab51", "1a938c1c-2cf4-42f9-9bb9-ce993a459c4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a050405-f44c-4505-b54e-7c82ccd475b0", "5ca85dc3-a397-421a-b8dc-c2429a009d10" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e263b78-66af-431c-a3ca-4d625449ab51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a050405-f44c-4505-b54e-7c82ccd475b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a938c1c-2cf4-42f9-9bb9-ce993a459c4e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ca85dc3-a397-421a-b8dc-c2429a009d10");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Animals",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69121d8b-b62b-4cbd-96f0-5525189e6ce3", null, "User", "USER" },
                    { "fef28626-f615-4dba-a76e-31a5050bfaac", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "5627ff42-3440-47e0-a90c-db26a5b69f02", 0, null, null, null, "e6a71ffb-a24d-4fe9-9c25-140ed1e9c153", null, new DateTime(2023, 4, 24, 23, 27, 39, 202, DateTimeKind.Local).AddTicks(3545), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAECFm6l/BWTw8IlpuAHy8re7z577jKN+IwGZxiTAHi7Njjx0IITZ2M2ttvVTlYKyWSw==", null, false, null, "c31ecef2-5cf0-4108-a0a0-6e2111ff7435", null, false, "admin@admin.com", null },
                    { "b28b8f3a-590b-41ed-90f0-13e28b337d79", 0, null, null, null, "9bbeb49f-ee0e-41ad-a422-114adaf7d7db", null, new DateTime(2023, 4, 24, 23, 27, 39, 64, DateTimeKind.Local).AddTicks(8280), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEETJZeQuyd9P9LYgmCBPL2eaeXlkNBYQKrDII2+En+iti+2mpfXB6o+lYXmpntL4jg==", null, false, null, "58397808-2cff-4d12-b1c0-fd3301f876b1", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "Colour", "CoverPicture", "Name", "Race", "UserId" },
                values: new object[] { "e4293092-7cd0-450a-934c-85a791f5a3ba", "2 Months", null, "Ginger", null, "Lucas", "Cat", "b28b8f3a-590b-41ed-90f0-13e28b337d79" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fef28626-f615-4dba-a76e-31a5050bfaac", "5627ff42-3440-47e0-a90c-db26a5b69f02" },
                    { "69121d8b-b62b-4cbd-96f0-5525189e6ce3", "b28b8f3a-590b-41ed-90f0-13e28b337d79" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
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
                keyValue: "e4293092-7cd0-450a-934c-85a791f5a3ba");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fef28626-f615-4dba-a76e-31a5050bfaac", "5627ff42-3440-47e0-a90c-db26a5b69f02" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69121d8b-b62b-4cbd-96f0-5525189e6ce3", "b28b8f3a-590b-41ed-90f0-13e28b337d79" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69121d8b-b62b-4cbd-96f0-5525189e6ce3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fef28626-f615-4dba-a76e-31a5050bfaac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5627ff42-3440-47e0-a90c-db26a5b69f02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b28b8f3a-590b-41ed-90f0-13e28b337d79");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Animals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5e263b78-66af-431c-a3ca-4d625449ab51", null, "Admin", "ADMIN" },
                    { "8a050405-f44c-4505-b54e-7c82ccd475b0", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "1a938c1c-2cf4-42f9-9bb9-ce993a459c4e", 0, null, null, null, "f8f49da6-3180-4eff-b75f-37515efae53f", null, new DateTime(2023, 4, 23, 17, 34, 36, 238, DateTimeKind.Local).AddTicks(8864), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJPfb+ouB2kDCR5/PtpWr/cCy4RfQhwLn45Q5H4Kgi1jcRp1adbq7Ml9mxZf/Td2fg==", null, false, null, "8265e01a-5712-41c2-a353-d874d2b3e3ff", null, false, "admin@admin.com", null },
                    { "5ca85dc3-a397-421a-b8dc-c2429a009d10", 0, null, null, null, "a4aaf3c3-59b6-447a-8cba-a357f59b148b", null, new DateTime(2023, 4, 23, 17, 34, 36, 149, DateTimeKind.Local).AddTicks(5815), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAELRP4GI0YqKlZ1guetvW4V0MjbWcoDSM2uBy4hrvzJh38lnDhivVXE3kj+BDIVKSfA==", null, false, null, "a949f684-3c26-48e3-848b-bf3eea5e6c0d", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "Colour", "CoverPicture", "Name", "Race", "UserId" },
                values: new object[] { "5b2f58ae-dedd-4f00-a213-ae19a370b335", "2 Months", null, "Ginger", null, "Lucas", "Cat", "5ca85dc3-a397-421a-b8dc-c2429a009d10" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5e263b78-66af-431c-a3ca-4d625449ab51", "1a938c1c-2cf4-42f9-9bb9-ce993a459c4e" },
                    { "8a050405-f44c-4505-b54e-7c82ccd475b0", "5ca85dc3-a397-421a-b8dc-c2429a009d10" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
