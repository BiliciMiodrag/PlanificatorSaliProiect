using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class LicentaFinala2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88add2cc-65a4-453d-88c6-6816ff8c80c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f804c85-9d65-473e-b6c5-42e0e848c04f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa1b323e-5442-464c-93e2-e78c3c50fb9b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b1e87a4e-c8ff-41fd-bce4-a789de4c932f", "9484c482-7822-45c0-be99-9feb8fabba55", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3516449-9c86-4611-b343-8a86393b3ab8", "ff3659d1-bed4-472f-887d-fbeeeffbb379", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0bfcb263-3fd9-4b0b-a218-957aaa2950ab", "f097d2ca-ec00-420a-bd26-47778b31866f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bfcb263-3fd9-4b0b-a218-957aaa2950ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1e87a4e-c8ff-41fd-bce4-a789de4c932f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3516449-9c86-4611-b343-8a86393b3ab8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa1b323e-5442-464c-93e2-e78c3c50fb9b", "dc1fe7fd-13c0-484d-927d-1280089c118d", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88add2cc-65a4-453d-88c6-6816ff8c80c8", "e225872e-da78-4135-9fcc-878c8c1c4694", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f804c85-9d65-473e-b6c5-42e0e848c04f", "6cfa58c9-d9a2-4d62-bfd1-422656cd22c2", "Administrator", "ADMINISTRATOR" });
        }
    }
}
