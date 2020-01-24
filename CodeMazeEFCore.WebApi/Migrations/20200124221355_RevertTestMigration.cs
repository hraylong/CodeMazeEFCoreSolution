using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeMazeEFCore.Migrations
{
    public partial class RevertTestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Common",
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("1e399e6c-44d1-447d-ab4a-44df81eb0ef9"));

            migrationBuilder.DeleteData(
                schema: "Common",
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("acd782c0-479a-4f51-8142-fa95e7d39dcc"));

            migrationBuilder.DeleteData(
                schema: "Common",
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("c8a1a32c-a936-4036-8a45-72fa1ac3048f"));

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Student",
                columns: new[] { "StudentId", "Age", "LocalCalculation", "Name" },
                values: new object[,]
                {
                    { new Guid("3c20a1fc-4b06-40af-8e6e-2c878b9525bb"), 30, 0, "John Doe" },
                    { new Guid("4a56e9a8-39bb-496a-91e4-bcaf05529c3f"), 25, 0, "Jane Doe" },
                    { new Guid("4a4369ae-c602-43ad-a53c-2c40dfd24e35"), 28, 0, "Mike Miles" },
                    { new Guid("6ef8d6dd-9514-4ee2-bcbd-20ba9d7eec48"), 100, 0, "TEST Name" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Common",
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("3c20a1fc-4b06-40af-8e6e-2c878b9525bb"));

            migrationBuilder.DeleteData(
                schema: "Common",
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("4a4369ae-c602-43ad-a53c-2c40dfd24e35"));

            migrationBuilder.DeleteData(
                schema: "Common",
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("4a56e9a8-39bb-496a-91e4-bcaf05529c3f"));

            migrationBuilder.DeleteData(
                schema: "Common",
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("6ef8d6dd-9514-4ee2-bcbd-20ba9d7eec48"));

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Student",
                columns: new[] { "StudentId", "Age", "LocalCalculation", "Name" },
                values: new object[] { new Guid("acd782c0-479a-4f51-8142-fa95e7d39dcc"), 30, 0, "John Doe" });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Student",
                columns: new[] { "StudentId", "Age", "LocalCalculation", "Name" },
                values: new object[] { new Guid("c8a1a32c-a936-4036-8a45-72fa1ac3048f"), 25, 0, "Jane Doe" });

            migrationBuilder.InsertData(
                schema: "Common",
                table: "Student",
                columns: new[] { "StudentId", "Age", "LocalCalculation", "Name" },
                values: new object[] { new Guid("1e399e6c-44d1-447d-ab4a-44df81eb0ef9"), 28, 0, "Mike Miles" });
        }
    }
}
