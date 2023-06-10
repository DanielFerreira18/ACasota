using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableEvent_Add_Count : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "ec11307a-c039-4aa8-8977-98a46a899e24");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5c6d8b2f-b6bf-4c98-8e87-a32c8d15fc91", "475c8c96-a33f-43de-8b79-343cb2afcb62" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "013f8b33-cafd-4491-97ce-59e112053acd", "bb00762f-f13f-4927-92fd-a283efd1675f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "013f8b33-cafd-4491-97ce-59e112053acd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c6d8b2f-b6bf-4c98-8e87-a32c8d15fc91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "475c8c96-a33f-43de-8b79-343cb2afcb62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb00762f-f13f-4927-92fd-a283efd1675f");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4676b461-73af-460b-8b72-2431c24ace1c", null, "Admin", "ADMIN" },
                    { "78aa7751-bcf5-45d3-9160-48b8b2974eaf", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "8ae12bdc-9ba5-41d6-b85b-571f52761960", 0, null, null, null, "d7a1abfe-227a-4416-931c-302a2617ab52", null, new DateTime(2023, 6, 9, 15, 6, 7, 317, DateTimeKind.Local).AddTicks(8078), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEEMAxz8+wc1MmQK+zWN9Qz25gLWYK+sayzhgF/8Mym47Nqp3WBr+zkzm3qngcDnZpg==", null, false, null, "3945fd86-48f5-4a7c-9a99-0220d5e3dfdf", "Masculino", null, false, "admin@admin.com", null },
                    { "e67694d2-f441-4dcb-ae70-bc664a4bc25f", 0, null, null, null, "0078a105-9371-4260-9acb-e325dca763b8", null, new DateTime(2023, 6, 9, 15, 6, 7, 256, DateTimeKind.Local).AddTicks(6483), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEDLYrQGNGm5L+jUi+QiE3dTMdlompykBNIfEAoCogunZg2mdWxNXdDSPU9ZiIhVSGg==", null, false, null, "a5905e15-8a2a-4f07-9ebf-a9dc2f80606a", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "b59abd6a-9333-4690-88cb-d72038411b1c", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "e67694d2-f441-4dcb-ae70-bc664a4bc25f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4676b461-73af-460b-8b72-2431c24ace1c", "8ae12bdc-9ba5-41d6-b85b-571f52761960" },
                    { "78aa7751-bcf5-45d3-9160-48b8b2974eaf", "e67694d2-f441-4dcb-ae70-bc664a4bc25f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "b59abd6a-9333-4690-88cb-d72038411b1c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4676b461-73af-460b-8b72-2431c24ace1c", "8ae12bdc-9ba5-41d6-b85b-571f52761960" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "78aa7751-bcf5-45d3-9160-48b8b2974eaf", "e67694d2-f441-4dcb-ae70-bc664a4bc25f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4676b461-73af-460b-8b72-2431c24ace1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78aa7751-bcf5-45d3-9160-48b8b2974eaf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ae12bdc-9ba5-41d6-b85b-571f52761960");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e67694d2-f441-4dcb-ae70-bc664a4bc25f");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Events");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "013f8b33-cafd-4491-97ce-59e112053acd", null, "Admin", "ADMIN" },
                    { "5c6d8b2f-b6bf-4c98-8e87-a32c8d15fc91", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "475c8c96-a33f-43de-8b79-343cb2afcb62", 0, null, null, null, "93537591-211a-4537-ab95-5108830ab69a", null, new DateTime(2023, 6, 9, 14, 53, 13, 715, DateTimeKind.Local).AddTicks(267), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEPQWH5YdyeDAYTM+k64HVdE/VLPPzdjFPqPqZRzHkQ/s0tBAeWaZjEHn+7zZPuMVvQ==", null, false, null, "85ccbce2-0ecc-446a-b816-83d77f5f51b1", "Masculino", null, false, "user@user.com", null },
                    { "bb00762f-f13f-4927-92fd-a283efd1675f", 0, null, null, null, "e4bea315-1f7f-4a7e-a8fa-0e073cf3f739", null, new DateTime(2023, 6, 9, 14, 53, 13, 776, DateTimeKind.Local).AddTicks(578), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJZRDqqAtEqKIzPuk6GErbaD4jN40O0pE93rfnOh/TeiNsj4Kq43WNrXywo+t3uVmA==", null, false, null, "0c9d41a2-2a99-4559-b448-13347200ebf1", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "ec11307a-c039-4aa8-8977-98a46a899e24", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "475c8c96-a33f-43de-8b79-343cb2afcb62" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5c6d8b2f-b6bf-4c98-8e87-a32c8d15fc91", "475c8c96-a33f-43de-8b79-343cb2afcb62" },
                    { "013f8b33-cafd-4491-97ce-59e112053acd", "bb00762f-f13f-4927-92fd-a283efd1675f" }
                });
        }
    }
}
