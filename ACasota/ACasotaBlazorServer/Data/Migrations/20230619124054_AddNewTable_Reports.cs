using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_Reports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "de2c8d76-3f53-46a7-ad28-309c10f95e70");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "e16f0530-59cf-4719-986a-df1f771213fa");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b28840d-d6f7-4bfb-a52c-0445dbc77461", "17316fee-f60c-4fc5-aae0-d30efefbb635" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e7743ccc-9c40-40f3-9c31-2a4765e4554f", "2a44c8c0-7428-4aa5-b0b5-a5f1581890f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3e0f0634-79d8-474b-8371-8c2cfed7ca01", "f947b648-cb09-4894-b9f2-4f7fb61b3e0d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b28840d-d6f7-4bfb-a52c-0445dbc77461");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e0f0634-79d8-474b-8371-8c2cfed7ca01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7743ccc-9c40-40f3-9c31-2a4765e4554f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17316fee-f60c-4fc5-aae0-d30efefbb635");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a44c8c0-7428-4aa5-b0b5-a5f1581890f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f947b648-cb09-4894-b9f2-4f7fb61b3e0d");

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnimalRace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reports_UserId",
                table: "Reports",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

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

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "de2c8d76-3f53-46a7-ad28-309c10f95e70", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b28840d-d6f7-4bfb-a52c-0445dbc77461", null, "Partner", "PARTNER" },
                    { "3e0f0634-79d8-474b-8371-8c2cfed7ca01", null, "User", "USER" },
                    { "e7743ccc-9c40-40f3-9c31-2a4765e4554f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "Iban", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "17316fee-f60c-4fc5-aae0-d30efefbb635", 0, null, null, null, "45d55f9e-7a06-4529-b529-3d33cdc28aab", null, new DateTime(2023, 6, 19, 10, 25, 14, 85, DateTimeKind.Local).AddTicks(2867), "partner@partner.com", false, "Partner", null, true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEDvUQ2iapJ2PnYcUjPPEQdq8+xA7MxO1S2xWnsXiJoZciIawpxKonXbZ/ey72OOTTg==", null, false, null, "7b18fd7e-d984-47e8-b412-1b66a1a4b86c", "Feminino", null, false, "partner@partner.com", null },
                    { "2a44c8c0-7428-4aa5-b0b5-a5f1581890f5", 0, null, null, null, "94d712bd-1309-4085-af0e-e38c5f2f8de5", null, new DateTime(2023, 6, 19, 10, 25, 14, 21, DateTimeKind.Local).AddTicks(415), "admin@admin.com", false, "Admin", null, true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEOE+8YTrLVTLvvFu+deIpXA9HCrTXj6y0LvAtEaExv/LyX5TcgxMu+0LgzS5oXZCMA==", null, false, null, "a2010e53-7e29-4194-a339-40e15a0241ad", "Masculino", null, false, "admin@admin.com", null },
                    { "f947b648-cb09-4894-b9f2-4f7fb61b3e0d", 0, null, null, null, "7e82ca05-e10f-43a8-a8d0-1019f9ad00d0", null, new DateTime(2023, 6, 19, 10, 25, 13, 958, DateTimeKind.Local).AddTicks(1825), "user@user.com", false, "User", null, true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEGMm+gJjlu98tL0Y9yelRUSgdwED2jWBIz1KEYu1gjq7uIivRcsoz1vbYRyuPBV0Zw==", null, false, null, "a680cb7c-775f-4a98-b6f3-f29e82e2aaa5", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "e16f0530-59cf-4719-986a-df1f771213fa", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "f947b648-cb09-4894-b9f2-4f7fb61b3e0d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2b28840d-d6f7-4bfb-a52c-0445dbc77461", "17316fee-f60c-4fc5-aae0-d30efefbb635" },
                    { "e7743ccc-9c40-40f3-9c31-2a4765e4554f", "2a44c8c0-7428-4aa5-b0b5-a5f1581890f5" },
                    { "3e0f0634-79d8-474b-8371-8c2cfed7ca01", "f947b648-cb09-4894-b9f2-4f7fb61b3e0d" }
                });
        }
    }
}
