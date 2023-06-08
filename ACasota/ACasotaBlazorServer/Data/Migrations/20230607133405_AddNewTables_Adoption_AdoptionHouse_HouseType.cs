using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTables_Adoption_AdoptionHouse_HouseType : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HouseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdoptionHouses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tipology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionHouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdoptionHouses_HouseTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "HouseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adoptions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasAnimals = table.Column<bool>(type: "bit", nullable: false),
                    ConsentResponsability = table.Column<bool>(type: "bit", nullable: false),
                    AnimalDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdoptionReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnimalId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HouseId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adoptions_AdoptionHouses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "AdoptionHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adoptions_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adoptions_AspNetUsers_UserId",
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
                    { "60fef3ef-cad6-46cc-aab9-0a2835399573", null, "Admin", "ADMIN" },
                    { "90bdd9a0-8cf8-4916-8db0-261361dd2eef", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "05d87726-71ee-4e38-a077-bae15b3845fc", 0, null, null, null, "181f2de8-48b5-47bf-8f61-4b41889f6261", null, new DateTime(2023, 6, 7, 14, 34, 5, 214, DateTimeKind.Local).AddTicks(3451), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGDvwU92XKIAKpkERmsxA+pq0El2oDwjG+tpn7bSxDiJNxAQYu6/zi6YEnh5hb65xA==", null, false, null, "84e76262-2287-494a-b1e9-0627863ec4e8", "Masculino", null, false, "admin@admin.com", null },
                    { "5f84a4d0-378d-4112-a52f-f292f7617573", 0, null, null, null, "b08b3495-ef47-436a-a50d-3b20290165b2", null, new DateTime(2023, 6, 7, 14, 34, 5, 152, DateTimeKind.Local).AddTicks(2660), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEL5qXP7wnrgZ1aFcTOWNvwVYFosGUhcJ6T9QW5COMTc6AUHa5W2D+tfJUouVaKiwuA==", null, false, null, "7c629c33-e5e9-44e2-a190-8644a4092e62", "Masculino", null, false, "user@user.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "b4aad935-6702-4f40-a939-e11c943e0d76", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "5f84a4d0-378d-4112-a52f-f292f7617573" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "60fef3ef-cad6-46cc-aab9-0a2835399573", "05d87726-71ee-4e38-a077-bae15b3845fc" },
                    { "90bdd9a0-8cf8-4916-8db0-261361dd2eef", "5f84a4d0-378d-4112-a52f-f292f7617573" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionHouses_TypeId",
                table: "AdoptionHouses",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_AnimalId",
                table: "Adoptions",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_HouseId",
                table: "Adoptions",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_UserId",
                table: "Adoptions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adoptions");

            migrationBuilder.DropTable(
                name: "AdoptionHouses");

            migrationBuilder.DropTable(
                name: "HouseTypes");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "b4aad935-6702-4f40-a939-e11c943e0d76");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60fef3ef-cad6-46cc-aab9-0a2835399573", "05d87726-71ee-4e38-a077-bae15b3845fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "90bdd9a0-8cf8-4916-8db0-261361dd2eef", "5f84a4d0-378d-4112-a52f-f292f7617573" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60fef3ef-cad6-46cc-aab9-0a2835399573");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90bdd9a0-8cf8-4916-8db0-261361dd2eef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05d87726-71ee-4e38-a077-bae15b3845fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f84a4d0-378d-4112-a52f-f292f7617573");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "AspNetUsers");

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
