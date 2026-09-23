using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finance_app.Migrations
{
    /// <inheritdoc />
    public partial class LockRoleStamps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin-Role-1234",
                column: "ConcurrencyStamp",
                value: "1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "User-Role-5678",
                column: "ConcurrencyStamp",
                value: "2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin-Role-1234",
                column: "ConcurrencyStamp",
                value: "b5383bd7-94c8-45a5-816c-8db222e8bc19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "User-Role-5678",
                column: "ConcurrencyStamp",
                value: "9c0fab7c-7aea-41ef-a60e-c5e239cd2549");
        }
    }
}
