using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class BugFix_NewUser_PartnerUsernameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "d46eb452-dcae-4fd4-8e3e-e87928d73f83", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12c79e2e-3b3f-4010-862f-20fd287c3deb", null, "Partner", "PARTNER" },
                    { "40ca0164-ab60-420c-aa36-47a2a5cd4bf9", null, "Admin", "ADMIN" },
                    { "d58ed447-9716-4244-a09f-bd45c45c3cbd", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "482d381d-deef-43ee-8c32-1131d508468c", 0, null, null, null, "59886b4f-b1db-4173-841b-b6ffa38e8300", null, new DateTime(2023, 6, 14, 19, 42, 16, 716, DateTimeKind.Local).AddTicks(8353), "partner@partner.com", false, "Partner", true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEH4sqre2TcoWHpqdPa2rGtGZ/dYzcy4/AkwTZci0j1WzVK+VTgJicaPxbX8d+zdYpg==", null, false, null, "e5ce30e4-e6f4-498a-b8e1-8b47f32dd490", "Feminino", null, false, "partner@partner.com", null },
                    { "b7084a3c-c594-440f-8f53-70d1dd11c4a0", 0, null, null, null, "946e138f-7455-4cfe-9ffa-59829693d60b", null, new DateTime(2023, 6, 14, 19, 42, 16, 615, DateTimeKind.Local).AddTicks(5800), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAELTGPq8VxxXQCKJEKPR1IMbkvPs4YKasWz7w6Chr2kFWkklXXLN8ifCBrXIX/Xtt0g==", null, false, null, "956e452c-81fb-4857-97d6-4b8912c5012d", "Masculino", null, false, "admin@admin.com", null },
                    { "bcf2c623-f098-40c8-b3b9-75b36f6cf613", 0, null, null, null, "e720c394-1ff8-47bf-a72d-d5da1d9aced2", null, new DateTime(2023, 6, 14, 19, 42, 16, 505, DateTimeKind.Local).AddTicks(1844), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAECymn8N5HpSCrAItYILCpTfKiGgj3m12pKtuHdT6V5d9Tw2+R/m5RLn2c7S+CSgtNQ==", null, false, null, "10e834af-436a-4c17-a226-32a1df890b7c", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "25a3eff2-e19e-4193-b942-1f310ac748a1", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "bcf2c623-f098-40c8-b3b9-75b36f6cf613" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "12c79e2e-3b3f-4010-862f-20fd287c3deb", "482d381d-deef-43ee-8c32-1131d508468c" },
                    { "40ca0164-ab60-420c-aa36-47a2a5cd4bf9", "b7084a3c-c594-440f-8f53-70d1dd11c4a0" },
                    { "d58ed447-9716-4244-a09f-bd45c45c3cbd", "bcf2c623-f098-40c8-b3b9-75b36f6cf613" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "25a3eff2-e19e-4193-b942-1f310ac748a1");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "d46eb452-dcae-4fd4-8e3e-e87928d73f83");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12c79e2e-3b3f-4010-862f-20fd287c3deb", "482d381d-deef-43ee-8c32-1131d508468c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40ca0164-ab60-420c-aa36-47a2a5cd4bf9", "b7084a3c-c594-440f-8f53-70d1dd11c4a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d58ed447-9716-4244-a09f-bd45c45c3cbd", "bcf2c623-f098-40c8-b3b9-75b36f6cf613" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12c79e2e-3b3f-4010-862f-20fd287c3deb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40ca0164-ab60-420c-aa36-47a2a5cd4bf9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d58ed447-9716-4244-a09f-bd45c45c3cbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "482d381d-deef-43ee-8c32-1131d508468c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7084a3c-c594-440f-8f53-70d1dd11c4a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcf2c623-f098-40c8-b3b9-75b36f6cf613");

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
    }
}
