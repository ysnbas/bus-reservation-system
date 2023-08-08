using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace otobusrezervasyonsistemi.Migrations
{
    /// <inheritdoc />
    public partial class UserModelKeepLoggedDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeepLoggedIn",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "KeepLoggedIn",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
