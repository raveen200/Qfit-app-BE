using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MemberQfit.Services.API.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoinDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AboutMe", "Address", "Age", "City", "Email", "FirstName", "Gender", "Height", "Job", "JoinDate", "LastName", "MobileNumber", "NIC", "Status", "Weight" },
                values: new object[,]
                {
                    { 1, null, "No 1, Colombo", null, null, "john@gmail.com", "John", null, null, null, new DateOnly(2024, 5, 11), "Doe", "0786589235", "12789V", 0, null },
                    { 2, null, "No 1, Negombo", null, null, "Luni@gmail.com", "Jane", null, null, null, new DateOnly(2024, 5, 11), "Deo", "0786589235", "125679V", 0, null },
                    { 3, null, "No 1, Dankotuwa", null, null, "Luni@gmail.com", "Sunil", null, null, null, new DateOnly(2024, 5, 11), "Gamage", "0786589235", "991202548V", 0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_NIC",
                table: "Members",
                column: "NIC",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
