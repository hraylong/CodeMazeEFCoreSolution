using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeMazeEFCore.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("1cb6e96a-2c61-4b37-8912-a847de070876"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("99d880fb-8146-41c9-be2f-0cec24a7ded9"), 25, "Jane Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("1cb6e96a-2c61-4b37-8912-a847de070876"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("99d880fb-8146-41c9-be2f-0cec24a7ded9"));
        }
    }
}
