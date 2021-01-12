using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class Participants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "event_end",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "event_start",
                table: "Events");

            migrationBuilder.AddColumn<DateTime>(
                name: "event_end",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "event_start",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => new { x.EventId, x.UserId });
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

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

            migrationBuilder.DropColumn(
                name: "event_end",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "event_start",
                table: "Events");

            migrationBuilder.AddColumn<DateTime>(
                name: "event_end",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "event_start",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
