using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemberQfit.Services.API.Migrations
{
    /// <inheritdoc />
    public partial class addSeedData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AboutMe", "Address", "Age", "City", "Email", "FirstName", "Gender", "Height", "Job", "JoinDate", "LastName", "MobileNumber", "NIC", "Weight" },
                values: new object[] { 3, null, "No 1, Dankotuwa", null, null, "Luni@gmail.com", "Sunil", null, null, null, new DateOnly(2024, 5, 10), "Gamage", "0786589235", "991202548V", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
