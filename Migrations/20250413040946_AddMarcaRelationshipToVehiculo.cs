using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TurboRentCar.Migrations
{
    /// <inheritdoc />
    public partial class AddMarcaRelationshipToVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelos",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_TipoCombustible",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Tipos_Vehiculos_TipoVehiculoId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_ModeloId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_TipoVehiculoId",
                table: "Vehiculo");

            migrationBuilder.AddColumn<int>(
                name: "ModelosId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipos_VehiculosId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModelosId", "Tipos_VehiculosId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModelosId", "Tipos_VehiculosId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModelosId", "Tipos_VehiculosId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModelosId", "Tipos_VehiculosId" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_ModelosId",
                table: "Vehiculo",
                column: "ModelosId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Tipos_VehiculosId",
                table: "Vehiculo",
                column: "Tipos_VehiculosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelos_ModelosId",
                table: "Vehiculo",
                column: "ModelosId",
                principalTable: "Modelos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_TipoCombustible_TipoCombustibleId",
                table: "Vehiculo",
                column: "TipoCombustibleId",
                principalTable: "TipoCombustible",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Tipos_Vehiculos_Tipos_VehiculosId",
                table: "Vehiculo",
                column: "Tipos_VehiculosId",
                principalTable: "Tipos_Vehiculos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelos_ModelosId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_TipoCombustible_TipoCombustibleId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Tipos_Vehiculos_Tipos_VehiculosId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_ModelosId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_Tipos_VehiculosId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "ModelosId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "Tipos_VehiculosId",
                table: "Vehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_ModeloId",
                table: "Vehiculo",
                column: "ModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_TipoVehiculoId",
                table: "Vehiculo",
                column: "TipoVehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelos",
                table: "Vehiculo",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_TipoCombustible",
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
    }
}
