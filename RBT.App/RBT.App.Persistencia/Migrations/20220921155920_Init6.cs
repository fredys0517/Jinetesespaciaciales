using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RBT.App.Persistencia.Migrations
{
    public partial class Init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mantenimientos_Vehiculos_vehiculoId",
                table: "Mantenimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reparaciones_Mantenimientos_mantenimientoId",
                table: "Reparaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Soats_Vehiculos_vehiculoId",
                table: "Soats");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Mecanicos_mecanicoId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Propietarios_propietarioId",
                table: "Vehiculos");

            migrationBuilder.AlterColumn<int>(
                name: "propietarioId",
                table: "Vehiculos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "mecanicoId",
                table: "Vehiculos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "vehiculoId",
                table: "Soats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "mantenimientoId",
                table: "Reparaciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "vehiculoId",
                table: "Mantenimientos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Mantenimientos_Vehiculos_vehiculoId",
                table: "Mantenimientos",
                column: "vehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reparaciones_Mantenimientos_mantenimientoId",
                table: "Reparaciones",
                column: "mantenimientoId",
                principalTable: "Mantenimientos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Soats_Vehiculos_vehiculoId",
                table: "Soats",
                column: "vehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Mecanicos_mecanicoId",
                table: "Vehiculos",
                column: "mecanicoId",
                principalTable: "Mecanicos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Propietarios_propietarioId",
                table: "Vehiculos",
                column: "propietarioId",
                principalTable: "Propietarios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mantenimientos_Vehiculos_vehiculoId",
                table: "Mantenimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reparaciones_Mantenimientos_mantenimientoId",
                table: "Reparaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Soats_Vehiculos_vehiculoId",
                table: "Soats");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Mecanicos_mecanicoId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Propietarios_propietarioId",
                table: "Vehiculos");

            migrationBuilder.AlterColumn<int>(
                name: "propietarioId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "mecanicoId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "vehiculoId",
                table: "Soats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "mantenimientoId",
                table: "Reparaciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "vehiculoId",
                table: "Mantenimientos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mantenimientos_Vehiculos_vehiculoId",
                table: "Mantenimientos",
                column: "vehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reparaciones_Mantenimientos_mantenimientoId",
                table: "Reparaciones",
                column: "mantenimientoId",
                principalTable: "Mantenimientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Soats_Vehiculos_vehiculoId",
                table: "Soats",
                column: "vehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
