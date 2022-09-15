using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RBT.App.Persistencia.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "mecanicoId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "propietarioId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_mecanicoId",
                table: "Vehiculos",
                column: "mecanicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_propietarioId",
                table: "Vehiculos",
                column: "propietarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Mecanicos_mecanicoId",
                table: "Vehiculos",
                column: "mecanicoId",
                principalTable: "Mecanicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Propietarios_propietarioId",
                table: "Vehiculos",
                column: "propietarioId",
                principalTable: "Propietarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Mecanicos_mecanicoId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Propietarios_propietarioId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_mecanicoId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_propietarioId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "mecanicoId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "propietarioId",
                table: "Vehiculos");
        }
    }
}
