using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemberQfit.Services.API.Migrations
{
    /// <inheritdoc />
    public partial class AddDisplayPictureToUserProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "DisplayPicture",
                table: "Members",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DisplayPicture", "JoinDate" },
                values: new object[] { null, new DateOnly(2024, 5, 29) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DisplayPicture", "JoinDate" },
                values: new object[] { null, new DateOnly(2024, 5, 29) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DisplayPicture", "JoinDate" },
                values: new object[] { null, new DateOnly(2024, 5, 29) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayPicture",
                table: "Members");

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
    }
}
