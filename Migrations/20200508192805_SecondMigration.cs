using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05d98f39-db2c-42e7-a83e-dca098947e95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f124f35-ad07-4b28-8311-24268431b378");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60ed85c4-a752-452e-a022-68160bb5db32");

            migrationBuilder.AddColumn<bool>(
                name: "AllDay",
                table: "Evenimente",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AllDay",
                table: "Evenimente");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60ed85c4-a752-452e-a022-68160bb5db32", "2c8c8768-54d9-40b6-8c13-d58441b53f9d", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05d98f39-db2c-42e7-a83e-dca098947e95", "dd935a58-7599-4faa-94aa-32a2351daf02", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f124f35-ad07-4b28-8311-24268431b378", "a4e10d77-76df-4132-8c3b-969f5f098224", "Administrator", "ADMINISTRATOR" });
        }
    }
}
