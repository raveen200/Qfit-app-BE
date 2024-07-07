using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MembershipQfit.Service.API.Migrations
{
    /// <inheritdoc />
    public partial class s2ik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "MembershipId", "EndDate", "MembershipType", "NIC", "RemainingDays", "StartDate" },
                values: new object[] { 1, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "12789V", 31, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "MembershipId",
                keyValue: 1);
        }
    }
}
