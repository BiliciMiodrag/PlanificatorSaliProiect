using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class Hope : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

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

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Descriere",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Titlu",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "culoare",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "sfarsit_data",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "start_data",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Events",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "End",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Start",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "Events",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "EventId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

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

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "End",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "color",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Descriere",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Titlu",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "culoare",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "sfarsit_data",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "start_data",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "ID");

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
    }
}
