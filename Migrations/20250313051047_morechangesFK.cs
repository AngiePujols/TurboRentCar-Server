using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TurboRentCar.Migrations
{
    /// <inheritdoc />
    public partial class morechangesFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcasId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModelosId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoCombustibleId1",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipos_VehiculosId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarcasId",
                table: "Modelos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId1",
                table: "Inspeccion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadosId",
                table: "Inspeccion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId1",
                table: "Inspeccion",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Inspeccion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClienteId1", "EmpleadosId", "VehiculoId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Inspeccion",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClienteId1", "EmpleadosId", "VehiculoId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Inspeccion",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClienteId1", "EmpleadosId", "VehiculoId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Inspeccion",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClienteId1", "EmpleadosId", "VehiculoId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 1,
                column: "MarcasId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 2,
                column: "MarcasId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 3,
                column: "MarcasId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 4,
                column: "MarcasId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 5,
                column: "MarcasId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MarcasId", "ModelosId", "TipoCombustibleId1", "Tipos_VehiculosId" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MarcasId", "ModelosId", "TipoCombustibleId1", "Tipos_VehiculosId" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MarcasId", "ModelosId", "TipoCombustibleId1", "Tipos_VehiculosId" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MarcasId", "ModelosId", "TipoCombustibleId1", "Tipos_VehiculosId" },
                values: new object[] { null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_MarcasId",
                table: "Vehiculo",
                column: "MarcasId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_ModelosId",
                table: "Vehiculo",
                column: "ModelosId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_TipoCombustibleId1",
                table: "Vehiculo",
                column: "TipoCombustibleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Tipos_VehiculosId",
                table: "Vehiculo",
                column: "Tipos_VehiculosId");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MarcasId",
                table: "Modelos",
                column: "MarcasId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_ClienteId1",
                table: "Inspeccion",
                column: "ClienteId1");

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_EmpleadosId",
                table: "Inspeccion",
                column: "EmpleadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_VehiculoId1",
                table: "Inspeccion",
                column: "VehiculoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Cliente_ClienteId1",
                table: "Inspeccion",
                column: "ClienteId1",
                principalTable: "Cliente",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Empleados_EmpleadosId",
                table: "Inspeccion",
                column: "EmpleadosId",
                principalTable: "Empleados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Vehiculo_VehiculoId1",
                table: "Inspeccion",
                column: "VehiculoId1",
                principalTable: "Vehiculo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_MarcasId",
                table: "Modelos",
                column: "MarcasId",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Marcas_MarcasId",
                table: "Vehiculo",
                column: "MarcasId",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelos_ModelosId",
                table: "Vehiculo",
                column: "ModelosId",
                principalTable: "Modelos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_TipoCombustible_TipoCombustibleId1",
                table: "Vehiculo",
                column: "TipoCombustibleId1",
                principalTable: "TipoCombustible",
                principalColumn: "Id");

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
                name: "FK_Inspeccion_Cliente_ClienteId1",
                table: "Inspeccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Empleados_EmpleadosId",
                table: "Inspeccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Vehiculo_VehiculoId1",
                table: "Inspeccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_MarcasId",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Marcas_MarcasId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelos_ModelosId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_TipoCombustible_TipoCombustibleId1",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Tipos_Vehiculos_Tipos_VehiculosId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_MarcasId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_ModelosId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_TipoCombustibleId1",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_Tipos_VehiculosId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Modelos_MarcasId",
                table: "Modelos");

            migrationBuilder.DropIndex(
                name: "IX_Inspeccion_ClienteId1",
                table: "Inspeccion");

            migrationBuilder.DropIndex(
                name: "IX_Inspeccion_EmpleadosId",
                table: "Inspeccion");

            migrationBuilder.DropIndex(
                name: "IX_Inspeccion_VehiculoId1",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "MarcasId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "ModelosId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "TipoCombustibleId1",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "Tipos_VehiculosId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "MarcasId",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "ClienteId1",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "EmpleadosId",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "VehiculoId1",
                table: "Inspeccion");
        }
    }
}
