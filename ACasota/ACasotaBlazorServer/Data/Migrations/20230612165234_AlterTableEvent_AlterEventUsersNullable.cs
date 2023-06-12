using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableEvent_AlterEventUsersNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "336e1618-44ad-4621-8118-e7f1b523067a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a611995a-f756-4d58-bde3-01fd6135b168", "426a6ee1-efdd-467c-9675-3f2b723d66aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "139f9613-34d7-4587-a3bd-eb6776c5c1fa", "58bbf575-7f90-4986-bbed-1853098a5495" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "139f9613-34d7-4587-a3bd-eb6776c5c1fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a611995a-f756-4d58-bde3-01fd6135b168");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "426a6ee1-efdd-467c-9675-3f2b723d66aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58bbf575-7f90-4986-bbed-1853098a5495");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "139f9613-34d7-4587-a3bd-eb6776c5c1fa", null, "Admin", "ADMIN" },
                    { "a611995a-f756-4d58-bde3-01fd6135b168", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "426a6ee1-efdd-467c-9675-3f2b723d66aa", 0, null, null, null, "01203614-fea1-4abc-b63e-a36bc0236422", null, new DateTime(2023, 6, 12, 14, 52, 53, 587, DateTimeKind.Local).AddTicks(8897), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEBt6H0FVjMsKCn9VySBV1vDX0ScqqbcMmeAgJOQHa3axzNmt1gLda/Rf8OY6j+a5Iw==", null, false, null, "4dbb4b2f-0193-4f1c-9dc8-a264e1cbe7f9", "Masculino", null, false, "user@user.com", null },
                    { "58bbf575-7f90-4986-bbed-1853098a5495", 0, null, null, null, "7383820b-a978-4c8c-8da5-cf1f88913f19", null, new DateTime(2023, 6, 12, 14, 52, 53, 647, DateTimeKind.Local).AddTicks(4732), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEKDpGGudkxMPgMZ3mFhKhiKWLH8Xllm8la/1uS+obzjwCKQKYDEf3NSGbjqELGojHA==", null, false, null, "25acd99a-99b5-4040-9d28-4b025c4b4212", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "336e1618-44ad-4621-8118-e7f1b523067a", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "426a6ee1-efdd-467c-9675-3f2b723d66aa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a611995a-f756-4d58-bde3-01fd6135b168", "426a6ee1-efdd-467c-9675-3f2b723d66aa" },
                    { "139f9613-34d7-4587-a3bd-eb6776c5c1fa", "58bbf575-7f90-4986-bbed-1853098a5495" }
                });
        }
    }
}
