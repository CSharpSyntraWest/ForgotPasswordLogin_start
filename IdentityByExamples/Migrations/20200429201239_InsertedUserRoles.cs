using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityByExamples.Migrations
{
    public partial class InsertedUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18633c9-8cac-4bd7-9325-e55b7bb93f50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46c0dce-86ee-4dd1-a6df-72e44132c20c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2abc271d-be1c-42c7-8272-a61ce3e98d3c", "04b77562-30e4-4f43-b843-f5b2ae499a97", "Visitor", "VISITOR" },
                    { "23aa6c9c-3f05-4191-afa3-a424caab9355", "984814ea-d776-4084-ae30-3484f705d407", "Admin", "ADMIN" },
                    { "cb772c5d-d6dc-4473-8ded-94cf2c519800", "d9afd1dd-8daa-4ab7-933d-24ae62cabcdf", "administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a127a5b0-8d33-4b11-9543-6e3d61baf594", 0, "bcfcbe64-1179-49e9-b587-47605140976f", "admin@x.com", true, false, null, "ADMIN@X.COM", "ADMIN@X.COM", "AQAAAAEAACcQAAAAEJQJOAe4Z6Oft08PZYp158G9aZ6/H08FT6BvCCcmTwahxWkLPyCrszlKdnBr0v1k0w==", null, false, "", false, "admin@x.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a127a5b0-8d33-4b11-9543-6e3d61baf594", "cb772c5d-d6dc-4473-8ded-94cf2c519800" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23aa6c9c-3f05-4191-afa3-a424caab9355");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2abc271d-be1c-42c7-8272-a61ce3e98d3c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a127a5b0-8d33-4b11-9543-6e3d61baf594", "cb772c5d-d6dc-4473-8ded-94cf2c519800" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb772c5d-d6dc-4473-8ded-94cf2c519800");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a127a5b0-8d33-4b11-9543-6e3d61baf594");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a18633c9-8cac-4bd7-9325-e55b7bb93f50", "90c48159-0f5d-456a-be6b-5ffa1ded204b", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e46c0dce-86ee-4dd1-a6df-72e44132c20c", "e656db24-0b31-4178-88da-08c73b7f19df", "Admin", "ADMIN" });
        }
    }
}
