using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableAnimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "Colour",
                table: "Animals",
                newName: "Sex");

            migrationBuilder.AddColumn<bool>(
                name: "IsSterile",
                table: "Animals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVacinated",
                table: "Animals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e43672f0-b4f9-4af2-b967-63cf581773c1", null, "Admin", "ADMIN" },
                    { "e80c8f0e-12d9-4cee-a1c1-8ee7b5923ee6", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "5789605f-4ce6-43b5-83d1-43efdc13c812", 0, null, null, null, "d602e999-eb27-455a-b2b6-17d9bd7c316a", null, new DateTime(2023, 6, 7, 0, 15, 20, 693, DateTimeKind.Local).AddTicks(9775), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEA+NP451YD93ESmidTbWEiW81NlsU8r00Qt3gUZDAlquQSC3rW9T/dHMSlzi9hURPA==", null, false, null, "4d4f27e9-df1b-499e-9b11-2de3ba0bd027", null, false, "user@user.com", null },
                    { "9af3215a-2cf0-4c78-ad15-7ad51065e80e", 0, null, null, null, "c0613fbe-163e-44c6-b1b1-39bf0b17fdc3", null, new DateTime(2023, 6, 7, 0, 15, 20, 754, DateTimeKind.Local).AddTicks(5743), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEM+IU+i9ZGAKXiggJ56bSm5APR0RwiJIAsU1mi+vrRAmSSaazn+t81K1gxO999YzTQ==", null, false, null, "44ac3665-730f-4cd0-aad1-f13c2f36afa1", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "f5f9481d-c33a-4005-8658-43e423713d2b", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "5789605f-4ce6-43b5-83d1-43efdc13c812" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e80c8f0e-12d9-4cee-a1c1-8ee7b5923ee6", "5789605f-4ce6-43b5-83d1-43efdc13c812" },
                    { "e43672f0-b4f9-4af2-b967-63cf581773c1", "9af3215a-2cf0-4c78-ad15-7ad51065e80e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "f5f9481d-c33a-4005-8658-43e423713d2b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e80c8f0e-12d9-4cee-a1c1-8ee7b5923ee6", "5789605f-4ce6-43b5-83d1-43efdc13c812" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e43672f0-b4f9-4af2-b967-63cf581773c1", "9af3215a-2cf0-4c78-ad15-7ad51065e80e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e43672f0-b4f9-4af2-b967-63cf581773c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e80c8f0e-12d9-4cee-a1c1-8ee7b5923ee6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5789605f-4ce6-43b5-83d1-43efdc13c812");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9af3215a-2cf0-4c78-ad15-7ad51065e80e");

            migrationBuilder.DropColumn(
                name: "IsSterile",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "IsVacinated",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "Sex",
                table: "Animals",
                newName: "Colour");

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
        }
    }
}
