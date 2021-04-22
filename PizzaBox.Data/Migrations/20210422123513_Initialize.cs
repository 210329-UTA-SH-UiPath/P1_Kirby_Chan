using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crusts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crusts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PresetPizza",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresetPizza", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreID = table.Column<int>(type: "int", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TimePlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "Stores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PresetPizzaTopping",
                columns: table => new
                {
                    PresetPizzasID = table.Column<int>(type: "int", nullable: false),
                    ToppingsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresetPizzaTopping", x => new { x.PresetPizzasID, x.ToppingsID });
                    table.ForeignKey(
                        name: "FK_PresetPizzaTopping_PresetPizza_PresetPizzasID",
                        column: x => x.PresetPizzasID,
                        principalTable: "PresetPizza",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PresetPizzaTopping_Toppings_ToppingsID",
                        column: x => x.ToppingsID,
                        principalTable: "Toppings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresetPizzaID = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    CrustID = table.Column<int>(type: "int", nullable: true),
                    SizeID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pizzas_Crusts_CrustID",
                        column: x => x.CrustID,
                        principalTable: "Crusts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pizzas_PresetPizza_PresetPizzaID",
                        column: x => x.PresetPizzaID,
                        principalTable: "PresetPizza",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PizzaTopping",
                columns: table => new
                {
                    PizzasID = table.Column<int>(type: "int", nullable: false),
                    ToppingsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaTopping", x => new { x.PizzasID, x.ToppingsID });
                    table.ForeignKey(
                        name: "FK_PizzaTopping_Pizzas_PizzasID",
                        column: x => x.PizzasID,
                        principalTable: "Pizzas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaTopping_Toppings_ToppingsID",
                        column: x => x.ToppingsID,
                        principalTable: "Toppings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreID",
                table: "Orders",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustID",
                table: "Pizzas",
                column: "CrustID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderID",
                table: "Pizzas",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_PresetPizzaID",
                table: "Pizzas",
                column: "PresetPizzaID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeID",
                table: "Pizzas",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaTopping_ToppingsID",
                table: "PizzaTopping",
                column: "ToppingsID");

            migrationBuilder.CreateIndex(
                name: "IX_PresetPizzaTopping_ToppingsID",
                table: "PresetPizzaTopping",
                column: "ToppingsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaTopping");

            migrationBuilder.DropTable(
                name: "PresetPizzaTopping");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Crusts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PresetPizza");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
