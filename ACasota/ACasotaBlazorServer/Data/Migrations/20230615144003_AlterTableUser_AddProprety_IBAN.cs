using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableUser_AddProprety_IBAN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "3e50815d-6761-416b-8bea-156c276ef21f");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "d0344c97-bf95-4886-bf7d-45cb35989fa0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9eec9bd7-1160-4a2b-b163-be7247077bb1", "0f0df311-a368-4353-803d-e39c80d3b9de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b13c41f8-dd3d-4329-9dca-ce8544272a19", "1f016672-c1d4-4abf-a754-699e22bfe652" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3c93b7c-eb08-4037-8449-197277098eac", "b4d09491-e8bc-485e-99dc-690561de63b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eec9bd7-1160-4a2b-b163-be7247077bb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b13c41f8-dd3d-4329-9dca-ce8544272a19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3c93b7c-eb08-4037-8449-197277098eac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f0df311-a368-4353-803d-e39c80d3b9de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f016672-c1d4-4abf-a754-699e22bfe652");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4d09491-e8bc-485e-99dc-690561de63b9");

            migrationBuilder.AddColumn<string>(
                name: "Iban",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "e6eaf8b8-7754-4c2c-af6c-543577e9efbb", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40c5a1a0-7bb0-41b1-bf28-1ef4aba1d59d", null, "Admin", "ADMIN" },
                    { "5e94df2c-85d1-49f5-b4be-492a9d20d5d5", null, "User", "USER" },
                    { "65c04f34-880d-4a94-8c6f-5739b67329e7", null, "Partner", "PARTNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "Iban", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "0eaec538-2460-443a-b05e-98c298f97fb5", 0, null, null, null, "45cde8ed-d6cb-41c8-ae22-a4a67cf5e127", null, new DateTime(2023, 6, 15, 15, 40, 3, 638, DateTimeKind.Local).AddTicks(8213), "admin@admin.com", false, "Admin", null, true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGhfaagHThzng2V4QLctBZ6iqIFYz9KP1JAFzQVQZtmWpsRLhYEN1u97b7U6S/lpIg==", null, false, null, "ea39b024-5fbe-4ee1-852f-e1c8ce93361e", "Masculino", null, false, "admin@admin.com", null },
                    { "9e2a18cc-246e-45e6-9780-4fce7d3e0ffb", 0, null, null, null, "71ce7106-f3b0-4c52-8dcc-66c626cca5f4", null, new DateTime(2023, 6, 15, 15, 40, 3, 579, DateTimeKind.Local).AddTicks(3258), "user@user.com", false, "User", null, true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEIBZRC0I4Jvl1Kw84rIZ0uHlaW8a6NVxtWU8wOD3FSfunN4roJpEDkMco4Yv5Rx7BQ==", null, false, null, "d833a574-b575-4237-935f-817ec3da489e", "Masculino", null, false, "user@user.com", null },
                    { "cda4fe64-aa7a-4b66-ae70-412ca0a56a31", 0, null, null, null, "75988732-97c6-49c3-bef8-3cb4e0dc75d1", null, new DateTime(2023, 6, 15, 15, 40, 3, 698, DateTimeKind.Local).AddTicks(2397), "partner@partner.com", false, "Partner", null, true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEKVLoAKkT187kUma6GN6a6A7VWbPBlYVSqzAsprEGBRyOx7HxI6itsjnYYNEXL7ADg==", null, false, null, "320023a3-9221-4362-9915-43ab6461c7ab", "Feminino", null, false, "partner@partner.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "5f092aac-a75f-4ac8-8854-b23d408b3a1a", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "9e2a18cc-246e-45e6-9780-4fce7d3e0ffb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "40c5a1a0-7bb0-41b1-bf28-1ef4aba1d59d", "0eaec538-2460-443a-b05e-98c298f97fb5" },
                    { "5e94df2c-85d1-49f5-b4be-492a9d20d5d5", "9e2a18cc-246e-45e6-9780-4fce7d3e0ffb" },
                    { "65c04f34-880d-4a94-8c6f-5739b67329e7", "cda4fe64-aa7a-4b66-ae70-412ca0a56a31" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "5f092aac-a75f-4ac8-8854-b23d408b3a1a");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "e6eaf8b8-7754-4c2c-af6c-543577e9efbb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40c5a1a0-7bb0-41b1-bf28-1ef4aba1d59d", "0eaec538-2460-443a-b05e-98c298f97fb5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e94df2c-85d1-49f5-b4be-492a9d20d5d5", "9e2a18cc-246e-45e6-9780-4fce7d3e0ffb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "65c04f34-880d-4a94-8c6f-5739b67329e7", "cda4fe64-aa7a-4b66-ae70-412ca0a56a31" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c5a1a0-7bb0-41b1-bf28-1ef4aba1d59d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e94df2c-85d1-49f5-b4be-492a9d20d5d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65c04f34-880d-4a94-8c6f-5739b67329e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0eaec538-2460-443a-b05e-98c298f97fb5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e2a18cc-246e-45e6-9780-4fce7d3e0ffb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cda4fe64-aa7a-4b66-ae70-412ca0a56a31");

            migrationBuilder.DropColumn(
                name: "Iban",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "3e50815d-6761-416b-8bea-156c276ef21f", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9eec9bd7-1160-4a2b-b163-be7247077bb1", null, "User", "USER" },
                    { "b13c41f8-dd3d-4329-9dca-ce8544272a19", null, "Partner", "PARTNER" },
                    { "c3c93b7c-eb08-4037-8449-197277098eac", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "0f0df311-a368-4353-803d-e39c80d3b9de", 0, null, null, null, "c3235f43-ae9d-4c7f-86fb-ee793b40a67a", null, new DateTime(2023, 6, 15, 1, 5, 0, 286, DateTimeKind.Local).AddTicks(7218), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAELJcfegKuslv0DdhDNb3Qi0pwhNux8+/iV6dnLsveR0goay+sAg4Bua5Xyyzu9XW7w==", null, false, null, "f2deb7a1-20ea-4c8e-8e4b-3e7e7eca9c5c", "Masculino", null, false, "user@user.com", null },
                    { "1f016672-c1d4-4abf-a754-699e22bfe652", 0, null, null, null, "97c32893-2741-469f-a795-e592e961e693", null, new DateTime(2023, 6, 15, 1, 5, 0, 469, DateTimeKind.Local).AddTicks(9750), "partner@partner.com", false, "Partner", true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEEOe2IcSYB7c3rvYONpIN8Hz8D/HDzOf0+peUAu58WhGuNg86vlff26HdwihcCl6Rw==", null, false, null, "a93aa1c8-63d1-4269-8f64-a30a367f9b2b", "Feminino", null, false, "partner@partner.com", null },
                    { "b4d09491-e8bc-485e-99dc-690561de63b9", 0, null, null, null, "17940042-e9c3-43df-9ac2-6a098114ed31", null, new DateTime(2023, 6, 15, 1, 5, 0, 383, DateTimeKind.Local).AddTicks(1841), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAECAI/ZMd2ucAV1FBFFGAvZKx103ABvh+SJLnwZwQgCt9ILlT9tuSKjsdizCa2cMw3g==", null, false, null, "d98a9e25-ff81-4d1b-afeb-a98da04e7b4c", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "d0344c97-bf95-4886-bf7d-45cb35989fa0", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "0f0df311-a368-4353-803d-e39c80d3b9de" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9eec9bd7-1160-4a2b-b163-be7247077bb1", "0f0df311-a368-4353-803d-e39c80d3b9de" },
                    { "b13c41f8-dd3d-4329-9dca-ce8544272a19", "1f016672-c1d4-4abf-a754-699e22bfe652" },
                    { "c3c93b7c-eb08-4037-8449-197277098eac", "b4d09491-e8bc-485e-99dc-690561de63b9" }
                });
        }
    }
}
