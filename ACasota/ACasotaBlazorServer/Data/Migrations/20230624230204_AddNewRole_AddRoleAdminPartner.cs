using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewRole_AddRoleAdminPartner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "7c90572a-870a-4f2b-a7de-12fa44b0a935", "Junior", null, null, false, false, "Mino", "Cat", "Male", "Little", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34c9b3a6-9be5-4c95-a3e8-c75b5cf44420", null, "Admin", "ADMIN" },
                    { "90a17e92-cacb-4144-8292-deed8facc6fe", null, "Partner", "PARTNER" },
                    { "c9c2fb7a-1b9d-4a57-acad-85e073359528", null, "User", "USER" },
                    { "d54fee8d-d91b-402a-b3c2-06491bf29790", null, "AdminPartner", "ADMINPARTNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "Iban", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "1715e8dc-bdd0-48ac-9c0f-a06bdc3e4b54", 0, null, null, null, "ce682297-ef59-4051-b2f9-0505c32932aa", null, new DateTime(2023, 6, 25, 0, 2, 3, 730, DateTimeKind.Local).AddTicks(1768), "user@user.com", false, "User", null, true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEEPX+TOr1IUWSK79r2KTVOqKGGGdEiZJCT0GiFEeT7e6/pqS42k9f2xfDM2ZSCcFjQ==", null, false, null, "e89d39f1-bf02-4d2c-8cc0-8d380ad4a039", "Masculino", null, false, "user@user.com", null },
                    { "1844551c-d57e-4943-a1c0-bddc23ad45d1", 0, null, null, null, "83f2e83e-a68f-40f3-82d5-3882ccb18b36", null, new DateTime(2023, 6, 25, 0, 2, 3, 910, DateTimeKind.Local).AddTicks(1663), "adminpartner@adminpartner.com", false, "AdminPartner", null, true, "AdminPartner", false, null, null, "ADMINPARTNER@ADMINPARTNER.COM", "ADMINPARTNER@ADMINPARTNER.COM", "AQAAAAIAAYagAAAAEBDO6ISSrWy+GzGqvpq4sJz8DDxyBgEYtutwkCc6s+2RdPwFCMSIgiixf4ZFE6knLg==", null, false, null, "1164a807-c700-4f28-b438-51b31ae79d35", "Feminino", null, false, "adminpartner@adminpartner.com", null },
                    { "4fa668a9-1e1b-4c35-bd07-a0bdbc2f7b9d", 0, null, null, null, "444bee3d-9c7e-4d7f-8596-134f9c161f8a", null, new DateTime(2023, 6, 25, 0, 2, 3, 790, DateTimeKind.Local).AddTicks(2925), "admin@admin.com", false, "Admin", null, true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEA2b5U1zih1BoZrFgajgupd4Rc7+8IT8yimu4rz8bn1JYtA1CIGW2rpzMuzhML/Wkw==", null, false, null, "98d0a7de-0cab-494f-b64f-e8666a39c19d", "Masculino", null, false, "admin@admin.com", null },
                    { "ebd8c882-ea30-4b05-93c8-ba0bf1c036f1", 0, null, null, null, "38680863-e913-481a-9eb9-6ca7064a6f8a", null, new DateTime(2023, 6, 25, 0, 2, 3, 850, DateTimeKind.Local).AddTicks(5612), "partner@partner.com", false, "Partner", null, true, "Partner", false, null, null, "PARTNER@PARTNER.COM", "PARTNER@PARTNER.COM", "AQAAAAIAAYagAAAAEJP/69FeEytJIHKcSGK8KOHca/IWtLyDz9xs6Y0CZ+CQeLPGg7RTUjIB3r7q2rrgaw==", null, false, null, "cee8ec1d-64f2-446f-b81a-85512383bd32", "Feminino", null, false, "partner@partner.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "054932fb-8d1b-42f3-8153-d3bfbaa49da9", "Baby", null, null, false, false, "Lucas", "Cat", "Male", "Little", "1715e8dc-bdd0-48ac-9c0f-a06bdc3e4b54" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c9c2fb7a-1b9d-4a57-acad-85e073359528", "1715e8dc-bdd0-48ac-9c0f-a06bdc3e4b54" },
                    { "d54fee8d-d91b-402a-b3c2-06491bf29790", "1844551c-d57e-4943-a1c0-bddc23ad45d1" },
                    { "34c9b3a6-9be5-4c95-a3e8-c75b5cf44420", "4fa668a9-1e1b-4c35-bd07-a0bdbc2f7b9d" },
                    { "90a17e92-cacb-4144-8292-deed8facc6fe", "ebd8c882-ea30-4b05-93c8-ba0bf1c036f1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "054932fb-8d1b-42f3-8153-d3bfbaa49da9");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "7c90572a-870a-4f2b-a7de-12fa44b0a935");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9c2fb7a-1b9d-4a57-acad-85e073359528", "1715e8dc-bdd0-48ac-9c0f-a06bdc3e4b54" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d54fee8d-d91b-402a-b3c2-06491bf29790", "1844551c-d57e-4943-a1c0-bddc23ad45d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "34c9b3a6-9be5-4c95-a3e8-c75b5cf44420", "4fa668a9-1e1b-4c35-bd07-a0bdbc2f7b9d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "90a17e92-cacb-4144-8292-deed8facc6fe", "ebd8c882-ea30-4b05-93c8-ba0bf1c036f1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34c9b3a6-9be5-4c95-a3e8-c75b5cf44420");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90a17e92-cacb-4144-8292-deed8facc6fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9c2fb7a-1b9d-4a57-acad-85e073359528");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d54fee8d-d91b-402a-b3c2-06491bf29790");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1715e8dc-bdd0-48ac-9c0f-a06bdc3e4b54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1844551c-d57e-4943-a1c0-bddc23ad45d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fa668a9-1e1b-4c35-bd07-a0bdbc2f7b9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebd8c882-ea30-4b05-93c8-ba0bf1c036f1");

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
    }
}
