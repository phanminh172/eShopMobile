using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopMobile.Data.Migrations
{
    public partial class fixCharacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDefauft",
                table: "ProductImages",
                newName: "IsDefault");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "92d83c9f-c539-430c-8aa5-e82676175bbc");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91bfcb32-06d0-4295-b016-3eef7e7937b8", "AQAAAAEAACcQAAAAENUuW0NOBYUvgSVdSZNQCPpCf7tFz822u0jj/ExQL1YMsKjC3tCFxhg8xzo4q02jwg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 16, 0, 42, 13, 277, DateTimeKind.Local).AddTicks(8280));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDefault",
                table: "ProductImages",
                newName: "IsDefauft");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9214a296-62ae-4152-aea9-2b239c9778eb");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "638fff8c-79f3-4b25-8f0f-310f710d120c", "AQAAAAEAACcQAAAAEBwhO87XX4uhprl7aFuYmxZKWGCv1+3Qzj6m5X7BRaj4nKccQH/8m8MoHw3QyesHoQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 14, 15, 34, 38, 461, DateTimeKind.Local).AddTicks(7812));
        }
    }
}
