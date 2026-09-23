using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Finance_app.Migrations
{
    /// <inheritdoc />
    public partial class FixRoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "417ba214-97ff-4fee-9c5b-798e683983a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d897bdee-0cd9-43cc-b980-ca43bc425fc3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "Admin-Role-1234", "b5383bd7-94c8-45a5-816c-8db222e8bc19", "Admin", "ADMIN" },
                    { "User-Role-5678", "9c0fab7c-7aea-41ef-a60e-c5e239cd2549", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin-Role-1234");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "User-Role-5678");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "417ba214-97ff-4fee-9c5b-798e683983a4", "d0190c94-9bed-4989-8955-0d2081b7ded3", "Admin", "ADMIN" },
                    { "d897bdee-0cd9-43cc-b980-ca43bc425fc3", "5d547297-5bb6-4b74-9c6c-6eaa15337869", "User", "USER" }
                });
        }
    }
}
