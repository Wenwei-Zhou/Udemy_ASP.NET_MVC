using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyMvcApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataDairyEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Joe!", new DateTime(2025, 4, 22, 15, 37, 58, 537, DateTimeKind.Local).AddTicks(3530), "Went Hiking" },
                    { 2, "Went shopping with Joe!", new DateTime(2025, 4, 22, 15, 37, 58, 537, DateTimeKind.Local).AddTicks(3670), "Went shopping" },
                    { 3, "Went swim with Joe!", new DateTime(2025, 4, 22, 15, 37, 58, 537, DateTimeKind.Local).AddTicks(3670), "Went swim" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
