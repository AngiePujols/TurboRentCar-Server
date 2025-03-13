using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TurboRentCar.Entities;

namespace TurboRentCar.EntityConfigurations
{
    public class InspeccionConfiguration : IEntityTypeConfiguration<Inspeccion>
    {
        public void Configure(EntityTypeBuilder<Inspeccion> builder)
        {
            builder.ToTable("Inspeccion");
            builder.HasKey(i => i.Id);

            builder.HasOne(i => i.Vehiculo)
                .WithMany()
                .HasForeignKey(i => i.VehiculoId);

            builder.HasOne(i => i.Cliente)
                .WithMany()
                .HasForeignKey(i => i.ClienteId);

            builder.HasOne(i => i.Empleados)
                .WithMany()
                .HasForeignKey(i => i.EmpleadoId);

            builder.HasData(
                new Inspeccion { Id = 1, VehiculoId = 1, ClienteId = 1, EmpleadoId = 1, TieneRalladuras = false, CantidadCombustible = "Lleno", TieneGomaRespuesta = true, TieneGato = true, TieneRoturasCristal = false, EstadoGomas = "Buen estado", Fecha = new DateTime(2025, 2, 18), Estado = "Pendiente" },
                new Inspeccion { Id = 2, VehiculoId = 2, ClienteId = 2, EmpleadoId = 2, TieneRalladuras = true, CantidadCombustible = "Medio tanque", TieneGomaRespuesta = true, TieneGato = true, TieneRoturasCristal = true, EstadoGomas = "Buen estado", Fecha = new DateTime(2025, 2, 18), Estado = "Pendiente" },
                new Inspeccion { Id = 3, VehiculoId = 3, ClienteId = 3, EmpleadoId = 3, TieneRalladuras = false, CantidadCombustible = "Cuarto tanque", TieneGomaRespuesta = true, TieneGato = true, TieneRoturasCristal = false, EstadoGomas = "Buen estado", Fecha = new DateTime(2025, 2, 18), Estado = "Pendiente" },
                new Inspeccion { Id = 4, VehiculoId = 4, ClienteId = 4, EmpleadoId = 1, TieneRalladuras = true, CantidadCombustible = "Lleno", TieneGomaRespuesta = true, TieneGato = true, TieneRoturasCristal = true, EstadoGomas = "Buen estado", Fecha = new DateTime(2025, 2, 18), Estado = "Pendiente" }
            );
        }
    }
}
