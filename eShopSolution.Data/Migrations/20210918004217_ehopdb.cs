using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ehopdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "be51e874-fa5e-4ce2-a204-adf612d17aab");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d529e794-d5bf-455f-bcee-dd2a3acc7384", "AQAAAAEAACcQAAAAEBg41PI5iD2BpoNlrBsgFMMVickEV7wc8ZIthrl/QgK1YosWtIuFImhcdIEd6rAjNQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 17, 17, 42, 15, 911, DateTimeKind.Local).AddTicks(9811));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a56888f6-f271-455e-9d56-2f485b052d2e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af8df52b-8f47-4f61-ac99-657b97be5fca", "AQAAAAEAACcQAAAAEB+6Ti89K2uk2OgN/vFfQMnudlWCOzPg8tpkFhgf/8aSMxtTkuVUyI/T9WDKzrQ6ow==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 6, 10, 16, 12, 439, DateTimeKind.Local).AddTicks(6051));
        }
    }
}
