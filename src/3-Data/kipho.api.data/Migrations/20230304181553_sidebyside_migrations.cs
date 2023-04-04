using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kipho.api.data.Migrations
{
    /// <inheritdoc />
    public partial class sidebysidemigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "active",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "barcodeNumber",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "active",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "barcodeNumber",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Products");
        }
    }
}
