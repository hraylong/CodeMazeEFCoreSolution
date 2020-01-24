using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeMazeEFCore.Migrations
{
    public partial class AdditionsRowInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "idxName",
                table: "Student");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("1cb6e96a-2c61-4b37-8912-a847de070876"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("99d880fb-8146-41c9-be2f-0cec24a7ded9"));

            migrationBuilder.EnsureSchema(
                name: "Common");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Student",
                newSchema: "Common");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Common",
                table: "Student",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "LocalCalculation",
                schema: "Common",
                table: "Student",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "LocalCalculation",
                schema: "Common",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Student",
                schema: "Common",
                newName: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Student",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("1cb6e96a-2c61-4b37-8912-a847de070876"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("99d880fb-8146-41c9-be2f-0cec24a7ded9"), 25, "Jane Doe" });

            migrationBuilder.CreateIndex(
                name: "idxName",
                table: "Student",
                column: "Name");
        }
    }
}
