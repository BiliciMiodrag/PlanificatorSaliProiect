using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class CleanData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "263f8f00-ddc9-4270-aab5-980abfae7d85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c3010a2-f98f-4db5-bd25-82ed624a0a51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b00d1546-e89d-4bd4-b3b5-5c0c01da281e");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9c3010a2-f98f-4db5-bd25-82ed624a0a51", "172d8e0f-8efb-49b0-afc2-89f73174bcec", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b00d1546-e89d-4bd4-b3b5-5c0c01da281e", "4e159f8d-c0e1-4234-886a-ee6598b3ae18", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "263f8f00-ddc9-4270-aab5-980abfae7d85", "c3f05e03-b84c-485b-9bb2-fee052c8740b", "Administrator", "ADMINISTRATOR" });
        }
    }
}
