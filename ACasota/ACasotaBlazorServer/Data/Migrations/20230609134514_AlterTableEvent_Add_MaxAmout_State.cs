using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableEvent_Add_MaxAmout_State : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "8ac0db8a-8869-4ef2-a833-d633988cc119");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6a18adec-5c20-4621-a822-6ac9bcaececa", "4dfebb4b-d8cd-4ff4-8c11-061964d6cfd2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e1de5b30-6f7b-412a-a4c7-98d335030712", "6daf5ab9-548b-48ab-98cc-b8d8c9c37e8a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a18adec-5c20-4621-a822-6ac9bcaececa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1de5b30-6f7b-412a-a4c7-98d335030712");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4dfebb4b-d8cd-4ff4-8c11-061964d6cfd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6daf5ab9-548b-48ab-98cc-b8d8c9c37e8a");

            migrationBuilder.AddColumn<int>(
                name: "MaxAmount",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "MaxAmount",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Events");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a18adec-5c20-4621-a822-6ac9bcaececa", null, "Admin", "ADMIN" },
                    { "e1de5b30-6f7b-412a-a4c7-98d335030712", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "4dfebb4b-d8cd-4ff4-8c11-061964d6cfd2", 0, null, null, null, "66b80a7e-6c75-40ff-838c-ed5ba75300f4", null, new DateTime(2023, 6, 9, 13, 19, 45, 298, DateTimeKind.Local).AddTicks(5499), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEIMpWU+224HFF+ltHSyPbaJH65APzb4GjYpxoPy/RJ6qjfoRlpyH+9fLkrHP/XcGZA==", null, false, null, "3a602c48-a997-40f8-9ffa-f8fcb413a7ea", "Masculino", null, false, "admin@admin.com", null },
                    { "6daf5ab9-548b-48ab-98cc-b8d8c9c37e8a", 0, null, null, null, "b1089607-3c9f-4508-956f-3ade6ce81077", null, new DateTime(2023, 6, 9, 13, 19, 45, 235, DateTimeKind.Local).AddTicks(8753), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEHI3yjICanVnrMawdMsNrslRDuhreOgHUGiVRgApg1xy+UKyKRdBoqGoDzBJbpO1IA==", null, false, null, "6b948a97-0168-415f-b558-49507cbe8dca", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "8ac0db8a-8869-4ef2-a833-d633988cc119", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "6daf5ab9-548b-48ab-98cc-b8d8c9c37e8a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6a18adec-5c20-4621-a822-6ac9bcaececa", "4dfebb4b-d8cd-4ff4-8c11-061964d6cfd2" },
                    { "e1de5b30-6f7b-412a-a4c7-98d335030712", "6daf5ab9-548b-48ab-98cc-b8d8c9c37e8a" }
                });
        }
    }
}
