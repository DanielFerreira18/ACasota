using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsEnabled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "26184014-1041-4656-8597-6e3bdad47cae", "7196ed76-940c-44ea-80ce-a3087fad972a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef1d65a7-18f5-40de-927d-9cefb6102716", "f7459fdb-7187-4c1a-a8b3-9cce8f6b0dae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26184014-1041-4656-8597-6e3bdad47cae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef1d65a7-18f5-40de-927d-9cefb6102716");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7196ed76-940c-44ea-80ce-a3087fad972a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7459fdb-7187-4c1a-a8b3-9cce8f6b0dae");

            migrationBuilder.AlterColumn<string>(
                name: "Nif",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                    { "18dd22b8-0e15-4838-83ab-1010c5fd8f36", 0, null, null, "91685b19-ee1e-44b0-b87e-81034281edc4", new DateTime(2023, 2, 4, 16, 10, 1, 979, DateTimeKind.Local).AddTicks(9020), "user@user.com", false, "User", false, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEJ06BOYor+l/NmpNd17a/NEAK6/wCMyOpZymorF9piiuH7QpVc83dbebjkZW7LqSOA==", null, false, "ad0da82d-3d1c-4377-83a1-c688a57f1f99", false, "user@user.com" },
                    { "347afc61-53e5-4517-8911-8d31b9ca800c", 0, null, null, "60870412-1786-45f2-896c-50dea466770e", new DateTime(2023, 2, 4, 16, 10, 2, 42, DateTimeKind.Local).AddTicks(5826), "admin@admin.com", false, "Admin", false, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEEtz2CI37pIovxHq6sE3eajn7i8D/w1w5HvI3+V6X07o63qVtBG/8iem1BWvuEw5HQ==", null, false, "abbd83d7-4893-450a-a84e-259018bdd0e5", false, "admin@admin.com" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "Nif",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26184014-1041-4656-8597-6e3bdad47cae", null, "Admin", "ADMIN" },
                    { "ef1d65a7-18f5-40de-927d-9cefb6102716", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "ConcurrencyStamp", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7196ed76-940c-44ea-80ce-a3087fad972a", 0, null, null, "f92eae19-4a8c-42c0-8c51-d1f257541ceb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", false, "Admin", "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEDjrIU037jwyQkcPoDX1ipKS8WOiFnobHtCgxPT7xmrshlnixeuuoQasdLWqGUQAtg==", null, false, "a6f13268-e23b-4f43-883c-86edd947d9e4", false, "admin@admin.com" },
                    { "f7459fdb-7187-4c1a-a8b3-9cce8f6b0dae", 0, null, null, "f621050b-cec4-4b72-9d4b-b443aad11881", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@user.com", false, "User", "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEOM11AgHeQn81MakEJLxQpkId7JPmEe6EWIae4hN3GGwzD2gZ5LujOVmqNwnPxOoeg==", null, false, "e9717760-64fa-441d-89b8-45c7fdc00a9b", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "26184014-1041-4656-8597-6e3bdad47cae", "7196ed76-940c-44ea-80ce-a3087fad972a" },
                    { "ef1d65a7-18f5-40de-927d-9cefb6102716", "f7459fdb-7187-4c1a-a8b3-9cce8f6b0dae" }
                });
        }
    }
}
