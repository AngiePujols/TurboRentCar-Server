using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TurboRentCar.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Cliente_ClienteId",
                table: "Inspeccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Empleados_EmpleadoId",
                table: "Inspeccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Vehiculo_VehiculoId",
                table: "Inspeccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelos_ModeloId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_TipoCombustible_TipoCombustibleId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Tipos_Vehiculos_TipoVehiculoId",
                table: "Vehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Cliente_ClienteId",
                table: "Inspeccion",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Empleados_EmpleadoId",
                table: "Inspeccion",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Vehiculo_VehiculoId",
                table: "Inspeccion",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelos_ModeloId",
                table: "Vehiculo",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_TipoCombustible_TipoCombustibleId",
                table: "Vehiculo",
                column: "TipoCombustibleId",
                principalTable: "TipoCombustible",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Tipos_Vehiculos_TipoVehiculoId",
                table: "Vehiculo",
                column: "TipoVehiculoId",
                principalTable: "Tipos_Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Cliente_ClienteId",
                table: "Inspeccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Empleados_EmpleadoId",
                table: "Inspeccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Vehiculo_VehiculoId",
                table: "Inspeccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelos_ModeloId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_TipoCombustible_TipoCombustibleId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Tipos_Vehiculos_TipoVehiculoId",
                table: "Vehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Cliente_ClienteId",
                table: "Inspeccion",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Empleados_EmpleadoId",
                table: "Inspeccion",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Vehiculo_VehiculoId",
                table: "Inspeccion",
                column: "VehiculoId",
                principalTable: "Vehiculo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelos_ModeloId",
                table: "Vehiculo",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_TipoCombustible_TipoCombustibleId",
                table: "Vehiculo",
                column: "TipoCombustibleId",
                principalTable: "TipoCombustible",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Tipos_Vehiculos_TipoVehiculoId",
                table: "Vehiculo",
                column: "TipoVehiculoId",
                principalTable: "Tipos_Vehiculos",
                principalColumn: "Id");
        }
    }
}
