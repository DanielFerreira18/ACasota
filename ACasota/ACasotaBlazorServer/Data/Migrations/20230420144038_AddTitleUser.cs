using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTitleUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8c4aca04-1e6a-4d73-8384-dc72ad3366fe", null, "User", "USER" },
                    { "b842c043-b265-436d-9a81-5c7e347c6c92", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "3b998330-057a-4bbc-8eca-1e795f8a253c", 0, null, null, null, "4fda376b-340c-41db-b22f-57bd2c4fe4bf", null, new DateTime(2023, 4, 20, 15, 40, 38, 97, DateTimeKind.Local).AddTicks(9240), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEMmboid623as3daxK351Slj/djyxeOtOvHN4wOU4v1eel1HwOpKNRt4u7E099yx/Cg==", null, false, null, "b94e4b13-c6b0-4f8b-a61b-0906ebb7a6aa", null, false, "user@user.com", null },
                    { "cebe7b9f-b770-42f0-8be1-ba951a8c6bb0", 0, null, null, null, "1b6fac87-79f0-40af-8f60-3a9592d210a4", null, new DateTime(2023, 4, 20, 15, 40, 38, 159, DateTimeKind.Local).AddTicks(6157), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEMUancrk6Dkxzi3k5RHZteLdmSPXtE1iz4K+K8QlBZZ1DmaW2iimmbEVNbiptsrzjA==", null, false, null, "91047201-b35c-48a5-b5f6-f8c4724bb9b9", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Colour", "Name", "Race", "UserId" },
                values: new object[] { "f9cba49b-403e-4787-abde-75b174fcc420", "2 Months", "Ginger", "Lucas", "Cat", "3b998330-057a-4bbc-8eca-1e795f8a253c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8c4aca04-1e6a-4d73-8384-dc72ad3366fe", "3b998330-057a-4bbc-8eca-1e795f8a253c" },
                    { "b842c043-b265-436d-9a81-5c7e347c6c92", "cebe7b9f-b770-42f0-8be1-ba951a8c6bb0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "f9cba49b-403e-4787-abde-75b174fcc420");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8c4aca04-1e6a-4d73-8384-dc72ad3366fe", "3b998330-057a-4bbc-8eca-1e795f8a253c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b842c043-b265-436d-9a81-5c7e347c6c92", "cebe7b9f-b770-42f0-8be1-ba951a8c6bb0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c4aca04-1e6a-4d73-8384-dc72ad3366fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b842c043-b265-436d-9a81-5c7e347c6c92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b998330-057a-4bbc-8eca-1e795f8a253c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cebe7b9f-b770-42f0-8be1-ba951a8c6bb0");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AspNetUsers");

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
    }
}
