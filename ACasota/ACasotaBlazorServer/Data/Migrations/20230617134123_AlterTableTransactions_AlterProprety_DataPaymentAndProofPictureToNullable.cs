using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableTransactions_AlterProprety_DataPaymentAndProofPictureToNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "5f092aac-a75f-4ac8-8854-b23d408b3a1a");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "e6eaf8b8-7754-4c2c-af6c-543577e9efbb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40c5a1a0-7bb0-41b1-bf28-1ef4aba1d59d", "0eaec538-2460-443a-b05e-98c298f97fb5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e94df2c-85d1-49f5-b4be-492a9d20d5d5", "9e2a18cc-246e-45e6-9780-4fce7d3e0ffb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "65c04f34-880d-4a94-8c6f-5739b67329e7", "cda4fe64-aa7a-4b66-ae70-412ca0a56a31" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c5a1a0-7bb0-41b1-bf28-1ef4aba1d59d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e94df2c-85d1-49f5-b4be-492a9d20d5d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65c04f34-880d-4a94-8c6f-5739b67329e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0eaec538-2460-443a-b05e-98c298f97fb5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e2a18cc-246e-45e6-9780-4fce7d3e0ffb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cda4fe64-aa7a-4b66-ae70-412ca0a56a31");

            migrationBuilder.AlterColumn<string>(
                name: "ProofPicture",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatePayment",
                table: "Transactions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ProofPicture",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatePayment",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "e6eaf8b8-7754-4c2c-af6c-543577e9efbb", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40c5a1a0-7bb0-41b1-bf28-1ef4aba1d59d", null, "Admin", "ADMIN" },
                    { "5e94df2c-85d1-49f5-b4be-492a9d20d5d5", null, "User", "USER" },
                    { "65c04f34-880d-4a94-8c6f-5739b67329e7", null, "Partner", "PARTNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "Iban", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "0eaec538-2460-443a-b05e-98c298f97fb5", 0, null, null, null, "45cde8ed-d6cb-41c8-ae22-a4a67cf5e127", null, new DateTime(2023, 6, 15, 15, 40, 3, 638, DateTimeKind.Local).AddTicks(8213), "admin@admin.com", false, "Admin", null, true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGhfaagHThzng2V4QLctBZ6iqIFYz9KP1JAFzQVQZtmWpsRLhYEN1u97b7U6S/lpIg==", null, false, null, "ea39b024-5fbe-4ee1-852f-e1c8ce93361e", "Masculino", null, false, "admin@admin.com", null },
                    { "9e2a18cc-246e-45e6-9780-4fce7d3e0ffb", 0, null, null, null, "71ce7106-f3b0-4c52-8dcc-66c626cca5f4", null, new DateTime(2023, 6, 15, 15, 40, 3, 579, DateTimeKind.Local).AddTicks(3258), "user@user.com", false, "User", null, true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEIBZRC0I4Jvl1Kw84rIZ0uHlaW8a6NVxtWU8wOD3FSfunN4roJpEDkMco4Yv5Rx7BQ==", null, false, null, "d833a574-b575-4237-935f-817ec3da489e", "Masculino", null, false, "user@user.com", null },
                    { "cda4fe64-aa7a-4b66-ae70-412ca0a56a31", 0, null, null, null, "75988732-97c6-49c3-bef8-3cb4e0dc75d1", null, new DateTime(2023, 6, 15, 15, 40, 3, 698, DateTimeKind.Local).AddTicks(2397), "partner@partner.com", false, "Partner", null, true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEKVLoAKkT187kUma6GN6a6A7VWbPBlYVSqzAsprEGBRyOx7HxI6itsjnYYNEXL7ADg==", null, false, null, "320023a3-9221-4362-9915-43ab6461c7ab", "Feminino", null, false, "partner@partner.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "5f092aac-a75f-4ac8-8854-b23d408b3a1a", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "9e2a18cc-246e-45e6-9780-4fce7d3e0ffb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "40c5a1a0-7bb0-41b1-bf28-1ef4aba1d59d", "0eaec538-2460-443a-b05e-98c298f97fb5" },
                    { "5e94df2c-85d1-49f5-b4be-492a9d20d5d5", "9e2a18cc-246e-45e6-9780-4fce7d3e0ffb" },
                    { "65c04f34-880d-4a94-8c6f-5739b67329e7", "cda4fe64-aa7a-4b66-ae70-412ca0a56a31" }
                });
        }
    }
}
