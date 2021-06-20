using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hccShop.Data.Migrations
{
    public partial class seedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 17, 21, 19, 997, DateTimeKind.Local).AddTicks(614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 20, 17, 12, 46, 504, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("e4c5f58a-33e5-4f05-8283-6cd2cbbc0a3f"), "7f32b395-6f90-4d94-9a75-4a5483669a80", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e4c5f58a-33e5-4f05-8283-6cd2cbbc0a3f"), new Guid("f3e3f26d-b4f0-4ef2-ab2c-e90b694c1061") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f3e3f26d-b4f0-4ef2-ab2c-e90b694c1061"), 0, "2653bcb7-6877-496a-9697-3303fcd4665b", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "hccShop@gmail.com", true, "Chien", "Le", false, null, "hccShop@gmail.com", "admin", "AQAAAAEAACcQAAAAEPsqOce0Qb6PFss8xcl7zRUTNtC/wcl5XUWZQ+g+ZYkEYa79QpgZvSslbTM4anPzQw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 20, 17, 21, 20, 33, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 20, 17, 21, 20, 34, DateTimeKind.Local).AddTicks(246));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e4c5f58a-33e5-4f05-8283-6cd2cbbc0a3f"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e4c5f58a-33e5-4f05-8283-6cd2cbbc0a3f"), new Guid("f3e3f26d-b4f0-4ef2-ab2c-e90b694c1061") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e3f26d-b4f0-4ef2-ab2c-e90b694c1061"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 17, 12, 46, 504, DateTimeKind.Local).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 20, 17, 21, 19, 997, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 20, 17, 12, 46, 521, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 20, 17, 12, 46, 521, DateTimeKind.Local).AddTicks(1555));
        }
    }
}
