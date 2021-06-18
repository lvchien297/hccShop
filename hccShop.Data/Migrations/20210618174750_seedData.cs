using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hccShop.Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 0, 47, 49, 933, DateTimeKind.Local).AddTicks(8371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 18, 23, 52, 8, 986, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page of HccShop" },
                    { "HomeKeyWord", "This is home keyword of HccShop" },
                    { "HomeDescription", "This is home description of HccShop" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "Name", "ParentId", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, "Điện thoại", null, 1, 1 },
                    { 2, true, "Laptop", null, 1, 1 },
                    { 3, true, "Cam", null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "Name", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 6, 19, 0, 47, 49, 946, DateTimeKind.Local).AddTicks(537), "Iphone 5s", 2000000m, 2100000m },
                    { 2, new DateTime(2021, 6, 19, 0, 47, 49, 946, DateTimeKind.Local).AddTicks(1898), "Iphone 6", 1500000m, 2000000m }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyWord");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 18, 23, 52, 8, 986, DateTimeKind.Local).AddTicks(6510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 19, 0, 47, 49, 933, DateTimeKind.Local).AddTicks(8371));
        }
    }
}
