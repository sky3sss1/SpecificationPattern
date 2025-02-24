using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastraction.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, comment: "Идентификатор"),
                    Name = table.Column<string>(type: "text", nullable: false, comment: "Название статуса"),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, comment: "Удален ли статус"),
                    CreateData = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Дата создания"),
                    UpdateData = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Дата обновления")
                },
                constraints: table =>
                {
                    table.PrimaryKey("Status_pkey", x => x.Id);
                },
                comment: "Статусы заказов");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, comment: "Идентификатор"),
                    Name = table.Column<string>(type: "text", nullable: false, comment: "Имя пользователя"),
                    Email = table.Column<string>(type: "text", nullable: false, comment: "Почта пользователя"),
                    CreateData = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Дата создания"),
                    UpdateData = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Дата обновления")
                },
                constraints: table =>
                {
                    table.PrimaryKey("User_pkey", x => x.Id);
                },
                comment: "Статусы заказов");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, comment: "Идентификатор"),
                    OrderNumber = table.Column<int>(type: "integer", nullable: false, comment: "Номер заказа"),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false, comment: "Id пользователя"),
                    StatusId = table.Column<Guid>(type: "uuid", nullable: false, comment: "Id статуса"),
                    CreateData = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Дата создания"),
                    UpdateData = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Дата обновления")
                },
                constraints: table =>
                {
                    table.PrimaryKey("Order_pkey", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Status",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_User",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Заказы пользователя");

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, comment: "Идентификатор"),
                    RowNumber = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false, comment: "Id заказа"),
                    CreateData = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Дата создания"),
                    UpdateData = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Дата обновления")
                },
                constraints: table =>
                {
                    table.PrimaryKey("OrderItem_pkey", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Товары в заказе");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
