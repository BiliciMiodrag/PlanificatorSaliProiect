using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanificatorSali.Migrations
{
    public partial class JSONIgnore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
