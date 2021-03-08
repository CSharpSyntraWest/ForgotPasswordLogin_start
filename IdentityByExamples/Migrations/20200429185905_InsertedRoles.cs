using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityByExamples.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a18633c9-8cac-4bd7-9325-e55b7bb93f50", "90c48159-0f5d-456a-be6b-5ffa1ded204b", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e46c0dce-86ee-4dd1-a6df-72e44132c20c", "e656db24-0b31-4178-88da-08c73b7f19df", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("398d10fe-4b8d-4606-8e9c-bd2c78d4e001"),
                column: "Name",
                value: "Jos De Klos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18633c9-8cac-4bd7-9325-e55b7bb93f50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46c0dce-86ee-4dd1-a6df-72e44132c20c");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("398d10fe-4b8d-4606-8e9c-bd2c78d4e001"),
                column: "Name",
                value: "Anna Simmons");
        }
    }
}
