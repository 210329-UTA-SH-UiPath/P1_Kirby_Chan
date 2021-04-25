using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class UpdatePresetPizza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_PresetPizza_PresetPizzaID",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_PresetPizzaTopping_PresetPizza_PresetPizzasID",
                table: "PresetPizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PresetPizza",
                table: "PresetPizza");

            migrationBuilder.RenameTable(
                name: "PresetPizza",
                newName: "PresetPizzas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PresetPizzas",
                table: "PresetPizzas",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_PresetPizzas_PresetPizzaID",
                table: "Pizzas",
                column: "PresetPizzaID",
                principalTable: "PresetPizzas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PresetPizzaTopping_PresetPizzas_PresetPizzasID",
                table: "PresetPizzaTopping",
                column: "PresetPizzasID",
                principalTable: "PresetPizzas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_PresetPizzas_PresetPizzaID",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_PresetPizzaTopping_PresetPizzas_PresetPizzasID",
                table: "PresetPizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PresetPizzas",
                table: "PresetPizzas");

            migrationBuilder.RenameTable(
                name: "PresetPizzas",
                newName: "PresetPizza");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PresetPizza",
                table: "PresetPizza",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_PresetPizza_PresetPizzaID",
                table: "Pizzas",
                column: "PresetPizzaID",
                principalTable: "PresetPizza",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PresetPizzaTopping_PresetPizza_PresetPizzasID",
                table: "PresetPizzaTopping",
                column: "PresetPizzasID",
                principalTable: "PresetPizza",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
