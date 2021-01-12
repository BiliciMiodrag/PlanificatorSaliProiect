using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class Hope2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "371b3091-2534-4729-b89c-770a8c15dc23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74efd8c7-ca3f-457f-b40d-aaff364037e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a817f9f-ec47-4094-8f16-af120b65f759");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "Events",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "End",
                table: "Events",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a698345a-05fc-47f1-9c44-ca54e05d62f5", "7b6d6063-5eab-4bf3-beca-09ab303f91fc", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "291c2440-42e7-4169-88e6-ea3536ee415b", "a4bd814e-7836-4ef5-87d6-07ba2d4e5583", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d716dced-e918-446f-a2b4-265b4f1d58da", "0aa39502-ca6e-4371-a349-96583f6c71c9", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "291c2440-42e7-4169-88e6-ea3536ee415b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a698345a-05fc-47f1-9c44-ca54e05d62f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d716dced-e918-446f-a2b4-265b4f1d58da");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "Events",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "End",
                table: "Events",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a817f9f-ec47-4094-8f16-af120b65f759", "665c2e42-ae47-40f3-9774-64f63ad96d1f", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "371b3091-2534-4729-b89c-770a8c15dc23", "18d99565-0fd7-49e5-9089-82504046a873", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74efd8c7-ca3f-457f-b40d-aaff364037e0", "0bf0d743-87a1-41f1-9520-83a0edad75d2", "Administrator", "ADMINISTRATOR" });
        }
    }
}
