using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemberQfit.Services.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedAuthData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateOnly(2024, 5, 13));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateOnly(2024, 5, 13));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinDate",
                value: new DateOnly(2024, 5, 13));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateOnly(2024, 5, 11));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateOnly(2024, 5, 11));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinDate",
                value: new DateOnly(2024, 5, 11));
        }
    }
}
