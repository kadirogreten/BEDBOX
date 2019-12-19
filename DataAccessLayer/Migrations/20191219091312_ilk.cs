using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Gender",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    FullAdress = table.Column<string>(maxLength: 250, nullable: true),
                    AdressType = table.Column<byte>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    BedBoxUserId = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(maxLength: 18, nullable: true),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    District = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Address_AspNetUsers_BedBoxUserId",
                        column: x => x.BedBoxUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Row = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Box",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedTime = table.Column<DateTime>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PaidPrice = table.Column<decimal>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    BoxType = table.Column<byte>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Box", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Box_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoxImage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 500, nullable: true),
                    BoxID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BoxImage_Box_BoxID",
                        column: x => x.BoxID,
                        principalTable: "Box",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderedTime = table.Column<DateTime>(nullable: false),
                    ErrorMessage = table.Column<string>(maxLength: 250, nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PaidPrice = table.Column<decimal>(nullable: false),
                    TransactionID = table.Column<string>(maxLength: 250, nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    BoxID = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    BedBoxUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_BedBoxUserId",
                        column: x => x.BedBoxUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Box_BoxID",
                        column: x => x.BoxID,
                        principalTable: "Box",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    BoxID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Box_BoxID",
                        column: x => x.BoxID,
                        principalTable: "Box",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_BedBoxUserId",
                table: "Address",
                column: "BedBoxUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Box_CategoryID",
                table: "Box",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_BoxImage_BoxID",
                table: "BoxImage",
                column: "BoxID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BedBoxUserId",
                table: "Order",
                column: "BedBoxUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BoxID",
                table: "Order",
                column: "BoxID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BoxID",
                table: "Product",
                column: "BoxID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "BoxImage");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Box");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");
        }
    }
}
