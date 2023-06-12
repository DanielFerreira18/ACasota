using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class RevertMigration_AlterTableEvent_RevertEventUsersNotNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "fd2474fc-7099-4edf-8253-f3536647d706");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a331261-dd4c-44fe-bd0e-3304299efd20", "59cfbc42-1977-4479-952b-e429e72994c9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84cc53ad-c730-4e6e-8c5a-f5508976cb20", "7a699322-e80f-4053-9cdc-c3fbba4eb65b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84cc53ad-c730-4e6e-8c5a-f5508976cb20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a331261-dd4c-44fe-bd0e-3304299efd20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59cfbc42-1977-4479-952b-e429e72994c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a699322-e80f-4053-9cdc-c3fbba4eb65b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5895f482-8ed1-4f32-aad8-f12689cebd27", null, "Admin", "ADMIN" },
                    { "f2c49958-a598-4f84-9017-13025be9df0e", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "1237ed08-6a44-4e20-8cf8-09ec5b3238cf", 0, null, null, null, "44d37776-1474-490a-82cc-45490ce189c0", null, new DateTime(2023, 6, 12, 18, 6, 23, 159, DateTimeKind.Local).AddTicks(8560), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJ9I3D0MRUEUhk9ajKsNYjlI2glYb/M2Nn63IEvEufFpNv568xkgDbI6j5BhX99W2g==", null, false, null, "741eb14d-7d1c-4bc8-9206-e8593f80a96f", "Masculino", null, false, "admin@admin.com", null },
                    { "29999d65-e585-47ff-b57d-69647ee65b54", 0, null, null, null, "a6dd3f74-1009-45f6-8c94-47491fc48d94", null, new DateTime(2023, 6, 12, 18, 6, 23, 100, DateTimeKind.Local).AddTicks(7037), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEBJTIn8N2pCwf6Ts9CoVtrNmgS8lxCria78IfsHBZnQwVTgwJL9VkiCzjPIieO1NJg==", null, false, null, "2e6582cd-db3b-4bea-b69f-5acf0fe4d2db", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "845d2a5c-b5fd-4e48-9a7d-3b3ccb54aa4f", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "29999d65-e585-47ff-b57d-69647ee65b54" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5895f482-8ed1-4f32-aad8-f12689cebd27", "1237ed08-6a44-4e20-8cf8-09ec5b3238cf" },
                    { "f2c49958-a598-4f84-9017-13025be9df0e", "29999d65-e585-47ff-b57d-69647ee65b54" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "845d2a5c-b5fd-4e48-9a7d-3b3ccb54aa4f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5895f482-8ed1-4f32-aad8-f12689cebd27", "1237ed08-6a44-4e20-8cf8-09ec5b3238cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2c49958-a598-4f84-9017-13025be9df0e", "29999d65-e585-47ff-b57d-69647ee65b54" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5895f482-8ed1-4f32-aad8-f12689cebd27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2c49958-a598-4f84-9017-13025be9df0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1237ed08-6a44-4e20-8cf8-09ec5b3238cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29999d65-e585-47ff-b57d-69647ee65b54");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "84cc53ad-c730-4e6e-8c5a-f5508976cb20", null, "Admin", "ADMIN" },
                    { "8a331261-dd4c-44fe-bd0e-3304299efd20", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "59cfbc42-1977-4479-952b-e429e72994c9", 0, null, null, null, "d4f65fba-ea7e-448d-ad86-dea0d72c177f", null, new DateTime(2023, 6, 12, 17, 52, 34, 329, DateTimeKind.Local).AddTicks(2068), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEF1WuMFZlHTKDBZBeVnU3DjV2YnuiFBbDei01VpdzhpJM98JGVcW5wvCuxd4XOT70Q==", null, false, null, "532d7ece-b10f-45f9-bc13-fb63bd39fb3c", "Masculino", null, false, "user@user.com", null },
                    { "7a699322-e80f-4053-9cdc-c3fbba4eb65b", 0, null, null, null, "dd8fdebe-5093-43df-b1f3-dbd4eadbfae1", null, new DateTime(2023, 6, 12, 17, 52, 34, 388, DateTimeKind.Local).AddTicks(3747), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJ97RQo07kzsxJ8/49dMAZeoJKw+LwQdLsUqJWXkBNGcdHgy5snxKmkOFUQcOd87LQ==", null, false, null, "93249d81-72e5-4305-91cc-51870781809e", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "fd2474fc-7099-4edf-8253-f3536647d706", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "59cfbc42-1977-4479-952b-e429e72994c9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8a331261-dd4c-44fe-bd0e-3304299efd20", "59cfbc42-1977-4479-952b-e429e72994c9" },
                    { "84cc53ad-c730-4e6e-8c5a-f5508976cb20", "7a699322-e80f-4053-9cdc-c3fbba4eb65b" }
                });
        }
    }
}
