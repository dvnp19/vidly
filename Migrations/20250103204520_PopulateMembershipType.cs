using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class PopulateMembershipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "MembershipType", columns: new[] { "Id", "SignupFee", "DurationInMonths", "DiscountRate" },
               
                values: new object[,]
                {
                    { 1, 0, 0, 0 },
                    { 2, 10, 3, 10 }
                });
            }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
