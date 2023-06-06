using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewTable_AdoptionForm_Constraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "f5f9481d-c33a-4005-8658-43e423713d2b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e80c8f0e-12d9-4cee-a1c1-8ee7b5923ee6", "5789605f-4ce6-43b5-83d1-43efdc13c812" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e43672f0-b4f9-4af2-b967-63cf581773c1", "9af3215a-2cf0-4c78-ad15-7ad51065e80e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e43672f0-b4f9-4af2-b967-63cf581773c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e80c8f0e-12d9-4cee-a1c1-8ee7b5923ee6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5789605f-4ce6-43b5-83d1-43efdc13c812");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9af3215a-2cf0-4c78-ad15-7ad51065e80e");

            migrationBuilder.CreateTable(
                name: "Adoption",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TypeHouse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Typology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasAnimals = table.Column<bool>(type: "bit", nullable: false),
                    ConsentResponsability = table.Column<bool>(type: "bit", nullable: false),
                    AnimalDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdoptionReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnimalId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adoption_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adoption_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "63f35aa1-2566-497a-9f6b-73c6fdbbb238", null, "Admin", "ADMIN" },
                    { "782f986d-f4bc-443c-8c4e-e6eefb67ab5f", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "5f8ee865-d8a8-41c1-baea-4accb0c59034", 0, null, null, null, "a5fabc95-4851-46f3-a4f7-f636ed1c190b", null, new DateTime(2023, 6, 7, 0, 17, 39, 136, DateTimeKind.Local).AddTicks(2240), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEGaANrcun3JaYwqV4FSp5FYVpIoRZo+LGOsjWNRN9LFMw0TN6LZxADolcXluWCWDqQ==", null, false, null, "37baadca-addc-4a7f-9a4e-6d57f999851d", null, false, "user@user.com", null },
                    { "79e159eb-0161-44db-977f-b4d99483d449", 0, null, null, null, "79e4885c-3d09-43a0-87c8-dd2980c65308", null, new DateTime(2023, 6, 7, 0, 17, 39, 201, DateTimeKind.Local).AddTicks(3460), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEOKLOsz5StbG0Os7DmEIXp25YPzkwdaf76nEQVV9Y0McRknwgACsgZ80Tvq7Rz2znA==", null, false, null, "edc89342-57d2-42d2-b534-b0206f22ad6d", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "b1506370-56a5-4c3c-a519-1025d6981dda", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "5f8ee865-d8a8-41c1-baea-4accb0c59034" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "782f986d-f4bc-443c-8c4e-e6eefb67ab5f", "5f8ee865-d8a8-41c1-baea-4accb0c59034" },
                    { "63f35aa1-2566-497a-9f6b-73c6fdbbb238", "79e159eb-0161-44db-977f-b4d99483d449" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adoption_AnimalId",
                table: "Adoption",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Adoption_UserId",
                table: "Adoption",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adoption");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "b1506370-56a5-4c3c-a519-1025d6981dda");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "782f986d-f4bc-443c-8c4e-e6eefb67ab5f", "5f8ee865-d8a8-41c1-baea-4accb0c59034" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63f35aa1-2566-497a-9f6b-73c6fdbbb238", "79e159eb-0161-44db-977f-b4d99483d449" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63f35aa1-2566-497a-9f6b-73c6fdbbb238");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "782f986d-f4bc-443c-8c4e-e6eefb67ab5f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f8ee865-d8a8-41c1-baea-4accb0c59034");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e159eb-0161-44db-977f-b4d99483d449");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e43672f0-b4f9-4af2-b967-63cf581773c1", null, "Admin", "ADMIN" },
                    { "e80c8f0e-12d9-4cee-a1c1-8ee7b5923ee6", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "5789605f-4ce6-43b5-83d1-43efdc13c812", 0, null, null, null, "d602e999-eb27-455a-b2b6-17d9bd7c316a", null, new DateTime(2023, 6, 7, 0, 15, 20, 693, DateTimeKind.Local).AddTicks(9775), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEA+NP451YD93ESmidTbWEiW81NlsU8r00Qt3gUZDAlquQSC3rW9T/dHMSlzi9hURPA==", null, false, null, "4d4f27e9-df1b-499e-9b11-2de3ba0bd027", null, false, "user@user.com", null },
                    { "9af3215a-2cf0-4c78-ad15-7ad51065e80e", 0, null, null, null, "c0613fbe-163e-44c6-b1b1-39bf0b17fdc3", null, new DateTime(2023, 6, 7, 0, 15, 20, 754, DateTimeKind.Local).AddTicks(5743), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEM+IU+i9ZGAKXiggJ56bSm5APR0RwiJIAsU1mi+vrRAmSSaazn+t81K1gxO999YzTQ==", null, false, null, "44ac3665-730f-4cd0-aad1-f13c2f36afa1", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "f5f9481d-c33a-4005-8658-43e423713d2b", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "5789605f-4ce6-43b5-83d1-43efdc13c812" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e80c8f0e-12d9-4cee-a1c1-8ee7b5923ee6", "5789605f-4ce6-43b5-83d1-43efdc13c812" },
                    { "e43672f0-b4f9-4af2-b967-63cf581773c1", "9af3215a-2cf0-4c78-ad15-7ad51065e80e" }
                });
        }
    }
}
