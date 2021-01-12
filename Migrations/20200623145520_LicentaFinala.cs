using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class LicentaFinala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24bd563f-4fb3-4989-a3a1-aaea284da1ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "516acee1-cad0-464d-9c5a-3fb2c5c997e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f065d9d2-08b2-4c20-be50-2b1a7288803e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa1b323e-5442-464c-93e2-e78c3c50fb9b", "dc1fe7fd-13c0-484d-927d-1280089c118d", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88add2cc-65a4-453d-88c6-6816ff8c80c8", "e225872e-da78-4135-9fcc-878c8c1c4694", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f804c85-9d65-473e-b6c5-42e0e848c04f", "6cfa58c9-d9a2-4d62-bfd1-422656cd22c2", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88add2cc-65a4-453d-88c6-6816ff8c80c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f804c85-9d65-473e-b6c5-42e0e848c04f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa1b323e-5442-464c-93e2-e78c3c50fb9b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f065d9d2-08b2-4c20-be50-2b1a7288803e", "696d68ca-742d-4edf-9e95-9108717a4786", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "516acee1-cad0-464d-9c5a-3fb2c5c997e6", "e3be28c2-e565-45c5-9971-98652594e265", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24bd563f-4fb3-4989-a3a1-aaea284da1ea", "713a6f0e-f781-44cf-b74e-cb8da0d123e0", "Administrator", "ADMINISTRATOR" });
        }
    }
}
