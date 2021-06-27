using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hccShop.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
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
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e4c5f58a-33e5-4f05-8283-6cd2cbbc0a3f"),
                column: "ConcurrencyStamp",
                value: "bd39c732-c19a-4d34-89ac-43b85c8094a3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e3f26d-b4f0-4ef2-ab2c-e90b694c1061"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a769dbdf-08fe-4c90-853f-42514344fe10", "AQAAAAEAACcQAAAAEACFxbUZHvERPVKA1BYS0ZpW3OMLHQA0bEJdkm5EooBleyYgJyrLWmglthkA7X6DyA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 26, 13, 55, 14, 581, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 26, 13, 55, 14, 582, DateTimeKind.Local).AddTicks(4716));
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
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e4c5f58a-33e5-4f05-8283-6cd2cbbc0a3f"),
                column: "ConcurrencyStamp",
                value: "f997363c-62c7-46d4-a85f-93465ff5578d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e3f26d-b4f0-4ef2-ab2c-e90b694c1061"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2aebb5e-5342-44fe-8915-e0ea99ab325f", "AQAAAAEAACcQAAAAEJPOJtgy+9eZIRKzAWNJxCZghMaK3aI6pim6WkPNE1WUkdnkue2JOj7Va7wR28+k3Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 25, 17, 42, 42, 982, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 25, 17, 42, 42, 983, DateTimeKind.Local).AddTicks(5859));
        }
    }
}
