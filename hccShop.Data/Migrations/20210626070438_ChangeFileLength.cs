using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hccShop.Data.Migrations
{
    public partial class ChangeFileLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e4c5f58a-33e5-4f05-8283-6cd2cbbc0a3f"),
                column: "ConcurrencyStamp",
                value: "c394e6fe-7e7f-4119-9b56-dcbd31193c99");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e3f26d-b4f0-4ef2-ab2c-e90b694c1061"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30547e3b-f5b3-48dd-9c37-d85aac7c6c11", "AQAAAAEAACcQAAAAEBJbUsoBuGXfKP6ay/vHeVr1COxPLD+YXzux16a+6hAPSwZUCOMuxgGkZqvseGpXoA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 26, 14, 4, 37, 877, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 26, 14, 4, 37, 878, DateTimeKind.Local).AddTicks(6974));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
