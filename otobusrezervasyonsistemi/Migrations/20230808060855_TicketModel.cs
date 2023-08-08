using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace otobusrezervasyonsistemi.Migrations
{
    /// <inheritdoc />
    public partial class TicketModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "routeID",
                table: "Tickets",
                newName: "userID");

            migrationBuilder.RenameColumn(
                name: "passengersID",
                table: "Tickets",
                newName: "price");

            migrationBuilder.AddColumn<string>(
                name: "busname",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "kalkis",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "varis",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "busname",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "kalkis",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "varis",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "Tickets",
                newName: "routeID");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Tickets",
                newName: "passengersID");
        }
    }
}
