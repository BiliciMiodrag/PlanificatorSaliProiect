using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class Participants2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48225caa-fa82-4d13-bb2d-47e37b5fb0d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5999b833-9241-4a5b-b1af-3adfa285182c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "889a27f3-4f57-45f6-8400-bcd9d5f4dc48");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5fbe97e5-82a1-4a5c-94f8-9bd5b7c5f787", "a738b003-1427-41bd-8eec-6506e0380158", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3293b2ba-e11a-4196-ae39-fbe727c68a04", "c7e9f2d0-0c25-40b0-88df-6534086d794c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dac19a93-875b-49b5-ad42-4843c472e978", "494b274d-52c2-4646-bfa2-c05a811584c4", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3293b2ba-e11a-4196-ae39-fbe727c68a04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fbe97e5-82a1-4a5c-94f8-9bd5b7c5f787");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dac19a93-875b-49b5-ad42-4843c472e978");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48225caa-fa82-4d13-bb2d-47e37b5fb0d5", "4883c64f-0d35-4fa2-9707-bcdc7d6b4ba5", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5999b833-9241-4a5b-b1af-3adfa285182c", "1bfab9a5-556f-4e13-a9c5-103a4cd0873a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "889a27f3-4f57-45f6-8400-bcd9d5f4dc48", "df315ba4-4171-4aa9-9b72-a935108261b6", "Administrator", "ADMINISTRATOR" });
        }
    }
}
