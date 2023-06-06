using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProprety_AddedSexToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adoption_Animals_AnimalId",
                table: "Adoption");

            migrationBuilder.DropForeignKey(
                name: "FK_Adoption_AspNetUsers_UserId",
                table: "Adoption");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adoption",
                table: "Adoption");

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

            migrationBuilder.RenameTable(
                name: "Adoption",
                newName: "Adoptions");

            migrationBuilder.RenameIndex(
                name: "IX_Adoption_UserId",
                table: "Adoptions",
                newName: "IX_Adoptions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Adoption_AnimalId",
                table: "Adoptions",
                newName: "IX_Adoptions_AnimalId");

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adoptions",
                table: "Adoptions",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Adoptions_Animals_AnimalId",
                table: "Adoptions",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adoptions_AspNetUsers_UserId",
                table: "Adoptions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adoptions_Animals_AnimalId",
                table: "Adoptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Adoptions_AspNetUsers_UserId",
                table: "Adoptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adoptions",
                table: "Adoptions");

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
                name: "Sex",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Adoptions",
                newName: "Adoption");

            migrationBuilder.RenameIndex(
                name: "IX_Adoptions_UserId",
                table: "Adoption",
                newName: "IX_Adoption_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Adoptions_AnimalId",
                table: "Adoption",
                newName: "IX_Adoption_AnimalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adoption",
                table: "Adoption",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Adoption_Animals_AnimalId",
                table: "Adoption",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adoption_AspNetUsers_UserId",
                table: "Adoption",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
