using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e88beea-087c-4277-a741-159c051ff4c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7a098be-f251-4afd-9518-51ebfb1d0891");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fee4b5bf-00f7-4de5-a35d-742c187f6001");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e298393-aee2-4315-b62d-647889937a0d", "131b14a5-5952-442f-88c6-6e7d6553279b", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e64eb99-535c-46ec-ad09-95e5b9d99415", "a592fa90-1556-4ae3-abeb-a5ac8caa7e10", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b26a941a-1517-4b50-99e4-ce5bf897194a", "aa00506a-232d-4c9f-9ca1-5718f4b12075", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e64eb99-535c-46ec-ad09-95e5b9d99415");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e298393-aee2-4315-b62d-647889937a0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b26a941a-1517-4b50-99e4-ce5bf897194a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7a098be-f251-4afd-9518-51ebfb1d0891", "6b55d8a8-6060-4044-8826-53f095a9861e", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e88beea-087c-4277-a741-159c051ff4c6", "9989798c-bbd8-4e66-9f84-90d5d2a5e9af", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fee4b5bf-00f7-4de5-a35d-742c187f6001", "29629a1b-567d-426d-8b35-89d9b97d6ce2", "Administrator", "ADMINISTRATOR" });
        }
    }
}
