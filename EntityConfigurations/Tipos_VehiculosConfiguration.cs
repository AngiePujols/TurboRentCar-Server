using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TurboRentCar.Entities;

namespace TurboRentCar.EntityConfigurations
{
    public class Tipos_VehiculosConfiguration : IEntityTypeConfiguration<Tipos_Vehiculos>
    {
        public void Configure(EntityTypeBuilder<Tipos_Vehiculos> builder)
        {
            builder.ToTable("Tipos_Vehiculos");
            builder.HasKey(tv => tv.Id);
            builder.HasData(
                new Tipos_Vehiculos { Id = 1, Descripcion = "Sedán", Estado = "Activo" },
                new Tipos_Vehiculos { Id = 2, Descripcion = "Camioneta", Estado = "Activo" },
                new Tipos_Vehiculos { Id = 3, Descripcion = "Jeepeta", Estado = "Activo" },
                new Tipos_Vehiculos { Id = 4, Descripcion = "Furgoneta", Estado = "Activo" },
                new Tipos_Vehiculos { Id = 5, Descripcion = "Microbús", Estado = "Activo" }
            );
        }
    }
}

