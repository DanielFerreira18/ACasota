using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6be72fc4-ce24-4b25-af39-6f628a11855a", "18dd22b8-0e15-4838-83ab-1010c5fd8f36" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2060e17d-77d5-4ac0-b22a-62be26cb38df", "347afc61-53e5-4517-8911-8d31b9ca800c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2060e17d-77d5-4ac0-b22a-62be26cb38df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6be72fc4-ce24-4b25-af39-6f628a11855a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18dd22b8-0e15-4838-83ab-1010c5fd8f36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "347afc61-53e5-4517-8911-8d31b9ca800c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50f313f4-b6c4-4c73-ba85-3b3d525fba49", null, "Admin", "ADMIN" },
                    { "f165e8e4-70ea-400c-a342-b18a8035c950", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "ConcurrencyStamp", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9efdf132-a705-4d3a-94f4-eb965af95d12", 0, null, null, "242719c2-674e-449c-adb8-0c1284c2fc3f", new DateTime(2023, 2, 4, 16, 12, 52, 213, DateTimeKind.Local).AddTicks(5543), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAENUJR0sb8WOA0Gl3hHpiBvuhVozfqAyYJr6jHhQstTFJumaqsYOSfdcC4ocIMYirZg==", null, false, "0724d7d1-8fef-4020-9a2c-5b88bc594410", false, "user@user.com" },
                    { "ebbe3251-5b7a-4a7d-a2a7-2904e86f1f8b", 0, null, null, "88566a85-138b-4f44-8bee-8f77e5ae2721", new DateTime(2023, 2, 4, 16, 12, 52, 275, DateTimeKind.Local).AddTicks(1794), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAECAVeXGwEw+aJ7ToD/5uA72isQd5+AEbexyJeohz/bDc/vmNki7zUF6e9gYX/5XSjw==", null, false, "d07cccd7-49bc-4007-a351-e9cb7a2fa415", false, "admin@admin.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f165e8e4-70ea-400c-a342-b18a8035c950", "9efdf132-a705-4d3a-94f4-eb965af95d12" },
                    { "50f313f4-b6c4-4c73-ba85-3b3d525fba49", "ebbe3251-5b7a-4a7d-a2a7-2904e86f1f8b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f165e8e4-70ea-400c-a342-b18a8035c950", "9efdf132-a705-4d3a-94f4-eb965af95d12" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50f313f4-b6c4-4c73-ba85-3b3d525fba49", "ebbe3251-5b7a-4a7d-a2a7-2904e86f1f8b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50f313f4-b6c4-4c73-ba85-3b3d525fba49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f165e8e4-70ea-400c-a342-b18a8035c950");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9efdf132-a705-4d3a-94f4-eb965af95d12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebbe3251-5b7a-4a7d-a2a7-2904e86f1f8b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2060e17d-77d5-4ac0-b22a-62be26cb38df", null, "Admin", "ADMIN" },
                    { "6be72fc4-ce24-4b25-af39-6f628a11855a", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "ConcurrencyStamp", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "18dd22b8-0e15-4838-83ab-1010c5fd8f36", 0, null, null, "91685b19-ee1e-44b0-b87e-81034281edc4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@user.com", false, "User", false, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEJ06BOYor+l/NmpNd17a/NEAK6/wCMyOpZymorF9piiuH7QpVc83dbebjkZW7LqSOA==", null, false, "ad0da82d-3d1c-4377-83a1-c688a57f1f99", false, "user@user.com" },
                    { "347afc61-53e5-4517-8911-8d31b9ca800c", 0, null, null, "60870412-1786-45f2-896c-50dea466770e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", false, "Admin", false, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEEtz2CI37pIovxHq6sE3eajn7i8D/w1w5HvI3+V6X07o63qVtBG/8iem1BWvuEw5HQ==", null, false, "abbd83d7-4893-450a-a84e-259018bdd0e5", false, "admin@admin.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6be72fc4-ce24-4b25-af39-6f628a11855a", "18dd22b8-0e15-4838-83ab-1010c5fd8f36" },
                    { "2060e17d-77d5-4ac0-b22a-62be26cb38df", "347afc61-53e5-4517-8911-8d31b9ca800c" }
                });
        }
    }
}
