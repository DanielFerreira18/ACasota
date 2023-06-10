using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableEvent_Alter_State : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "c28bb1b0-6291-4e46-ae95-3991f28fe798");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1fc5ce5-dba6-43a1-93bb-b464a734dc09", "75cbdf54-1a2f-47dc-97ad-350f831c7d90" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb9e14ca-378c-4863-a830-31be6d55055c", "e8a4d87e-11d6-41c7-b977-9d94e84a2680" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1fc5ce5-dba6-43a1-93bb-b464a734dc09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb9e14ca-378c-4863-a830-31be6d55055c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75cbdf54-1a2f-47dc-97ad-350f831c7d90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8a4d87e-11d6-41c7-b977-9d94e84a2680");

            migrationBuilder.AlterColumn<bool>(
                name: "State",
                table: "Events",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "State",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b1fc5ce5-dba6-43a1-93bb-b464a734dc09", null, "User", "USER" },
                    { "fb9e14ca-378c-4863-a830-31be6d55055c", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "75cbdf54-1a2f-47dc-97ad-350f831c7d90", 0, null, null, null, "601a3e2b-56e6-4052-b6ad-4e57a53578ac", null, new DateTime(2023, 6, 9, 14, 45, 14, 346, DateTimeKind.Local).AddTicks(2318), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEMfT4TzAcPG7MxPApScTKOsiGA3KWkmBIZox8gU8T7bq86LtvUQXnFcxL5/WmM3dUw==", null, false, null, "e1fa8b1f-cebd-4083-92d5-4b5fd47e5bad", "Masculino", null, false, "user@user.com", null },
                    { "e8a4d87e-11d6-41c7-b977-9d94e84a2680", 0, null, null, null, "07f480fc-36d5-4495-9aac-c5967a31f4c4", null, new DateTime(2023, 6, 9, 14, 45, 14, 407, DateTimeKind.Local).AddTicks(2394), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEBccoeW7BKQQtlTOrLb1VWj1cgOgngNw+ZW3F/9KnlbwfaoUk9osIel1vKyvxw1+9w==", null, false, null, "99330493-1c44-470b-8902-29cfefd46a4c", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "c28bb1b0-6291-4e46-ae95-3991f28fe798", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "75cbdf54-1a2f-47dc-97ad-350f831c7d90" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b1fc5ce5-dba6-43a1-93bb-b464a734dc09", "75cbdf54-1a2f-47dc-97ad-350f831c7d90" },
                    { "fb9e14ca-378c-4863-a830-31be6d55055c", "e8a4d87e-11d6-41c7-b977-9d94e84a2680" }
                });
        }
    }
}
