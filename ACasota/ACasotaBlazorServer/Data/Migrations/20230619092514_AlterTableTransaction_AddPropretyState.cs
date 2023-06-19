using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableTransaction_AddPropretyState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "aedc0e40-534d-4de3-8049-5d2f1565a7c8");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "c9730c6b-c151-4fb0-b851-c650ba980d9c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6307a5ea-2cde-4702-b284-42bff7a07d15", "0e2f59fe-013d-44cb-9b3a-4a94fcb90acd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb67622c-f742-438c-880e-d57b32110e78", "633fc114-4d33-40d9-a060-d9da6742d505" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9110c76-ffe5-4fff-a53b-ab9725dbc76a", "d6c3c4ea-b72a-452d-928a-06ecbfbd2da4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6307a5ea-2cde-4702-b284-42bff7a07d15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9110c76-ffe5-4fff-a53b-ab9725dbc76a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb67622c-f742-438c-880e-d57b32110e78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e2f59fe-013d-44cb-9b3a-4a94fcb90acd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "633fc114-4d33-40d9-a060-d9da6742d505");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6c3c4ea-b72a-452d-928a-06ecbfbd2da4");

            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "Transactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "State",
                table: "Transactions");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "aedc0e40-534d-4de3-8049-5d2f1565a7c8", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6307a5ea-2cde-4702-b284-42bff7a07d15", null, "Partner", "PARTNER" },
                    { "e9110c76-ffe5-4fff-a53b-ab9725dbc76a", null, "Admin", "ADMIN" },
                    { "fb67622c-f742-438c-880e-d57b32110e78", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "Iban", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "0e2f59fe-013d-44cb-9b3a-4a94fcb90acd", 0, null, null, null, "cd5fa124-6a89-41e8-87ce-d41f45fe027e", null, new DateTime(2023, 6, 17, 14, 41, 22, 976, DateTimeKind.Local).AddTicks(8864), "partner@partner.com", false, "Partner", null, true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEEItsn4vnvRLs6oLxje3+t+OwbvCRr6CMQ6hXAX1Mrcf+8db2UNvWG3xTkOUjCaHPA==", null, false, null, "91dee2b5-15bc-4abb-8a55-0d0f57c19883", "Feminino", null, false, "partner@partner.com", null },
                    { "633fc114-4d33-40d9-a060-d9da6742d505", 0, null, null, null, "d5d8bbc3-575e-43a4-ba4a-245217bf271d", null, new DateTime(2023, 6, 17, 14, 41, 22, 857, DateTimeKind.Local).AddTicks(7170), "user@user.com", false, "User", null, true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAECT+gjUS+Nsn6G8SBcS1yvecQnTGG8oZFfo5SrkxfW1YHWXo9AYbNjCziZE7/PU67g==", null, false, null, "2803186f-4274-4c4e-9312-32c667b63fa9", "Masculino", null, false, "user@user.com", null },
                    { "d6c3c4ea-b72a-452d-928a-06ecbfbd2da4", 0, null, null, null, "33e8275d-5a75-4ecc-8aa6-17dd23e9eb98", null, new DateTime(2023, 6, 17, 14, 41, 22, 917, DateTimeKind.Local).AddTicks(5214), "admin@admin.com", false, "Admin", null, true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEPhM1CTWaN9ieJ5zmVnQrbeczPVBYLhOHMYkpGC3ImFheA5ypZgHIRHM9a2dLTsZGw==", null, false, null, "31e6068d-5f8b-45c8-85c6-233034646346", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "c9730c6b-c151-4fb0-b851-c650ba980d9c", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "633fc114-4d33-40d9-a060-d9da6742d505" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6307a5ea-2cde-4702-b284-42bff7a07d15", "0e2f59fe-013d-44cb-9b3a-4a94fcb90acd" },
                    { "fb67622c-f742-438c-880e-d57b32110e78", "633fc114-4d33-40d9-a060-d9da6742d505" },
                    { "e9110c76-ffe5-4fff-a53b-ab9725dbc76a", "d6c3c4ea-b72a-452d-928a-06ecbfbd2da4" }
                });
        }
    }
}
