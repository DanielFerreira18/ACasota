using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableReports_AlterPropretyDescriptionToNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "bc49a5c6-208c-494b-9fb9-16cd9b161f47");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "f6f4e6c4-6827-4d18-8fd3-7fc17e6e2507");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca5ac890-f5c9-493c-b918-4f7abf0233d3", "0c4a6816-697f-4832-b5fc-5e5dc51c0bc2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b88cc8f-5e09-412e-9d6e-f4afc0efd85c", "3f5478e8-7f93-440a-bd9d-abcf4f40059e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a8ac890-9133-4366-a1c1-9dbcf6774a25", "f5a2a3e8-7102-4cc0-bc81-dc4ecbfaed2d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a8ac890-9133-4366-a1c1-9dbcf6774a25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b88cc8f-5e09-412e-9d6e-f4afc0efd85c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca5ac890-f5c9-493c-b918-4f7abf0233d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4a6816-697f-4832-b5fc-5e5dc51c0bc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f5478e8-7f93-440a-bd9d-abcf4f40059e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5a2a3e8-7102-4cc0-bc81-dc4ecbfaed2d");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "dab445d9-c98a-4365-9a55-f85f73da6676", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34e4b7c4-4edd-42b2-8944-68c45ad39545", null, "Partner", "PARTNER" },
                    { "aa4b1172-a48f-4a8c-acb9-e7f88419ff03", null, "Admin", "ADMIN" },
                    { "f0001b50-08dc-409c-8db7-6dfeba1a0d06", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "Iban", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "3498ce72-af1c-48e5-8646-7da374d4c19a", 0, null, null, null, "5d0117c6-ae47-45db-b61d-5270d244d7cd", null, new DateTime(2023, 6, 19, 15, 57, 26, 310, DateTimeKind.Local).AddTicks(8596), "admin@admin.com", false, "Admin", null, true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJt/FBRn3IAThcZPkCWwrsvR4ImB58M/UQjSv82G+N9ArE3rWs+oFzuFxlZt3YNSZA==", null, false, null, "84120b21-8938-4cde-abda-4a3cee8a8ee5", "Masculino", null, false, "admin@admin.com", null },
                    { "59dcd2ff-3f93-4645-9f53-9d1fa2119c86", 0, null, null, null, "db58cb0e-21ab-4db9-8c18-b3e0a0d45894", null, new DateTime(2023, 6, 19, 15, 57, 26, 245, DateTimeKind.Local).AddTicks(1628), "user@user.com", false, "User", null, true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEO1IQHqtvMlfCNxg2POXgct4qs3t37Zh3QIHJWqefMj/LNvm+4zmKAlD6jLWDS8SVQ==", null, false, null, "96adcd62-38d6-4693-b282-6fbcf09c5fa6", "Masculino", null, false, "user@user.com", null },
                    { "e8efdd4c-6789-463c-93ef-2408f9358400", 0, null, null, null, "f4d78e37-2b00-44c9-a2b0-5f106ebe9403", null, new DateTime(2023, 6, 19, 15, 57, 26, 373, DateTimeKind.Local).AddTicks(7674), "partner@partner.com", false, "Partner", null, true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEIbPRkek8xyNiMNdizwNCFbdtsg7Fsq2cwlfXIsBdwUcMnkmF++O8R4TnBmEk9w1ig==", null, false, null, "606fae31-dabb-4621-954e-2389666076df", "Feminino", null, false, "partner@partner.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "cb19a2e9-1bd5-4100-a430-1fea3b902e5e", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "59dcd2ff-3f93-4645-9f53-9d1fa2119c86" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "aa4b1172-a48f-4a8c-acb9-e7f88419ff03", "3498ce72-af1c-48e5-8646-7da374d4c19a" },
                    { "f0001b50-08dc-409c-8db7-6dfeba1a0d06", "59dcd2ff-3f93-4645-9f53-9d1fa2119c86" },
                    { "34e4b7c4-4edd-42b2-8944-68c45ad39545", "e8efdd4c-6789-463c-93ef-2408f9358400" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "cb19a2e9-1bd5-4100-a430-1fea3b902e5e");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "dab445d9-c98a-4365-9a55-f85f73da6676");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aa4b1172-a48f-4a8c-acb9-e7f88419ff03", "3498ce72-af1c-48e5-8646-7da374d4c19a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0001b50-08dc-409c-8db7-6dfeba1a0d06", "59dcd2ff-3f93-4645-9f53-9d1fa2119c86" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "34e4b7c4-4edd-42b2-8944-68c45ad39545", "e8efdd4c-6789-463c-93ef-2408f9358400" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34e4b7c4-4edd-42b2-8944-68c45ad39545");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa4b1172-a48f-4a8c-acb9-e7f88419ff03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0001b50-08dc-409c-8db7-6dfeba1a0d06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3498ce72-af1c-48e5-8646-7da374d4c19a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59dcd2ff-3f93-4645-9f53-9d1fa2119c86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8efdd4c-6789-463c-93ef-2408f9358400");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "f6f4e6c4-6827-4d18-8fd3-7fc17e6e2507", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a8ac890-9133-4366-a1c1-9dbcf6774a25", null, "Admin", "ADMIN" },
                    { "2b88cc8f-5e09-412e-9d6e-f4afc0efd85c", null, "Partner", "PARTNER" },
                    { "ca5ac890-f5c9-493c-b918-4f7abf0233d3", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "Iban", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "0c4a6816-697f-4832-b5fc-5e5dc51c0bc2", 0, null, null, null, "c1d7d493-0942-4466-a453-781fe3d3fea4", null, new DateTime(2023, 6, 19, 13, 40, 53, 743, DateTimeKind.Local).AddTicks(3627), "user@user.com", false, "User", null, true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEN9bIsyhbO2gu2zp3UCRa332NqBphgaIEUjQhz7Mt50Jud5mktYUeIB5aF1JmkCYIQ==", null, false, null, "031f859a-e1c1-4154-835d-3918a23bf4ea", "Masculino", null, false, "user@user.com", null },
                    { "3f5478e8-7f93-440a-bd9d-abcf4f40059e", 0, null, null, null, "85b548cc-02b3-4619-be27-f0b6e3f472ed", null, new DateTime(2023, 6, 19, 13, 40, 53, 867, DateTimeKind.Local).AddTicks(1887), "partner@partner.com", false, "Partner", null, true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEKHe1mB2GgciY7lx5PpJyFhdh6lffHThVwk9UPsmFc3qYNQDaBDvrWDlPEeUdlpDSA==", null, false, null, "99b49d14-6188-4f63-bcaf-2f15471e031a", "Feminino", null, false, "partner@partner.com", null },
                    { "f5a2a3e8-7102-4cc0-bc81-dc4ecbfaed2d", 0, null, null, null, "0aa2bf6b-3098-48e4-91e8-cf8d65646c2c", null, new DateTime(2023, 6, 19, 13, 40, 53, 803, DateTimeKind.Local).AddTicks(8159), "admin@admin.com", false, "Admin", null, true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGSiYWGKyu72qi4kIVjPzugC4uHVpVV2AYwYYBWw3x02QV+fJ4FNRAr1jrZ/JnjVtw==", null, false, null, "ef3ab758-2456-4062-b17a-504ebb44fad8", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "bc49a5c6-208c-494b-9fb9-16cd9b161f47", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "0c4a6816-697f-4832-b5fc-5e5dc51c0bc2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ca5ac890-f5c9-493c-b918-4f7abf0233d3", "0c4a6816-697f-4832-b5fc-5e5dc51c0bc2" },
                    { "2b88cc8f-5e09-412e-9d6e-f4afc0efd85c", "3f5478e8-7f93-440a-bd9d-abcf4f40059e" },
                    { "1a8ac890-9133-4366-a1c1-9dbcf6774a25", "f5a2a3e8-7102-4cc0-bc81-dc4ecbfaed2d" }
                });
        }
    }
}
