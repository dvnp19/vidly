using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class NameToMembershipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MembershipType",
                type: "text",
                nullable: false,
                defaultValue: "");
            migrationBuilder.UpdateData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pay as You Go");
            migrationBuilder.UpdateData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Monthly");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MembershipType");
        }
    }
}
