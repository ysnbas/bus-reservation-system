using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace otobusrezervasyonsistemi.Migrations
{
    /// <inheritdoc />
    public partial class BusListRoutes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Routesid",
                table: "Buses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Buses_Routesid",
                table: "Buses",
                column: "Routesid");

            migrationBuilder.AddForeignKey(
                name: "FK_Buses_Routes_Routesid",
                table: "Buses",
                column: "Routesid",
                principalTable: "Routes",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buses_Routes_Routesid",
                table: "Buses");

            migrationBuilder.DropIndex(
                name: "IX_Buses_Routesid",
                table: "Buses");

            migrationBuilder.DropColumn(
                name: "Routesid",
                table: "Buses");
        }
    }
}
