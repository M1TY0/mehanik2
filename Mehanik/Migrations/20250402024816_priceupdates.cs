using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mehanik.Migrations
{
    /// <inheritdoc />
    public partial class priceupdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Services",
                newName: "WholePrice");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "History",
                newName: "Service");

            migrationBuilder.RenameColumn(
                name: "Mechanicid",
                table: "History",
                newName: "Mechanic");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "History",
                newName: "Client");

            migrationBuilder.AddColumn<double>(
                name: "PartPrice",
                table: "Services",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ServicesPrice",
                table: "Services",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MechanicPrice",
                table: "History",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PartPrice",
                table: "History",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ServicePrice",
                table: "History",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartPrice",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServicesPrice",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "MechanicPrice",
                table: "History");

            migrationBuilder.DropColumn(
                name: "PartPrice",
                table: "History");

            migrationBuilder.DropColumn(
                name: "ServicePrice",
                table: "History");

            migrationBuilder.RenameColumn(
                name: "WholePrice",
                table: "Services",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Service",
                table: "History",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "Mechanic",
                table: "History",
                newName: "Mechanicid");

            migrationBuilder.RenameColumn(
                name: "Client",
                table: "History",
                newName: "ClientId");
        }
    }
}
