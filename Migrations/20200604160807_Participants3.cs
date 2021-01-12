using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class Participants3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Participants",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fde41999-8522-4856-ab51-2826a46a94d5", "6a41a967-4eb6-417c-b678-eb17ee39c7f8", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06ec3690-9ff3-437e-8a91-cfdb6e0f3c97", "416503ad-d522-411c-9c5b-6c63610cbec2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ab19b41-d523-4af4-a373-2ad63e20dcbf", "37e9e878-54d0-4396-aa67-497099eda79c", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_ApplicationUserId",
                table: "Participants",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_AspNetUsers_ApplicationUserId",
                table: "Participants",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Events_EventId",
                table: "Participants",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_AspNetUsers_ApplicationUserId",
                table: "Participants");

            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Events_EventId",
                table: "Participants");

            migrationBuilder.DropIndex(
                name: "IX_Participants_ApplicationUserId",
                table: "Participants");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06ec3690-9ff3-437e-8a91-cfdb6e0f3c97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ab19b41-d523-4af4-a373-2ad63e20dcbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fde41999-8522-4856-ab51-2826a46a94d5");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Participants");

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
    }
}
