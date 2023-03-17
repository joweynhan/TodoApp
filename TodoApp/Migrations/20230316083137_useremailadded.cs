using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class useremailadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2003, 3, 16, 16, 31, 37, 787, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2023, 3, 17, 16, 31, 37, 787, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "DueDate" },
                values: new object[] { "In Jump Training", new DateTime(2023, 3, 18, 16, 31, 37, 787, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DueDate" },
                values: new object[] { "In Jump Training", new DateTime(2023, 3, 18, 16, 31, 37, 787, DateTimeKind.Local).AddTicks(6303) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "People");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2003, 3, 16, 12, 38, 34, 116, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2023, 3, 17, 12, 38, 34, 116, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "DueDate" },
                values: new object[] { "In Jump Trainin", new DateTime(2023, 3, 18, 12, 38, 34, 116, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DueDate" },
                values: new object[] { "In Jump Trainin", new DateTime(2023, 3, 18, 12, 38, 34, 116, DateTimeKind.Local).AddTicks(7657) });
        }
    }
}
