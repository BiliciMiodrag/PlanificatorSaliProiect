using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class WithoutGet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "start_data",
                table: "Evenimente",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "sfarsit_data",
                table: "Evenimente",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1fd64e22-3863-4d34-b8a9-0c98e7db5c3c", "a955ec0f-9805-49fc-afca-152ace490870", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5128447c-3767-4d42-9f5c-8c3345b7cd49", "b9b32c8d-1905-46c2-ac11-86ec77ef1106", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c7c4225-cb6b-4699-b9d0-a307d740b8a3", "f4c8d85d-4369-45dc-be9a-d54ce37282ae", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fd64e22-3863-4d34-b8a9-0c98e7db5c3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5128447c-3767-4d42-9f5c-8c3345b7cd49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c7c4225-cb6b-4699-b9d0-a307d740b8a3");

            migrationBuilder.AlterColumn<DateTime>(
                name: "start_data",
                table: "Evenimente",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "sfarsit_data",
                table: "Evenimente",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
