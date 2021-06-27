using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hccShop.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 20, 17, 21, 19, 997, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 17, 21, 19, 997, DateTimeKind.Local).AddTicks(614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e4c5f58a-33e5-4f05-8283-6cd2cbbc0a3f"),
                column: "ConcurrencyStamp",
                value: "7f32b395-6f90-4d94-9a75-4a5483669a80");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e3f26d-b4f0-4ef2-ab2c-e90b694c1061"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2653bcb7-6877-496a-9697-3303fcd4665b", "AQAAAAEAACcQAAAAEPsqOce0Qb6PFss8xcl7zRUTNtC/wcl5XUWZQ+g+ZYkEYa79QpgZvSslbTM4anPzQw==" });

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
    }
}
