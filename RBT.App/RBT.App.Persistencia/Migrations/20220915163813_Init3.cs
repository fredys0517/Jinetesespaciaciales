using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RBT.App.Persistencia.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "mantenimientoId",
                table: "Reparaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Propietarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CiudadResidencia",
                table: "Propietarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Reparaciones_mantenimientoId",
                table: "Reparaciones",
                column: "mantenimientoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reparaciones_Mantenimientos_mantenimientoId",
                table: "Reparaciones",
                column: "mantenimientoId",
                principalTable: "Mantenimientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reparaciones_Mantenimientos_mantenimientoId",
                table: "Reparaciones");

            migrationBuilder.DropIndex(
                name: "IX_Reparaciones_mantenimientoId",
                table: "Reparaciones");

            migrationBuilder.DropColumn(
                name: "mantenimientoId",
                table: "Reparaciones");

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Propietarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CiudadResidencia",
                table: "Propietarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
