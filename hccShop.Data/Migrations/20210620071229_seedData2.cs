using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hccShop.Data.Migrations
{
    public partial class seedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en-US");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 14, 12, 28, 572, DateTimeKind.Local).AddTicks(33),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 20, 14, 0, 53, 528, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder", "Status" },
                values: new object[] { 3, true, null, 3, 1 });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SeoAlias" },
                values: new object[] { "Điện thoại", "dien-thoai" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "LanguageId", "Name", "SeoAlias" },
                values: new object[] { 2, "vi-VN", "Laptop", "laptop" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias" },
                values: new object[] { "Điện thoại Bphone 3", "Điện thoại Bphone 3", "Điện thoại Bphone 3", "dien-thoai-bphone3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 20, 14, 12, 28, 588, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Name", "SeoAlias" },
                values: new object[] { 3, "Camera", "camera" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 14, 0, 53, 528, DateTimeKind.Local).AddTicks(5237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 20, 14, 12, 28, 572, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SeoAlias" },
                values: new object[] { "Áo nam", "ao-nam" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Name", "SeoAlias" },
                values: new object[] { 2, "Áo nữ", "ao-nu" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[] { "en-US", false, "English" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias" },
                values: new object[] { "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "ao-so-mi-nam-trang-viet-tien" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 20, 14, 0, 53, 545, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "LanguageId", "Name", "SeoAlias" },
                values: new object[] { 1, "en-US", "Men Shirt", "men-shirt" });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias" },
                values: new object[] { 4, 2, "en-US", "Women Shirt", "women-shirt" });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias" },
                values: new object[] { 2, "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "en-US", "Viet Tien Men T-Shirt", 1, "viet-tien-men-t-shirt" });
        }
    }
}
