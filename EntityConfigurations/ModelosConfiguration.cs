using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TurboRentCar.Dto;
using TurboRentCar.Entities;

namespace TurboRentCar.EntityConfigurations
{
    public class ModelosConfiguration : IEntityTypeConfiguration<Modelos>
    {
        public void Configure(EntityTypeBuilder<Modelos> builder)
        {
            builder.ToTable("Modelos");
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(m => m.Estado)
                .IsRequired()
                .HasMaxLength(15);

            builder.HasData(
                new Modelos { Id = 1, Descripcion = "Sedán", Estado = "Activo" },
                new Modelos { Id = 2, Descripcion = "SUV", Estado = "Activo" },
                new Modelos { Id = 3, Descripcion = "Coupé", Estado = "Activo" },
                new Modelos { Id = 4, Descripcion = "Hatchback", Estado = "Activo" },
                new Modelos { Id = 5, Descripcion = "Pickup", Estado = "Activo" }
            );

           

        }   

    }
}

