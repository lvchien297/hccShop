using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hccShop.Data.Migrations
{
    public partial class seedData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 16, 19, 6, 407, DateTimeKind.Local).AddTicks(4820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 20, 14, 12, 28, 572, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias" },
                values: new object[] { 2, "Điện thoại Bphone 2", "Điện thoại Bphone 2", "vi-VN", "Điện thoại Bphone 2", 1, "dien-thoai-bphone2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 20, 16, 19, 6, 424, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "OriginalPrice", "Price" },
                values: new object[] { 2, new DateTime(2021, 6, 20, 16, 19, 6, 424, DateTimeKind.Local).AddTicks(6545), 10000000m, 15000000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 14, 12, 28, 572, DateTimeKind.Local).AddTicks(33),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 20, 16, 19, 6, 407, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 20, 14, 12, 28, 588, DateTimeKind.Local).AddTicks(7618));
        }
    }
}
