using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MemberQfit.Services.API.Migrations
{
    /// <inheritdoc />
    public partial class addSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AboutMe", "Address", "Age", "City", "Email", "FirstName", "Gender", "Height", "Job", "JoinDate", "LastName", "MobileNumber", "NIC", "Weight" },
                values: new object[,]
                {
                    { 1, null, "No 1, Colombo", null, null, "john@gmail.com", "John", null, null, null, new DateOnly(2024, 5, 10), "Doe", "0786589235", "123456789V", null },
                    { 2, null, "No 1, Negombo", null, null, "Luni@gmail.com", "Jane", null, null, null, new DateOnly(2024, 5, 10), "Deo", "0786589235", "123456789V", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
