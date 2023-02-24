using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedAnimalandAnimalUserConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f165e8e4-70ea-400c-a342-b18a8035c950", "9efdf132-a705-4d3a-94f4-eb965af95d12" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50f313f4-b6c4-4c73-ba85-3b3d525fba49", "ebbe3251-5b7a-4a7d-a2a7-2904e86f1f8b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50f313f4-b6c4-4c73-ba85-3b3d525fba49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f165e8e4-70ea-400c-a342-b18a8035c950");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9efdf132-a705-4d3a-94f4-eb965af95d12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebbe3251-5b7a-4a7d-a2a7-2904e86f1f8b");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "150e4fbd-9266-43c6-ab39-547d75c1af8e", null, "User", "USER" },
                    { "360a0369-8123-449c-bbd8-c7f644f52f9f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "ConcurrencyStamp", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6714c7d5-8175-4c92-bf93-3cd6382a361f", 0, null, null, "366fb889-5288-4ffe-885e-30a7cafd1e52", new DateTime(2023, 2, 22, 10, 53, 20, 457, DateTimeKind.Local).AddTicks(6678), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEJlfpGEtIHqeMx0JNNngRgZrWQd06ILqOIq1IlPX0ty2aPhzK3d+qcEuuWRezTxBUQ==", null, false, "9f5dea03-362e-4aeb-8103-821f0694bb44", false, "user@user.com" },
                    { "d3bf8588-da58-45c7-b69f-106ec9a72a2f", 0, null, null, "b8a1ffe6-5df8-4581-8fe4-90e39b954db3", new DateTime(2023, 2, 22, 10, 53, 20, 543, DateTimeKind.Local).AddTicks(1790), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENqidqvBmDFhn6Z+lpvSDmg/vozzUEgzPIQy+rm+ZRrG61dScQSEgLinfWGUWpR9Mg==", null, false, "c2c63498-a85d-4842-80ba-4dd10f20666d", false, "admin@admin.com" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Colour", "Name", "Race", "UserId" },
                values: new object[] { "041d2ff5-c1fc-4414-9732-2dae308de11b", "2 Months", "Ginger", "Lucas", "Cat", "6714c7d5-8175-4c92-bf93-3cd6382a361f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "150e4fbd-9266-43c6-ab39-547d75c1af8e", "6714c7d5-8175-4c92-bf93-3cd6382a361f" },
                    { "360a0369-8123-449c-bbd8-c7f644f52f9f", "d3bf8588-da58-45c7-b69f-106ec9a72a2f" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_UserId",
                table: "Animals",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "150e4fbd-9266-43c6-ab39-547d75c1af8e", "6714c7d5-8175-4c92-bf93-3cd6382a361f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "360a0369-8123-449c-bbd8-c7f644f52f9f", "d3bf8588-da58-45c7-b69f-106ec9a72a2f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "150e4fbd-9266-43c6-ab39-547d75c1af8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "360a0369-8123-449c-bbd8-c7f644f52f9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6714c7d5-8175-4c92-bf93-3cd6382a361f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3bf8588-da58-45c7-b69f-106ec9a72a2f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50f313f4-b6c4-4c73-ba85-3b3d525fba49", null, "Admin", "ADMIN" },
                    { "f165e8e4-70ea-400c-a342-b18a8035c950", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CCnumber", "ConcurrencyStamp", "Date_Birth", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "Nif", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9efdf132-a705-4d3a-94f4-eb965af95d12", 0, null, null, "242719c2-674e-449c-adb8-0c1284c2fc3f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@user.com", false, "User", true, "User", false, null, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAENUJR0sb8WOA0Gl3hHpiBvuhVozfqAyYJr6jHhQstTFJumaqsYOSfdcC4ocIMYirZg==", null, false, "0724d7d1-8fef-4020-9a2c-5b88bc594410", false, "user@user.com" },
                    { "ebbe3251-5b7a-4a7d-a2a7-2904e86f1f8b", 0, null, null, "88566a85-138b-4f44-8bee-8f77e5ae2721", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", false, "Admin", true, "Admin", false, null, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAECAVeXGwEw+aJ7ToD/5uA72isQd5+AEbexyJeohz/bDc/vmNki7zUF6e9gYX/5XSjw==", null, false, "d07cccd7-49bc-4007-a351-e9cb7a2fa415", false, "admin@admin.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f165e8e4-70ea-400c-a342-b18a8035c950", "9efdf132-a705-4d3a-94f4-eb965af95d12" },
                    { "50f313f4-b6c4-4c73-ba85-3b3d525fba49", "ebbe3251-5b7a-4a7d-a2a7-2904e86f1f8b" }
                });
        }
    }
}
