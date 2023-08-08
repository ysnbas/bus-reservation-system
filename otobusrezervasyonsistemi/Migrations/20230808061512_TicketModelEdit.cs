using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace otobusrezervasyonsistemi.Migrations
{
    /// <inheritdoc />
    public partial class TicketModelEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "koltukNumarası",
                table: "Tickets",
                newName: "armchairNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "armchairNo",
                table: "Tickets",
                newName: "koltukNumarası");
        }
    }
}
