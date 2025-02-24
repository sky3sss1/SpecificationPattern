using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastraction.Migrations
{
    /// <inheritdoc />
    public partial class fixDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateData",
                table: "Users",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreateData",
                table: "Users",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateData",
                table: "Statuses",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreateData",
                table: "Statuses",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateData",
                table: "Orders",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreateData",
                table: "Orders",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateData",
                table: "OrderItems",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreateData",
                table: "OrderItems",
                newName: "CreateDate");

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc), false, "New", new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc), false, "Delivering", new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc), false, "Canceled", new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc), false, "Delivered", new DateTime(2024, 8, 25, 19, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Users",
                newName: "UpdateData");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Users",
                newName: "CreateData");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Statuses",
                newName: "UpdateData");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Statuses",
                newName: "CreateData");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Orders",
                newName: "UpdateData");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Orders",
                newName: "CreateData");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "OrderItems",
                newName: "UpdateData");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "OrderItems",
                newName: "CreateData");
        }
    }
}
