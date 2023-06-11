using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableEvent_StateToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "047a6e1d-4aef-45b9-b363-283d30384aba", null, "User", "USER" },
                    { "e05d37f8-ba69-4def-847c-c2a5d6a0a751", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "bf7e1ff2-f538-4384-a9a9-9ed8738ab28e", 0, null, null, null, "a4c46c62-0c11-4448-b739-19243503c4e7", null, new DateTime(2023, 6, 11, 18, 36, 54, 329, DateTimeKind.Local).AddTicks(7093), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEB4Z4pGBafQxFYNI0QQXoOci03o2VoycKaw1rB8rkC3JroK376AN3vlS3oAbjULtAg==", null, false, null, "ed941a85-f3c9-4014-8a9b-da03a8892710", "Masculino", null, false, "user@user.com", null },
                    { "c0d1c3f6-669f-49a0-8002-3971bd21aa8c", 0, null, null, null, "652e3c56-8ed2-4f2b-bf05-b6ccf8f9907e", null, new DateTime(2023, 6, 11, 18, 36, 54, 393, DateTimeKind.Local).AddTicks(1430), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEEyZsmhk+E7cy6GcUPv6hNmG/qt4i7YkQjvFnZq+B2deOAzeRP52XAgKdwEPcxzuig==", null, false, null, "eeb2852a-aea4-4718-9dab-e1966ba6c0bf", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "73806e48-4a16-423a-b97f-9c116045c21f", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "bf7e1ff2-f538-4384-a9a9-9ed8738ab28e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "047a6e1d-4aef-45b9-b363-283d30384aba", "bf7e1ff2-f538-4384-a9a9-9ed8738ab28e" },
                    { "e05d37f8-ba69-4def-847c-c2a5d6a0a751", "c0d1c3f6-669f-49a0-8002-3971bd21aa8c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "73806e48-4a16-423a-b97f-9c116045c21f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "047a6e1d-4aef-45b9-b363-283d30384aba", "bf7e1ff2-f538-4384-a9a9-9ed8738ab28e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e05d37f8-ba69-4def-847c-c2a5d6a0a751", "c0d1c3f6-669f-49a0-8002-3971bd21aa8c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "047a6e1d-4aef-45b9-b363-283d30384aba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e05d37f8-ba69-4def-847c-c2a5d6a0a751");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf7e1ff2-f538-4384-a9a9-9ed8738ab28e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0d1c3f6-669f-49a0-8002-3971bd21aa8c");

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
    }
}
