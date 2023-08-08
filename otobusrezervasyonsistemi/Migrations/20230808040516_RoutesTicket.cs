using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace otobusrezervasyonsistemi.Migrations
{
    /// <inheritdoc />
    public partial class RoutesTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ticket",
                table: "Routes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ticket",
                table: "Routes");
        }
    }
}
