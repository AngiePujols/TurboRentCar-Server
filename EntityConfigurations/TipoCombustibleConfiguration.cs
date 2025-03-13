using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TurboRentCar.Entities;

namespace TurboRentCar.EntityConfigurations
{
    public class TipoCombustibleConfiguration : IEntityTypeConfiguration<TipoCombustible>
    {
        public void Configure(EntityTypeBuilder<TipoCombustible> builder)
        {
            builder.ToTable("TipoCombustible");
            builder.HasKey(tc => tc.Id);
            builder.HasData(
                new TipoCombustible { Id = 1, Descripcion = "Gasolina", Estado = "Activo" },
                new TipoCombustible { Id = 2, Descripcion = "Diesel", Estado = "Activo" },
                new TipoCombustible { Id = 3, Descripcion = "Gas", Estado = "Activo" },
                new TipoCombustible { Id = 4, Descripcion = "Híbrido", Estado = "Activo" },
                new TipoCombustible { Id = 5, Descripcion = "Eléctrico", Estado = "Activo" }
            );
        }
           

    }
}

