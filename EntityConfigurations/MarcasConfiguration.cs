using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TurboRentCar.Entities;

namespace TurboRentCar.EntityConfigurations
{
    public class MarcasConfigurations : IEntityTypeConfiguration<Marcas>
    {
        public void Configure(EntityTypeBuilder<Marcas> builder)
        {
           builder.ToTable("Marcas");
           builder.HasKey(Marcas => Marcas.Id);
            builder.HasData(
                new Marcas { Id = 1, Descripcion = "Toyota", Estado = "Activo" },
                new Marcas { Id = 2, Descripcion = "Hyundai", Estado = "Activo" },
                new Marcas { Id = 3, Descripcion = "Kia", Estado = "Activo" },
                new Marcas { Id = 4, Descripcion = "Honda", Estado = "Activo" },
                new Marcas { Id = 5, Descripcion = "Nissan", Estado = "Activo" }
                );

        }
    }
}

