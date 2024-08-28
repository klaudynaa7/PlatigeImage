using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatigeImage.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingColumnsToInvoiceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numer",
                table: "Invoice",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "NetAmount",
                table: "Invoice",
                newName: "Vat");

            migrationBuilder.AddColumn<decimal>(
                name: "GrossValue",
                table: "Invoice",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NetValues",
                table: "Invoice",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GrossValue",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "NetValues",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "Vat",
                table: "Invoice",
                newName: "NetAmount");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Invoice",
                newName: "Numer");
        }
    }
}
