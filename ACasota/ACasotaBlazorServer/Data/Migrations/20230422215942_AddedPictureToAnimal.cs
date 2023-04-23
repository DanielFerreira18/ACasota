using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPictureToAnimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "f9cba49b-403e-4787-abde-75b174fcc420");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8c4aca04-1e6a-4d73-8384-dc72ad3366fe", "3b998330-057a-4bbc-8eca-1e795f8a253c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b842c043-b265-436d-9a81-5c7e347c6c92", "cebe7b9f-b770-42f0-8be1-ba951a8c6bb0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c4aca04-1e6a-4d73-8384-dc72ad3366fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b842c043-b265-436d-9a81-5c7e347c6c92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b998330-057a-4bbc-8eca-1e795f8a253c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cebe7b9f-b770-42f0-8be1-ba951a8c6bb0");

            migrationBuilder.AddColumn<string>(
                name: "AnimalPicture",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "AnimalPicture",
                table: "Animals");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8c4aca04-1e6a-4d73-8384-dc72ad3366fe", null, "User", "USER" },
                    { "b842c043-b265-436d-9a81-5c7e347c6c92", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "3b998330-057a-4bbc-8eca-1e795f8a253c", 0, null, null, null, "4fda376b-340c-41db-b22f-57bd2c4fe4bf", null, new DateTime(2023, 4, 20, 15, 40, 38, 97, DateTimeKind.Local).AddTicks(9240), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEMmboid623as3daxK351Slj/djyxeOtOvHN4wOU4v1eel1HwOpKNRt4u7E099yx/Cg==", null, false, null, "b94e4b13-c6b0-4f8b-a61b-0906ebb7a6aa", null, false, "user@user.com", null },
                    { "cebe7b9f-b770-42f0-8be1-ba951a8c6bb0", 0, null, null, null, "1b6fac87-79f0-40af-8f60-3a9592d210a4", null, new DateTime(2023, 4, 20, 15, 40, 38, 159, DateTimeKind.Local).AddTicks(6157), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEMUancrk6Dkxzi3k5RHZteLdmSPXtE1iz4K+K8QlBZZ1DmaW2iimmbEVNbiptsrzjA==", null, false, null, "91047201-b35c-48a5-b5f6-f8c4724bb9b9", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Colour", "Name", "Race", "UserId" },
                values: new object[] { "f9cba49b-403e-4787-abde-75b174fcc420", "2 Months", "Ginger", "Lucas", "Cat", "3b998330-057a-4bbc-8eca-1e795f8a253c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8c4aca04-1e6a-4d73-8384-dc72ad3366fe", "3b998330-057a-4bbc-8eca-1e795f8a253c" },
                    { "b842c043-b265-436d-9a81-5c7e347c6c92", "cebe7b9f-b770-42f0-8be1-ba951a8c6bb0" }
                });
        }
    }
}
