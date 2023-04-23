using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAnimalUser_OneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "6272058f-a52e-4ebc-a100-de3c2ffd39eb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dfcd195a-1c2a-440e-b128-c2df5e5d19f9", "3107d546-ffda-491b-900a-37f5bdb6937a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "96303480-e7ff-4ecd-9a52-aee722f900cc", "e2dc9387-8fa3-4076-ab3f-f37fbee883f8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96303480-e7ff-4ecd-9a52-aee722f900cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfcd195a-1c2a-440e-b128-c2df5e5d19f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3107d546-ffda-491b-900a-37f5bdb6937a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2dc9387-8fa3-4076-ab3f-f37fbee883f8");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Animals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals");

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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Animals",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96303480-e7ff-4ecd-9a52-aee722f900cc", null, "Admin", "ADMIN" },
                    { "dfcd195a-1c2a-440e-b128-c2df5e5d19f9", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "3107d546-ffda-491b-900a-37f5bdb6937a", 0, null, null, null, "aeaba321-6d44-456f-892f-ec2c9fbd84a4", null, new DateTime(2023, 4, 22, 22, 59, 41, 672, DateTimeKind.Local).AddTicks(3616), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEPTSNXqz9RySae9AI+8Ose9XfB5vB4FbxKnnYGPiTXsAmPS6z4zfkJLCH4rhq9ButQ==", null, false, null, "88184bfe-b3a8-4f25-838c-e48f4c5ce726", null, false, "user@user.com", null },
                    { "e2dc9387-8fa3-4076-ab3f-f37fbee883f8", 0, null, null, null, "b7244fa5-3573-4818-83bc-ad7496015e47", null, new DateTime(2023, 4, 22, 22, 59, 41, 763, DateTimeKind.Local).AddTicks(8452), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEDb5pk5gokukspkZ8huhTshEVAMv9UC/+meymBIC+r65Mr439Qs9JRYnhcDF/CV2tQ==", null, false, null, "83b00d38-4884-400d-86cd-6863e2df5e6c", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "Colour", "Name", "Race", "UserId" },
                values: new object[] { "6272058f-a52e-4ebc-a100-de3c2ffd39eb", "2 Months", null, "Ginger", "Lucas", "Cat", "3107d546-ffda-491b-900a-37f5bdb6937a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dfcd195a-1c2a-440e-b128-c2df5e5d19f9", "3107d546-ffda-491b-900a-37f5bdb6937a" },
                    { "96303480-e7ff-4ecd-9a52-aee722f900cc", "e2dc9387-8fa3-4076-ab3f-f37fbee883f8" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AspNetUsers_UserId",
                table: "Animals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
