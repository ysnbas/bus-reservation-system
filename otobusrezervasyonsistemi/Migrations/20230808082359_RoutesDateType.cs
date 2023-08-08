using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace otobusrezervasyonsistemi.Migrations
{
    /// <inheritdoc />
    public partial class RoutesDateType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Routes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Routes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
