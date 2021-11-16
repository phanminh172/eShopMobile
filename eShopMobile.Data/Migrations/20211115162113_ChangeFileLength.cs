using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopMobile.Data.Migrations
{
    public partial class ChangeFileLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f9890c72-7d6f-4610-baff-708751132502");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46c34715-40d6-4159-8861-877d7dd385b9", "AQAAAAEAACcQAAAAEFSOkaMTAsz7pxoT1CfwbV+9aWhk0WsvcWKbh9Z6nBBk+Dl3VK6/11jV25tQCuREBQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 11, 15, 23, 21, 12, 551, DateTimeKind.Local).AddTicks(3826));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e16cccf0-8040-4fbb-b8cf-3a0c9624543a");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d99a912-39b2-4082-9bc3-7647f40ca2e7", "AQAAAAEAACcQAAAAEERpcqjv0Vx8BWxyIyikH4DshPUdtCZa7y+0rhqBV+5ojBlR9rCS3qdt6Y2qfEAjRw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 11, 11, 19, 59, 53, 716, DateTimeKind.Local).AddTicks(5574));
        }
    }
}
