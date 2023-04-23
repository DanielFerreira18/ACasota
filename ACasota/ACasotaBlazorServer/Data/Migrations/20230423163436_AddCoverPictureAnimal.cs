using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCoverPictureAnimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "67b7e4aa-e805-4548-9b18-ce67888d4138");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4ef30e09-dcb4-4230-b661-12f9f199a078", "2de31a33-6665-4853-9b5d-101ff9cbec82" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a1ee06c-b368-4784-8168-742ed10465c4", "fa1be55c-e48f-43f2-b05c-3b7e484b7e4c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a1ee06c-b368-4784-8168-742ed10465c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ef30e09-dcb4-4230-b661-12f9f199a078");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de31a33-6665-4853-9b5d-101ff9cbec82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa1be55c-e48f-43f2-b05c-3b7e484b7e4c");

            migrationBuilder.AddColumn<string>(
                name: "CoverPicture",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5e263b78-66af-431c-a3ca-4d625449ab51", null, "Admin", "ADMIN" },
                    { "8a050405-f44c-4505-b54e-7c82ccd475b0", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "1a938c1c-2cf4-42f9-9bb9-ce993a459c4e", 0, null, null, null, "f8f49da6-3180-4eff-b75f-37515efae53f", null, new DateTime(2023, 4, 23, 17, 34, 36, 238, DateTimeKind.Local).AddTicks(8864), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJPfb+ouB2kDCR5/PtpWr/cCy4RfQhwLn45Q5H4Kgi1jcRp1adbq7Ml9mxZf/Td2fg==", null, false, null, "8265e01a-5712-41c2-a353-d874d2b3e3ff", null, false, "admin@admin.com", null },
                    { "5ca85dc3-a397-421a-b8dc-c2429a009d10", 0, null, null, null, "a4aaf3c3-59b6-447a-8cba-a357f59b148b", null, new DateTime(2023, 4, 23, 17, 34, 36, 149, DateTimeKind.Local).AddTicks(5815), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAELRP4GI0YqKlZ1guetvW4V0MjbWcoDSM2uBy4hrvzJh38lnDhivVXE3kj+BDIVKSfA==", null, false, null, "a949f684-3c26-48e3-848b-bf3eea5e6c0d", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "Colour", "CoverPicture", "Name", "Race", "UserId" },
                values: new object[] { "5b2f58ae-dedd-4f00-a213-ae19a370b335", "2 Months", null, "Ginger", null, "Lucas", "Cat", "5ca85dc3-a397-421a-b8dc-c2429a009d10" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5e263b78-66af-431c-a3ca-4d625449ab51", "1a938c1c-2cf4-42f9-9bb9-ce993a459c4e" },
                    { "8a050405-f44c-4505-b54e-7c82ccd475b0", "5ca85dc3-a397-421a-b8dc-c2429a009d10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "5b2f58ae-dedd-4f00-a213-ae19a370b335");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e263b78-66af-431c-a3ca-4d625449ab51", "1a938c1c-2cf4-42f9-9bb9-ce993a459c4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a050405-f44c-4505-b54e-7c82ccd475b0", "5ca85dc3-a397-421a-b8dc-c2429a009d10" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e263b78-66af-431c-a3ca-4d625449ab51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a050405-f44c-4505-b54e-7c82ccd475b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a938c1c-2cf4-42f9-9bb9-ce993a459c4e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ca85dc3-a397-421a-b8dc-c2429a009d10");

            migrationBuilder.DropColumn(
                name: "CoverPicture",
                table: "Animals");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a1ee06c-b368-4784-8168-742ed10465c4", null, "Admin", "ADMIN" },
                    { "4ef30e09-dcb4-4230-b661-12f9f199a078", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "2de31a33-6665-4853-9b5d-101ff9cbec82", 0, null, null, null, "234c67b1-cb9b-4df1-bd18-1cdf86c31b25", null, new DateTime(2023, 4, 23, 16, 0, 39, 66, DateTimeKind.Local).AddTicks(5262), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEIt11F9zC6MJJAhcYYnXsZJXn58V/RqIVQBZf7E0LqIW6kpaicxh0fB1ecchgxHuvA==", null, false, null, "b6ed6a24-fda9-4211-ae61-5e2f92c72dff", null, false, "user@user.com", null },
                    { "fa1be55c-e48f-43f2-b05c-3b7e484b7e4c", 0, null, null, null, "66150515-58c5-4bdd-96f7-c8d46e68c586", null, new DateTime(2023, 4, 23, 16, 0, 39, 151, DateTimeKind.Local).AddTicks(1924), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEAcWAvrnn/Ha2EjQ+BC0B+fOYFV1TipxB2pLlZ216qr+WhbUo5K6u5+H5BYpDcwchg==", null, false, null, "dbf6771f-0247-4244-a5e3-bb5be0517f20", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "Colour", "Name", "Race", "UserId" },
                values: new object[] { "67b7e4aa-e805-4548-9b18-ce67888d4138", "2 Months", null, "Ginger", "Lucas", "Cat", "2de31a33-6665-4853-9b5d-101ff9cbec82" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4ef30e09-dcb4-4230-b661-12f9f199a078", "2de31a33-6665-4853-9b5d-101ff9cbec82" },
                    { "2a1ee06c-b368-4784-8168-742ed10465c4", "fa1be55c-e48f-43f2-b05c-3b7e484b7e4c" }
                });
        }
    }
}
