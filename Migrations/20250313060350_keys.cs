using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TurboRentCar.Migrations
{
    /// <inheritdoc />
    public partial class keys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Modelos_MarcaId",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Modelos");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Marcas",
                table: "Vehiculo",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "MarcaId",
                table: "Modelos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 1,
                column: "MarcaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 2,
                column: "MarcaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 3,
                column: "MarcaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 4,
                column: "MarcaId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 5,
                column: "MarcaId",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MarcaId",
                table: "Modelos",
                column: "MarcaId");

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
    }
}
