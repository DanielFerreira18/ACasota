using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ACasotaBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumTelemovel",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Morada",
                table: "AspNetUsers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Data_Nasc",
                table: "AspNetUsers",
                newName: "Date_Birth");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date_Birth",
                table: "AspNetUsers",
                newName: "Data_Nasc");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "AspNetUsers",
                newName: "Morada");

            migrationBuilder.AddColumn<int>(
                name: "NumTelemovel",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
