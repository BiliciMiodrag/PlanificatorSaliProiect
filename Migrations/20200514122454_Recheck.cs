using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class Recheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "172530b9-824c-46dc-bdee-c2efe5f58e9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1124246-4d41-4529-8981-fa865a8128a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c663c183-a0be-4452-9f7e-ed34181d5ace");

            migrationBuilder.DropColumn(
                name: "participanti",
                table: "Evenimente");

            migrationBuilder.AlterColumn<DateTime>(
                name: "start_data",
                table: "Evenimente",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "sfarsit_data",
                table: "Evenimente",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04d84942-a897-4b5a-bd70-d73b4fba44a3", "46c84953-5060-45c5-b71f-0d3af64bb2ee", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe86426c-9250-40de-af5b-6ce7a8b65c97", "dbe2efd0-6ab8-4e71-9a9f-1d603fc4c0b4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84e04210-af0e-49e8-92c4-12e2541abc40", "87f34672-9df2-49da-9c6d-e4ac0d68b375", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04d84942-a897-4b5a-bd70-d73b4fba44a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84e04210-af0e-49e8-92c4-12e2541abc40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe86426c-9250-40de-af5b-6ce7a8b65c97");

            migrationBuilder.AlterColumn<string>(
                name: "start_data",
                table: "Evenimente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "sfarsit_data",
                table: "Evenimente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "participanti",
                table: "Evenimente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c1124246-4d41-4529-8981-fa865a8128a1", "17b73b39-928d-4aac-91ac-c600196a9640", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "172530b9-824c-46dc-bdee-c2efe5f58e9f", "12b1bb78-777f-4027-97b3-6fbc16d6b92d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c663c183-a0be-4452-9f7e-ed34181d5ace", "d6b5bef5-770f-430d-9d42-5d02f3ccf01a", "Administrator", "ADMINISTRATOR" });
        }
    }
}
