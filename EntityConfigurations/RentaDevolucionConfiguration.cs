using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TurboRentCar.Entities;

namespace TurboRentCar.EntityConfigurations
{
    public class RentaDevolucionConfiguration : IEntityTypeConfiguration<RentaDevolucion>
    {
        public void Configure(EntityTypeBuilder<RentaDevolucion> builder)
        {
            builder.ToTable("RentaDevolucion");
            builder.HasKey(rd => rd.Id);
            builder.HasData(
                new RentaDevolucion { Id = 1, VehiculoId = 1, ClienteId = 1, EmpleadoId = 1, FechaRenta = new DateTime(2025, 2, 18), FechaDevolucion = new DateTime(2025, 2, 20), MontoPorDia = 1000.00m, CantidadDias = 2, Comentario = "Renta de prueba", Estado = "Activa" },
                new RentaDevolucion { Id = 2, VehiculoId = 2, ClienteId = 2, EmpleadoId = 2, FechaRenta = new DateTime(2025, 2, 18), FechaDevolucion = new DateTime(2025, 2, 20), MontoPorDia = 1500.00m, CantidadDias = 2, Comentario = "Renta de prueba", Estado = "Activa" },
                new RentaDevolucion { Id = 3, VehiculoId = 3, ClienteId = 3, EmpleadoId = 3, FechaRenta = new DateTime(2025, 2, 18), FechaDevolucion = new DateTime(2025, 2, 20), MontoPorDia = 1200.00m, CantidadDias = 2, Comentario = "Renta de prueba", Estado = "Activa" },
                new RentaDevolucion { Id = 4, VehiculoId = 4, ClienteId = 4, EmpleadoId = 1, FechaRenta = new DateTime(2025, 2, 18), FechaDevolucion = new DateTime(2025, 2, 20), MontoPorDia = 2000.00m, CantidadDias = 2, Comentario = "Renta de prueba", Estado = "Activa" }
                );
        }
    }
}

