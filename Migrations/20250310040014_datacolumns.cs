using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TurboRentCar.Migrations
{
    /// <inheritdoc />
    public partial class datacolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Modelos",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Modelos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Empleados",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "tanda_labor",
                table: "Empleados",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "porcentaje_comision",
                table: "Empleados",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Empleados",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "foto",
                table: "Empleados",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_nacimiento",
                table: "Empleados",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_contratacion",
                table: "Empleados",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Empleados",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "Empleados",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cedula",
                table: "Empleados",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NoTarjetaCredito = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LimiteCredito = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoVehiculoId = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    ModeloId = table.Column<int>(type: "int", nullable: false),
                    TipoCombustibleId = table.Column<int>(type: "int", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculo_Modelos_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "Modelos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculo_TipoCombustible_TipoCombustibleId",
                        column: x => x.TipoCombustibleId,
                        principalTable: "TipoCombustible",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculo_Tipos_Vehiculos_TipoVehiculoId",
                        column: x => x.TipoVehiculoId,
                        principalTable: "Tipos_Vehiculos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inspeccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiculoId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    TieneRalladuras = table.Column<bool>(type: "bit", nullable: false),
                    CantidadCombustible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TieneGomaRespuesta = table.Column<bool>(type: "bit", nullable: false),
                    TieneGato = table.Column<bool>(type: "bit", nullable: false),
                    TieneRoturasCristal = table.Column<bool>(type: "bit", nullable: false),
                    EstadoGomas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspeccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inspeccion_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inspeccion_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inspeccion_Vehiculo_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RentaDevolucion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false),
                    FechaRenta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontoPorDia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CantidadDias = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentaDevolucion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentaDevolucion_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentaDevolucion_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentaDevolucion_Vehiculo_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Apellido", "Cedula", "Estado", "LimiteCredito", "NoTarjetaCredito", "Nombre", "TipoPersona" },
                values: new object[,]
                {
                    { 1, "Pérez", "001-1234567-8", "Activo", 50000.00m, "1234-5678-1234-5678", "Juan", "Física" },
                    { 2, "Martínez", "002-2345678-9", "Activo", 75000.00m, "2345-6789-2345-6789", "María", "Física" },
                    { 3, "González", "003-3456789-0", "Activo", 60000.00m, "3456-7890-3456-7890", "Pedro", "Física" },
                    { 4, "Jiménez", "004-4567890-1", "Activo", 100000.00m, "4567-8901-4567-8901", "Ana", "Física" },
                    { 5, "Rodríguez", "005-5678901-2", "Activo", 80000.00m, "5678-9012-5678-9012", "José", "Física" }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "cedula", "direccion", "email", "estado", "fecha_contratacion", "fecha_nacimiento", "foto", "nombre", "porcentaje_comision", "tanda_labor", "telefono" },
                values: new object[,]
                {
                    { 1, "001-1234567-8", "Calle 123", "juan.perez@email.com", "Activo", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "juan.jpg", "Juan Pérez", 5.00m, "Matutina", "809-555-1234" },
                    { 2, "002-2345678-9", "Avenida Central 45", "maria.martinez@email.com", "Activo", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "maria.jpg", "María Martínez", 7.50m, "Vespertina", "809-555-5678" },
                    { 3, "003-3456789-0", "Calle Norte 78", "pedro.gonzalez@email.com", "Activo", new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "pedro.jpg", "Pedro González", 6.00m, "Nocturna", "809-555-9101" }
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "Id", "Descripcion", "Estado" },
                values: new object[,]
                {
                    { 1, "Toyota", "Activo" },
                    { 2, "Hyundai", "Activo" },
                    { 3, "Kia", "Activo" },
                    { 4, "Honda", "Activo" },
                    { 5, "Nissan", "Activo" }
                });

            migrationBuilder.InsertData(
                table: "TipoCombustible",
                columns: new[] { "Id", "Descripcion", "Estado" },
                values: new object[,]
                {
                    { 1, "Gasolina", "Activo" },
                    { 2, "Diesel", "Activo" },
                    { 3, "Gas", "Activo" },
                    { 4, "Híbrido", "Activo" },
                    { 5, "Eléctrico", "Activo" }
                });

            migrationBuilder.InsertData(
                table: "Tipos_Vehiculos",
                columns: new[] { "Id", "Descripcion", "Estado" },
                values: new object[,]
                {
                    { 1, "Sedán", "Activo" },
                    { 2, "Camioneta", "Activo" },
                    { 3, "Jeepeta", "Activo" },
                    { 4, "Furgoneta", "Activo" },
                    { 5, "Microbús", "Activo" }
                });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "Id", "Descripcion", "Estado", "MarcaId" },
                values: new object[,]
                {
                    { 1, "Sedán", "Activo", 1 },
                    { 2, "SUV", "Activo", 2 },
                    { 3, "Coupé", "Activo", 3 },
                    { 4, "Hatchback", "Activo", 4 },
                    { 5, "Pickup", "Activo", 5 }
                });

            migrationBuilder.InsertData(
                table: "Vehiculo",
                columns: new[] { "Id", "Estado", "MarcaId", "ModeloId", "Placa", "TipoCombustibleId", "TipoVehiculoId" },
                values: new object[,]
                {
                    { 1, "Disponible", 1, 1, "A123456", 1, 1 },
                    { 2, "Disponible", 2, 2, "B234567", 2, 2 },
                    { 3, "Disponible", 3, 3, "C345678", 3, 3 },
                    { 4, "Disponible", 4, 4, "D456789", 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Inspeccion",
                columns: new[] { "Id", "CantidadCombustible", "ClienteId", "EmpleadoId", "Estado", "EstadoGomas", "Fecha", "TieneGato", "TieneGomaRespuesta", "TieneRalladuras", "TieneRoturasCristal", "VehiculoId" },
                values: new object[,]
                {
                    { 1, "Lleno", 1, 1, "Pendiente", "Buen estado", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, 1 },
                    { 2, "Medio tanque", 2, 2, "Pendiente", "Buen estado", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, true, 2 },
                    { 3, "Cuarto tanque", 3, 3, "Pendiente", "Buen estado", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, 3 },
                    { 4, "Lleno", 4, 1, "Pendiente", "Buen estado", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, true, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "RentaDevolucion",
                columns: new[] { "Id", "CantidadDias", "ClienteId", "Comentario", "EmpleadoId", "Estado", "FechaDevolucion", "FechaRenta", "MontoPorDia", "VehiculoId" },
                values: new object[,]
                {
                    { 1, 2, 1, "Renta de prueba", 1, "Activa", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000.00m, 1 },
                    { 2, 2, 2, "Renta de prueba", 2, "Activa", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1500.00m, 2 },
                    { 3, 2, 3, "Renta de prueba", 3, "Activa", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200.00m, 3 },
                    { 4, 2, 4, "Renta de prueba", 1, "Activa", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000.00m, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_ClienteId",
                table: "Inspeccion",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_EmpleadoId",
                table: "Inspeccion",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_VehiculoId",
                table: "Inspeccion",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_RentaDevolucion_ClienteId",
                table: "RentaDevolucion",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_RentaDevolucion_EmpleadoId",
                table: "RentaDevolucion",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_RentaDevolucion_VehiculoId",
                table: "RentaDevolucion",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_MarcaId",
                table: "Vehiculo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_ModeloId",
                table: "Vehiculo",
                column: "ModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_TipoCombustibleId",
                table: "Vehiculo",
                column: "TipoCombustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_TipoVehiculoId",
                table: "Vehiculo",
                column: "TipoVehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos");

            migrationBuilder.DropTable(
                name: "Inspeccion");

            migrationBuilder.DropTable(
                name: "RentaDevolucion");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TipoCombustible",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoCombustible",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoCombustible",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoCombustible",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoCombustible",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tipos_Vehiculos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tipos_Vehiculos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tipos_Vehiculos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tipos_Vehiculos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tipos_Vehiculos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Modelos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Modelos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "tanda_labor",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<decimal>(
                name: "porcentaje_comision",
                table: "Empleados",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "foto",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_nacimiento",
                table: "Empleados",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_contratacion",
                table: "Empleados",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "cedula",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_MarcaId",
                table: "Modelos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
