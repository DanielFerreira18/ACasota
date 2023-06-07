using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToTable_Adoption_AddNewTable_AdoptionHouse_HouseType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "9b2565e5-7f41-4c3c-a8b7-f3fa41ee8378");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c70ae7f5-11d0-4125-a70a-e40000e8d8d3", "3b65c11b-35f8-4585-ad6e-7411f89ac7f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d3068ad-38df-4f87-ad9b-db69488ac8e0", "cbc6fbae-c633-4569-9ac8-759db91bd52c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d3068ad-38df-4f87-ad9b-db69488ac8e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c70ae7f5-11d0-4125-a70a-e40000e8d8d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b65c11b-35f8-4585-ad6e-7411f89ac7f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbc6fbae-c633-4569-9ac8-759db91bd52c");

            migrationBuilder.DropColumn(
                name: "TypeHouse",
                table: "Adoptions");

            migrationBuilder.DropColumn(
                name: "Typology",
                table: "Adoptions");

            migrationBuilder.AddColumn<string>(
                name: "HouseId",
                table: "Adoptions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "HouseType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdoptionHouse",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tipology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionHouse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdoptionHouse_HouseType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "HouseType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32ac0222-bc3d-4423-bc9f-9afc52484eec", null, "User", "USER" },
                    { "9ca1624b-b1e0-4643-bcef-26eeda94c889", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "73d9cbc3-0d4b-43aa-a01e-44dc506cc5bf", 0, null, null, null, "fae2e7e9-4565-49fe-a29f-a2487e44c717", null, new DateTime(2023, 6, 7, 12, 45, 20, 736, DateTimeKind.Local).AddTicks(5815), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEGIkFgv40inZl0o92ZK1NN0kkTJ+57C1MwD23+vbIXf0GVuIzYXMNJvWZ75JKpD1ag==", null, false, null, "c96152ef-b1ae-4082-9016-40b3dffbd727", "Masculino", null, false, "user@user.com", null },
                    { "997af9c2-0d7b-43af-afab-33aeaca8848a", 0, null, null, null, "240e95b0-75b5-4799-97d9-d35dcc63930f", null, new DateTime(2023, 6, 7, 12, 45, 20, 800, DateTimeKind.Local).AddTicks(2075), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEHthkj59JBdzwmvkwnGAO7Sdk7+Ha0jnEwWnAyB2IvKQqu9z9bzqk8O6Jswm14+EXw==", null, false, null, "7e9bbe12-f746-42eb-9a3f-1c27ebbf36b9", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "d34d237e-f4e9-43f7-a9a9-e809cc528080", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "73d9cbc3-0d4b-43aa-a01e-44dc506cc5bf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "32ac0222-bc3d-4423-bc9f-9afc52484eec", "73d9cbc3-0d4b-43aa-a01e-44dc506cc5bf" },
                    { "9ca1624b-b1e0-4643-bcef-26eeda94c889", "997af9c2-0d7b-43af-afab-33aeaca8848a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_HouseId",
                table: "Adoptions",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionHouse_TypeId",
                table: "AdoptionHouse",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adoptions_AdoptionHouse_HouseId",
                table: "Adoptions",
                column: "HouseId",
                principalTable: "AdoptionHouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adoptions_AdoptionHouse_HouseId",
                table: "Adoptions");

            migrationBuilder.DropTable(
                name: "AdoptionHouse");

            migrationBuilder.DropTable(
                name: "HouseType");

            migrationBuilder.DropIndex(
                name: "IX_Adoptions_HouseId",
                table: "Adoptions");

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: "d34d237e-f4e9-43f7-a9a9-e809cc528080");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32ac0222-bc3d-4423-bc9f-9afc52484eec", "73d9cbc3-0d4b-43aa-a01e-44dc506cc5bf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ca1624b-b1e0-4643-bcef-26eeda94c889", "997af9c2-0d7b-43af-afab-33aeaca8848a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32ac0222-bc3d-4423-bc9f-9afc52484eec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ca1624b-b1e0-4643-bcef-26eeda94c889");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73d9cbc3-0d4b-43aa-a01e-44dc506cc5bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "997af9c2-0d7b-43af-afab-33aeaca8848a");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "Adoptions");

            migrationBuilder.AddColumn<string>(
                name: "TypeHouse",
                table: "Adoptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Typology",
                table: "Adoptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8d3068ad-38df-4f87-ad9b-db69488ac8e0", null, "Admin", "ADMIN" },
                    { "c70ae7f5-11d0-4125-a70a-e40000e8d8d3", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "City", "ConcurrencyStamp", "CoverPic", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "Sex", "Title", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "3b65c11b-35f8-4585-ad6e-7411f89ac7f7", 0, null, null, null, "d5ff069c-a0da-4089-b98d-1b4bebdebb33", null, new DateTime(2023, 6, 7, 0, 27, 17, 561, DateTimeKind.Local).AddTicks(2542), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEMB5oaJDMtC2PD2UL0OretX+HCsDAvNXzu/iYfJU70Qv4ATZBSwBDammsTfSandnFg==", null, false, null, "25471c82-c27f-4d02-9a50-c692f564d07a", "Masculino", null, false, "user@user.com", null },
                    { "cbc6fbae-c633-4569-9ac8-759db91bd52c", 0, null, null, null, "fd2d3cc0-2d8d-4da2-8af1-b640bb855a4c", null, new DateTime(2023, 6, 7, 0, 27, 17, 622, DateTimeKind.Local).AddTicks(1003), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEOVLO71FsLKpBe4W7Y7864iCVvekjv1VM5PZ+AO9RfJR9rUTpaTINCA0465VUKOSxQ==", null, false, null, "498690c6-624d-4953-b5d1-781efb9358aa", "Masculino", null, false, "admin@admin.com", null }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "AnimalPicture", "CoverPicture", "IsSterile", "IsVacinated", "Name", "Race", "Sex", "Size", "UserId" },
                values: new object[] { "9b2565e5-7f41-4c3c-a8b7-f3fa41ee8378", "Baby", null, null, false, false, "Lucas", "Cat", "Masculino", "Pequeno", "3b65c11b-35f8-4585-ad6e-7411f89ac7f7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c70ae7f5-11d0-4125-a70a-e40000e8d8d3", "3b65c11b-35f8-4585-ad6e-7411f89ac7f7" },
                    { "8d3068ad-38df-4f87-ad9b-db69488ac8e0", "cbc6fbae-c633-4569-9ac8-759db91bd52c" }
                });
        }
    }
}
