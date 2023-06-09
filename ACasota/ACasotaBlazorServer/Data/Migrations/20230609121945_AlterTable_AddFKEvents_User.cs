using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_AddFKEvents_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "7babda73-efa8-4f44-89d8-b0c62d73a463");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8215409f-4373-40ab-b252-2d81a40d1fad", "2f5dd026-07ae-4907-b7dc-e3f49b48563f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bcce4b9e-8c1a-4543-a8dd-93d066278bc8", "f95eb94a-6783-4144-9914-6b454bb97188" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8215409f-4373-40ab-b252-2d81a40d1fad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcce4b9e-8c1a-4543-a8dd-93d066278bc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f5dd026-07ae-4907-b7dc-e3f49b48563f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f95eb94a-6783-4144-9914-6b454bb97188");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Events",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_UserId",
                table: "Events",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_UserId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserId",
                table: "Events");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Events");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8215409f-4373-40ab-b252-2d81a40d1fad", null, "Admin", "ADMIN" },
                    { "bcce4b9e-8c1a-4543-a8dd-93d066278bc8", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "2f5dd026-07ae-4907-b7dc-e3f49b48563f", 0, null, null, null, "643c990b-0c5b-483c-a9e3-59a16b774531", null, new DateTime(2023, 6, 9, 13, 7, 32, 339, DateTimeKind.Local).AddTicks(8697), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAELRK13EE+Zp5ssgVJTtpPfbuleTjRGcmIizyDQTZh/3VlnPRw83Vr4pRU05z9UrBUQ==", null, false, null, "6995c7d8-8ea4-4a9c-9422-66c00d83265a", "Masculino", null, false, "admin@admin.com", null },
                    { "f95eb94a-6783-4144-9914-6b454bb97188", 0, null, null, null, "2fc5a97f-4b66-4230-b1a6-30eac4f0c634", null, new DateTime(2023, 6, 9, 13, 7, 32, 278, DateTimeKind.Local).AddTicks(5134), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEFKRm0OJL33cJw5UVgtPD3KQ/K4wiAiVNqhafOz3a0W2WVdioAOY/LoNbCf9QNtDgw==", null, false, null, "c1ce1852-4e7c-416f-b102-0c2dabf0ee17", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "7babda73-efa8-4f44-89d8-b0c62d73a463", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "f95eb94a-6783-4144-9914-6b454bb97188" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8215409f-4373-40ab-b252-2d81a40d1fad", "2f5dd026-07ae-4907-b7dc-e3f49b48563f" },
                    { "bcce4b9e-8c1a-4543-a8dd-93d066278bc8", "f95eb94a-6783-4144-9914-6b454bb97188" }
                });
        }
    }
}
