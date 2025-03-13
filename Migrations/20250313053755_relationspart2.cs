using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TurboRentCar.Migrations
{
    /// <inheritdoc />
    public partial class relationspart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_MarcasId",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Marcas_MarcaId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Marcas_MarcasId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelos_ModeloId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelos_ModelosId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_TipoCombustible_TipoCombustibleId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas",
                table: "Modelos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Marcas",
                table: "Vehiculo",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelos",
                table: "Vehiculo",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_TipoCombustible",
                table: "Vehiculo",
                column: "TipoCombustibleId",
                principalTable: "TipoCombustible",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Marcas",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelos",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_TipoCombustible",
                table: "Vehiculo");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_MarcasId",
                table: "Modelos",
                column: "MarcasId",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Marcas_MarcaId",
                table: "Vehiculo",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Marcas_MarcasId",
                table: "Vehiculo",
                column: "MarcasId",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelos_ModeloId",
                table: "Vehiculo",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
