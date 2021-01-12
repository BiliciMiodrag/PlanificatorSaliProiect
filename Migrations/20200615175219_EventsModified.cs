using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class EventsModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Denumire",
                table: "Sala",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "participanti",
                table: "Events",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "participanti",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "Denumire",
                table: "Sala",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

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
        }
    }
}
