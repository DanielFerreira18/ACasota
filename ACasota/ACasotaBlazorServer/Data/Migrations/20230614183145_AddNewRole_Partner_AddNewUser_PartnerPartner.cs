using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewRole_Partner_AddNewUser_PartnerPartner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "f2f5cffb-15e4-4854-94ca-27c61454d450");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28b42a5b-bf80-41dd-9d45-c0325fea2bc3", "222a852c-5481-46c7-8044-523c66bff3c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce9519fe-e5bd-4c51-a972-b30958fde7b9", "3876115c-24c7-4786-83fc-28a9a6fcd21b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28b42a5b-bf80-41dd-9d45-c0325fea2bc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce9519fe-e5bd-4c51-a972-b30958fde7b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "222a852c-5481-46c7-8044-523c66bff3c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3876115c-24c7-4786-83fc-28a9a6fcd21b");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "8789d701-a735-4d5a-9973-32f33804112a", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1df0801b-7cb1-410f-a703-d8e130eb2bc1", null, "User", "USER" },
                    { "2d63dab3-db1f-44cd-83e5-c0a7d6b6837e", null, "Partner", "PARTNER" },
                    { "f8e7cde6-4a1d-4564-b668-a7d8409608ca", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "87fb64b7-58e4-43c3-b7ce-b65995cd688c", 0, null, null, null, "b423516e-3785-4d5b-bc0b-0c6e222c3e41", null, new DateTime(2023, 6, 14, 19, 31, 44, 659, DateTimeKind.Local).AddTicks(6596), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAELYcXrS3gqZHKHIg5cKk8syMFwj/C99zez3UXR5NRaIATywy/MTc7GyWnjPqz6ev5A==", null, false, null, "c2b3e28f-c8e2-41ee-a5d6-1c3e18fe8f72", "Masculino", null, false, "admin@admin.com", null },
                    { "adbafbff-c49d-4468-968b-4547b6776aa0", 0, null, null, null, "8a895de3-a1c9-4594-8c52-364a06c7d857", null, new DateTime(2023, 6, 14, 19, 31, 44, 560, DateTimeKind.Local).AddTicks(1830), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEGVqzmeyMY6zPvXzqyRRzkLXCd/AZRi+fwg+qDn1qwX7xUyGbKSmmrmqdQLa8Q0wyg==", null, false, null, "a7484aee-f905-469e-9ab3-5448befe9321", "Masculino", null, false, "user@user.com", null },
                    { "b59a7ebe-6959-49f1-8a18-20b87e2db038", 0, null, null, null, "3630db14-82c8-4726-bd19-6067d4ebf439", null, new DateTime(2023, 6, 14, 19, 31, 44, 744, DateTimeKind.Local).AddTicks(819), "partner@partner.com", false, "Partner", true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEOJideoiRF/n80TgHg2rn/wsPKY9kCJ1tU7SkL8hhWuXk31UN1ELCU+EW/ZOfOndQg==", null, false, null, "12e11d90-2653-42eb-8bdb-9649c995ef48", "Feminino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "d7b39c0d-e6c5-4ee5-881f-f3996498ff29", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "adbafbff-c49d-4468-968b-4547b6776aa0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f8e7cde6-4a1d-4564-b668-a7d8409608ca", "87fb64b7-58e4-43c3-b7ce-b65995cd688c" },
                    { "1df0801b-7cb1-410f-a703-d8e130eb2bc1", "adbafbff-c49d-4468-968b-4547b6776aa0" },
                    { "2d63dab3-db1f-44cd-83e5-c0a7d6b6837e", "b59a7ebe-6959-49f1-8a18-20b87e2db038" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "8789d701-a735-4d5a-9973-32f33804112a");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "d7b39c0d-e6c5-4ee5-881f-f3996498ff29");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8e7cde6-4a1d-4564-b668-a7d8409608ca", "87fb64b7-58e4-43c3-b7ce-b65995cd688c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1df0801b-7cb1-410f-a703-d8e130eb2bc1", "adbafbff-c49d-4468-968b-4547b6776aa0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d63dab3-db1f-44cd-83e5-c0a7d6b6837e", "b59a7ebe-6959-49f1-8a18-20b87e2db038" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1df0801b-7cb1-410f-a703-d8e130eb2bc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d63dab3-db1f-44cd-83e5-c0a7d6b6837e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8e7cde6-4a1d-4564-b668-a7d8409608ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87fb64b7-58e4-43c3-b7ce-b65995cd688c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adbafbff-c49d-4468-968b-4547b6776aa0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b59a7ebe-6959-49f1-8a18-20b87e2db038");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28b42a5b-bf80-41dd-9d45-c0325fea2bc3", null, "User", "USER" },
                    { "ce9519fe-e5bd-4c51-a972-b30958fde7b9", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "222a852c-5481-46c7-8044-523c66bff3c1", 0, null, null, null, "3db24790-9455-42a8-9cd3-cfa396b2d66b", null, new DateTime(2023, 6, 12, 20, 7, 21, 5, DateTimeKind.Local).AddTicks(2035), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEEqxFam5pHUaMaNwSIkDah00erwMmoT11GyazrXQEQ9N0+R1iIkq4XcygBlH07e8Mg==", null, false, null, "7735431a-1c4c-40b9-88c3-4c72924cb756", "Masculino", null, false, "user@user.com", null },
                    { "3876115c-24c7-4786-83fc-28a9a6fcd21b", 0, null, null, null, "137f409f-831b-4aa1-a8b9-d0adbc32f484", null, new DateTime(2023, 6, 12, 20, 7, 21, 64, DateTimeKind.Local).AddTicks(973), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJl9/ZWlNOBzGATLs39BlSVrkFseKjQZgMQUvvpS5lOeQc4iqaLThAGleP/b+/TXLw==", null, false, null, "d31cb3fe-6176-4cfb-ab01-6f483957a75a", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "f2f5cffb-15e4-4854-94ca-27c61454d450", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "222a852c-5481-46c7-8044-523c66bff3c1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "28b42a5b-bf80-41dd-9d45-c0325fea2bc3", "222a852c-5481-46c7-8044-523c66bff3c1" },
                    { "ce9519fe-e5bd-4c51-a972-b30958fde7b9", "3876115c-24c7-4786-83fc-28a9a6fcd21b" }
                });
        }
    }
}
